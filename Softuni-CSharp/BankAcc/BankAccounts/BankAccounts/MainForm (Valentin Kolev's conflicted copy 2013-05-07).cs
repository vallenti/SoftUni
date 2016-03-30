using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountsNamespace
{
    public partial class MainForm : Form
    {
        public string users = "users.txt";
        public string employees = "employees.txt";
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        public Random randGen = new Random();
        public void GenerateData()
        {
            string[] maleNames = new string[] { "Георги", "Петър", "Димитър", "Спас", "Славей", "Бойко" };
            string[] femaleNames = new string[] { "Женя", "Димитринка", "Петя", "Елисавета", "Соня", "Натали" };
            string[] maleFamilies = new string[] {"Петров","Колев","Киров","Благоев","Лосов","Котков" };
            string[] femaleFamilies = new string[] {"Пеева","Вълева","Сиренкова","Спасова","Стоянова","Костадинова"};
            Individual.sexEnum male = Individual.sexEnum.мъж;
            Individual.sexEnum female = Individual.sexEnum.жена;
            for (int i = 0; i < 40; i++)
            {
                int index = randGen.Next(0,6);
                int egnMale = randGen.Next(11111111,99999999);
                int egnFemale = randGen.Next(1111111, 9999999);
                int age = randGen.Next(18,100);
                clients.Add(new Individual(maleNames[index],maleFamilies[index],egnMale.ToString(),age,male));
                clients.Add(new Individual(femaleNames[index], femaleFamilies[index], egnFemale.ToString(), age, female));
            }
            for (int i = 0; i < 40; i++)
            {
                string name = "Фирма"+i+" ООД";
                int eik = randGen.Next(100000,999999);
                companies.Add(new Company(name,eik.ToString()));
            }
            for (int i = 0; i < 40; i++)
            {
                int balance = randGen.Next(1,50001);
                int period = randGen.Next(1,20);
                depositAcc.Add(new DepositAccount((Individual)clients[i],balance,0.05,period));
                depositAcc.Add(new DepositAccount((Company)companies[i], balance, 0.05, period));

            }
            for (int i = 0; i < 40; i++)
            {
                int balance = randGen.Next(1, 50001);
                int period = randGen.Next(1, 20);
                loanAcc.Add(new LoanAccount((Individual)clients[i], balance, 0.05, period));
                loanAcc.Add(new LoanAccount((Company)companies[i], balance, 0.05, period));
            }
            for (int i = 0; i < 40; i++)
            {
                int balance = randGen.Next(1, 50001);
                int period = randGen.Next(1, 20);
                mortgageAcc.Add(new MortgageAccount((Individual)clients[i], balance, 0.05, period));
                mortgageAcc.Add(new MortgageAccount((Company)companies[i], balance, 0.05, period));
            }
            depositAcc.Add(new DepositAccount(new Individual("Валентин", "Колев", "9203020540", 21, male), 1000, 0.05, 10));
            depositAcc.Add(new DepositAccount(new Individual("Георги", "Петров", "9210130540", 20, male), 1000, 0.05, 10));
        }
        public MainForm()
        {
            InitializeComponent();
            GenerateData();
            menuStrip1.Enabled = false;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
           

            StreamReader loginInfoUsers = new StreamReader(users);
            StreamReader loginInfoEmployees = new StreamReader(employees);
            string userName, password;
            bool logged = false;
            using (loginInfoEmployees)
            {
                while (loginInfoEmployees.EndOfStream == false)
                {
                    string[] lineEmployee = loginInfoEmployees.ReadLine().Split(' ');
                    userName = lineEmployee[0];
                    password = lineEmployee[1];
                    if (userTB.Text == userName && pwTB.Text == password)
                    {
                        //commands for successful login as employee
                        toolStripStatusLabel1.Text = String.Format("Logged in as {0}", userName);
                        userTB.Enabled = false;
                        pwTB.Enabled = false;
                        menuStrip1.Enabled = true;
                        signOutBtn.Enabled = true;
                        logged = true;
                        break;

                    }
                }
                //command for unsuccessful login as employee
                if(logged == false)
                {
                    using (loginInfoUsers)
                    {
                        while (loginInfoUsers.EndOfStream == false)
                        {
                            string[] lineUser = loginInfoUsers.ReadLine().Split(' ');
                            userName = lineUser[0];
                            password = lineUser[1];
                            if (userTB.Text == userName && pwTB.Text == password)
                            {
                                //commands for successful login as user
                                ClientLogin clientLogin = new ClientLogin(userName, password, ref depositAcc, ref loanAcc, ref mortgageAcc);
                                clientLogin.ShowDialog();
                                Close();
                            }
                            else
                            {
                                //commands for unsucessful login as user and employee
                                toolStripStatusLabel1.Text = "Incorrect username or password";
                            }
                        }
                    }
                }
            }
            
        }

        private void новаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewAccount newAcc = new CreateNewAccount(ref depositAcc,ref loanAcc,ref mortgageAcc,ref clients,ref companies);
            newAcc.ShowDialog();
            
        }

        private void заПрограматаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgram aboutProg = new AboutProgram();
            aboutProg.ShowDialog();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void новToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewClient newClient = new CreateNewClient(ref clients, ref companies);
            newClient.ShowDialog();
        }

        private void изтрийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAccount delAcc = new DeleteAccount(ref depositAcc,ref loanAcc,ref mortgageAcc);
            delAcc.ShowDialog();
        }

        private void изтрийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteClient delClient = new DeleteClient(ref clients,ref companies);
            delClient.ShowDialog();
        }

        private void внасянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositInAccount depositInAcc = new DepositInAccount(depositAcc,loanAcc,mortgageAcc);
            depositInAcc.ShowDialog();
        }

        private void тегленеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrowFromAccount drowAcc = new DrowFromAccount(ref depositAcc);
            drowAcc.ShowDialog();
        }

        private void списъкСметкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountsList accList = new AccountsList(ref depositAcc, ref loanAcc, ref mortgageAcc,ref clients,ref companies);
            accList.ShowDialog();
        }

        private void списъкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsList clList = new ClientsList(clients,companies);
            clList.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            userTB.Enabled = true;
            pwTB.Enabled = true;
            toolStripStatusLabel1.Text = "Not logged in";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Query queryForm = new Query(ref depositAcc, ref loanAcc, ref mortgageAcc, ref clients, ref companies);
            queryForm.ShowDialog();
        }

        private void печатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintMortgage printMort = new PrintMortgage(ref mortgageAcc);
            printMort.ShowDialog();
        }

        private void редатирайToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void клиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient editClient = new EditClient(ref clients);
            editClient.ShowDialog();
        }

        private void фирмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCompany editCompany = new EditCompany(ref companies);
            editCompany.ShowDialog();
        }
    }
}
