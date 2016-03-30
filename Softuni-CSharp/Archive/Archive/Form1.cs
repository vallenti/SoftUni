using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net.Mail;

namespace Archive
{
    public partial class Form1 : Form
    {
        public static int countMistakes = 0;

     public static  string path = @"d:\test";
     public static  DateTime now = DateTime.Now;
     public static  string date = now.Year.ToString() + now.Month + now.Day;
     public static  string zipPath = @"d:\cdg20_" + date + ".zip";
        public Form1()
        {
            InitializeComponent();
            
            //schedule zipping
            //tray icon
            //run automatically
            //option to choose folder
            //keep settings
            //add progress bar to show status of uploading and sending message
            myNotifyIcon.BalloonTipText = "My application still working...";
            myNotifyIcon.BalloonTipTitle = "My Sample Application";
            myNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {


            try
            {
                ZipFile.CreateFromDirectory(path, zipPath, CompressionLevel.Optimal, true);
            }
            catch (Exception ex)
            {
                countMistakes++;
                zipPath = @"d:\cdg20_" + date +"_"+countMistakes+ ".zip";
                ZipFile.CreateFromDirectory(path, zipPath, CompressionLevel.Optimal, true);
            }
            MessageBox.Show("Архивирането беше извършено успешно!");

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("valle0302@hotmail.com", "Juve0302");

            MailAddress from = new MailAddress("valle0302@hotmail.com","Valentin Kolev",System.Text.Encoding.UTF8);
            MailAddress to = new MailAddress("vallentin.k@gmail.com");


            MailMessage message = new MailMessage(from, to);
            message.Body = "This is a test e-mail message sent by an application. ";
            message.BodyEncoding = System.Text.Encoding.UTF8;
            message.Subject = "test message 1";
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Attachments.Add(new Attachment(zipPath));

            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);

            string userState = "test message1";
            client.SendAsync(message, userState);

        }
        static bool mailSent = false;
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;
            if (e.Cancelled)
            {
                MessageBox.Show("[{0}] Send canceled.", token);
            }
            if (e.Error != null)
            {
                MessageBox.Show(String.Format("[{0}] {1}", token, e.Error.ToString()));
            }
            else
            {
                MessageBox.Show("Message sent.");
                File.Delete(zipPath);
            }
            mailSent = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

            if (FormWindowState.Minimized == WindowState)
                Hide();
            
        }

        private void myNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void възстановиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myNotifyIcon_DoubleClick(sender, e);
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void създайАрхивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            archiveButton_Click(sender, e);
        }
    }
}
