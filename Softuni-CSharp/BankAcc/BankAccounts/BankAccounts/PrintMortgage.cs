using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountsNamespace
{
    public partial class PrintMortgage : Form
    {
        ArrayList mortgageAcc = new ArrayList();
        private string documentContent;
        private string stringToPrint;
        private string printFilePath = "print.txt";
        public PrintMortgage(ref ArrayList mortgageAcc)
        {
            InitializeComponent();
            this.mortgageAcc = mortgageAcc;
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                comboBox1.Items.Add(mortAcc.Iban);
            }
        }
        private void createAmortizationSchedule()
        {
            MortgageAccount mortgageAccPrint = new MortgageAccount();
            StreamWriter printFile = new StreamWriter(printFilePath);
            double balance;
            double rate;
            double principal;
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                if (mortAcc.Iban == comboBox1.SelectedItem.ToString())
                {
                    mortgageAccPrint = mortAcc;
                }
            }
            //open print.txt an write amortization loan in it
            using (printFile)
            {
                string space = "          ";
                balance = mortgageAccPrint.Balance;
                rate = mortgageAccPrint.Interest * balance;
                principal = mortgageAccPrint.Balance / mortgageAccPrint.MortgagePeriod;
                printFile.WriteLine("Амортизационен план на {0} за сметка с IBAN: {1}", mortgageAccPrint.ClientName, mortgageAccPrint.Iban);
                printFile.WriteLine();
                printFile.Write("N{0}Остатък.{1}Лихва{2}Главница{3}Вноска",space,space,space,space);
                printFile.WriteLine();
                for (int i = 1; i <= mortgageAccPrint.MortgagePeriod; i++)
                {
                    printFile.Write("{0:000}{1}{2:00.00}{3}{4:00.00}{5}{6:00.00}{7}{8:00.00}", i, space, balance, space, rate, space, principal, space, (rate + principal));
                    balance = balance - principal;
                    rate = mortgageAccPrint.Interest * balance;
                    printFile.WriteLine();
                }
            }
        }
        private void ReadDocument()
        {
            StreamReader readFile = new StreamReader(printFilePath);
            using (readFile)
            {
                documentContent = readFile.ReadToEnd();
            }
            stringToPrint = documentContent;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            createAmortizationSchedule();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int charactersOnPage = 0;
            int linesPerPage = 0;

            // Sets the value of charactersOnPage to the number of characters  
            // of stringToPrint that will fit within the bounds of the page.
            e.Graphics.MeasureString(stringToPrint, this.Font,
                e.MarginBounds.Size, StringFormat.GenericTypographic,
                out charactersOnPage, out linesPerPage);

            // Draws the string within the bounds of the page.
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
            e.MarginBounds, StringFormat.GenericTypographic);

            // Remove the portion of the string that has been printed.
            stringToPrint = stringToPrint.Substring(charactersOnPage);

            // Check to see if more pages are to be printed.
            e.HasMorePages = (stringToPrint.Length > 0);

            // If there are no more pages, reset the string to be printed. 
            if (!e.HasMorePages)
                stringToPrint = documentContent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadDocument();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
