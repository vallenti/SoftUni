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
    public partial class CreateNewAccount : Form
    {
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        ArrayList allAccounts = new ArrayList();
        ArrayList allClients = new ArrayList();
        FileStream fs;
        BinaryFormatter bf = new BinaryFormatter();

        public CreateNewAccount(ref ArrayList depositAcc, ref ArrayList loanAcc, ref ArrayList mortgageAcc, ref ArrayList clients, ref ArrayList companies)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            this.loanAcc = loanAcc;
            this.mortgageAcc = mortgageAcc;
            this.clients = clients;
            this.companies = companies;
            sexComboBox.Items.Add("мъж");
            sexComboBox.Items.Add("жена");
            genererateAllAccountArray();
            generateAllClientsArray();
            generateExistingClientsCB();
        }
        public string GenerateIban()
        {
            StringBuilder ibanSB = new StringBuilder();
            Random randGen = new Random();
            ibanSB.Append("BG12 BANK ");
            for (int i = 1; i < 15; i++)
            {
                ibanSB.Append(randGen.Next(0, 10).ToString());
            }
            return ibanSB.ToString();
        }
        public void ShowIndividualsFields()
        {
            //individuals fields
            firstNameLabel.Enabled = true;
            firstNameTB.Enabled = true;
            lastNameLabel.Enabled = true;
            lastNameTB.Enabled = true;
            EGNLabel.Enabled = true;
            egnTB.Enabled = true;
            AgeLabel.Enabled = true;
            ageTB.Enabled = true;
            SexLabel.Enabled = true;
            sexComboBox.Enabled = true;

            //hide company fields
            companyNameLabel.Enabled = false;
            companyNameTB.Enabled = false;
            EIKLabel.Enabled = false;
            eikTB.Enabled = false;
        }
        public void ShowCompaniesFields()
        {
            //hide individuals fields
            firstNameLabel.Enabled = false;
            firstNameTB.Enabled = false;
            lastNameLabel.Enabled = false;
            lastNameTB.Enabled = false;
            EGNLabel.Enabled = false;
            egnTB.Enabled = false;
            AgeLabel.Enabled = false;
            ageTB.Enabled = false;
            SexLabel.Enabled = false;
            sexComboBox.Enabled = false;

            //show company fields
            companyNameLabel.Enabled = true;
            companyNameTB.Enabled = true;
            EIKLabel.Enabled = true;
            eikTB.Enabled = true;
        }
        public void genererateAllAccountArray()
        {
            allAccounts.AddRange(depositAcc);
            allAccounts.AddRange(loanAcc);
            allAccounts.AddRange(mortgageAcc);
        }
        public void generateAllClientsArray()
        {
            allClients.AddRange(clients);
            allClients.AddRange(companies);
        }
       
        private void generateExistingClientsCB()
        {
            ExistingClientComboBox.Items.Clear();
            foreach (Individual client in clients)
            {
                ExistingClientComboBox.Items.Add(client.Egn);
            }
            foreach (Company company in companies)
            {
                ExistingClientComboBox.Items.Add(company.Eik);
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewClientRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NewClientRadioBtn.Checked == true)
            {
                this.Size = new Size(657, 337);
            }
            else
            {
                this.Size = new Size(310, 337);
            }
        }

        private void NewIndividualRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NewIndividualRadioBtn.Checked == true)
            {
                ShowIndividualsFields();
            }
            else 
            {
                ShowCompaniesFields();
            }
        }
        private void ClearAll()
        {
            ExistingClientComboBox.ResetText();
            BalanceTB.ResetText();
            InterestTB.ResetText();
            PeriodTB.ResetText();
            firstNameTB.ResetText();
            lastNameTB.ResetText();
            egnTB.ResetText();
            ageTB.ResetText();
            companyNameTB.ResetText();
            eikTB.ResetText();
            DepositRadioBtn.Checked = false;
            LoanRadioBtn.Checked = false;
            MortgageRadioBtn.Checked = false;
            NewClientRadioBtn.Checked = false;
            ExistingClientRadioBtn.Checked = false;
            NewIndividualRadioBtn.Checked = false;
            NewCompanyRadioBtn.Checked = false;
        }
        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void CreateNewBtn_Click(object sender, EventArgs e)
        {
            Individual newClient;
            Company newCompany;
            DepositAccount newDepositAcc;
            LoanAccount newLoanAcc;
            MortgageAccount newMortgageAcc;
            double balance;
            double interest;
            int period;

            //create deposit account
            if (DepositRadioBtn.Checked == true)
            {
                if (NewClientRadioBtn.Checked == true)
                {
                    //create new client and new acc
                    if (NewIndividualRadioBtn.Checked == true)
                    {
                        //create new individual client
                        try
                        {
                            string firstName = firstNameTB.Text;
                            string lastName = lastNameTB.Text;
                            string egn = egnTB.Text;
                            int age = int.Parse(ageTB.Text);
                            Individual.sexEnum sex;
                            Individual.sexEnum male = Individual.sexEnum.мъж;
                            Individual.sexEnum female = Individual.sexEnum.жена;
                            if (sexComboBox.Text == "мъж")
                            {
                                sex = male;
                            }
                            else
                            {
                                sex = female;
                            }
                            newClient = new Individual(firstName, lastName, egn, age, sex);
                            clients.Add(newClient);
                            try
                            {
                                balance = double.Parse(BalanceTB.Text);
                                interest = double.Parse(InterestTB.Text);
                                period = int.Parse(PeriodTB.Text);
                                newDepositAcc = new DepositAccount(newClient, balance, interest, period);
                                depositAcc.Add(newDepositAcc);
                                generateExistingClientsCB();
                                ClearAll();
                            }
                            catch (FormatException)
                            {
                                notANumberError.SetError(BalanceTB, "Моля въведете число.");
                            }
                        }
                        catch (FormatException)
                        {
                            notANumberError.SetError(ageTB, "Моля въведете число.");
                        }
                    }
                    else
                    {
                        //create company and new deposit account
                        string name = companyNameTB.Text;
                        string eik = eikTB.Text;
                        newCompany = new Company(name, eik);
                        companies.Add(newCompany);
                        balance = double.Parse(BalanceTB.Text);
                        interest = double.Parse(InterestTB.Text);
                        period = int.Parse(PeriodTB.Text);
                        newDepositAcc = new DepositAccount(newCompany, balance, interest, period);
                        depositAcc.Add(newDepositAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }     
                }
                else
                {
                    //create new acc with existing client
                    int counter = 0;
                    int index = -1;
                    bool found = false;
                    try
                    {
                        balance = double.Parse(BalanceTB.Text);
                        interest = double.Parse(InterestTB.Text);
                        period = int.Parse(PeriodTB.Text);
                        foreach (Individual client in clients)
                        {
                            if (client.Egn == ExistingClientComboBox.Text)
                            {
                                index = counter;
                                found = true;
                                break;
                            }
                            counter++;
                        }
                        if (found == true)
                        {
                            newClient = (Individual)clients[index];
                            newDepositAcc = new DepositAccount(newClient, balance, interest, period);
                            depositAcc.Add(newDepositAcc);
                            generateExistingClientsCB();
                            ClearAll();
                        }
                        else
                        {
                            //create new acc with existing company
                            counter = 0;
                            index = -1;
                            foreach (Company company in companies)
                            {
                                if (company.Eik == ExistingClientComboBox.Text)
                                {
                                    index = counter;
                                    break;
                                }
                                counter++;
                            }
                            try
                            {
                                newCompany = (Company)companies[index];
                                newDepositAcc = new DepositAccount(newCompany, balance, interest, period);
                                depositAcc.Add(newDepositAcc);
                                generateExistingClientsCB();
                                ClearAll();
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                MessageBox.Show("Не съществува клиент с посоченото ЕГН/ЕИК.\nМоля създайте нов клиент или изберете друг от съществуващите", "Не съществуващ клиент");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        notANumberError.SetError(BalanceTB, "Моля въведете число.");
                        notANumberError.SetError(InterestTB, "Моля въведете число.");
                        notANumberError.SetError(PeriodTB, "Моля въведете число.");
                    }
                }
            }
            else if (LoanRadioBtn.Checked == true)
            {
                //TODO create loan account
                if (NewClientRadioBtn.Checked == true)
                {
                    //TODO create new client and new acc
                    if (NewIndividualRadioBtn.Checked == true)
                    {
                        //create individual client
                        try
                        {
                            string firstName = firstNameTB.Text;
                            string lastName = lastNameTB.Text;
                            string egn = egnTB.Text;
                            int age = int.Parse(ageTB.Text);
                            Individual.sexEnum sex;
                            Individual.sexEnum male = Individual.sexEnum.мъж;
                            Individual.sexEnum female = Individual.sexEnum.жена;
                            if (sexComboBox.Text == "мъж")
                            {
                                sex = male;
                            }
                            else
                            {
                                sex = female;
                            }
                            newClient = new Individual(firstName, lastName, egn, age, sex);
                            clients.Add(newClient);
                            try
                            {
                                balance = double.Parse(BalanceTB.Text);
                                interest = double.Parse(InterestTB.Text);
                                period = int.Parse(PeriodTB.Text);
                                newLoanAcc = new LoanAccount(newClient, balance, interest/100, period);
                                loanAcc.Add(newLoanAcc);
                                generateExistingClientsCB();
                                ClearAll();
                            }
                            catch (FormatException)
                            {
                                notANumberError.SetError(BalanceTB, "Моля въведете число.");
                            }
                        }
                        catch (FormatException)
                        {
                            notANumberError.SetError(ageTB, "Моля въведете число.");
                        }
                    }
                    else
                    {
                        //create company
                        string name = companyNameTB.Text;
                        string eik = eikTB.Text;
                        newCompany = new Company(name, eik);
                        companies.Add(newCompany);
                        balance = double.Parse(BalanceTB.Text);
                        interest = double.Parse(InterestTB.Text);
                        period = int.Parse(PeriodTB.Text);
                        newLoanAcc = new LoanAccount(newCompany, balance, interest/100, period);
                        loanAcc.Add(newLoanAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }
                }
                else
                {
                    //TODO create new acc with existing client
                    int counter = 0;
                    int index = -1;
                    bool found = false;
                    balance = double.Parse(BalanceTB.Text);
                    interest = double.Parse(InterestTB.Text);
                    period = int.Parse(PeriodTB.Text);
                    foreach (Individual client in clients)
                    {
                        if (client.Egn == ExistingClientComboBox.Text)
                        {
                            index = counter;
                            found = true;
                            break;
                        }
                        counter++;
                    }
                    if (found == true)
                    {
                        newClient = (Individual)clients[index];
                        newLoanAcc = new LoanAccount(newClient, balance, interest/100, period);
                        loanAcc.Add(newLoanAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }
                    else
                    {
                        counter = 0;
                        index = -1;
                        foreach (Company company in companies)
                        {
                            if (company.Eik == ExistingClientComboBox.Text)
                            {
                                index = counter;
                                break;
                            }
                            counter++;
                        }
                        newCompany = (Company)companies[index];
                        newLoanAcc = new LoanAccount(newCompany, balance, interest/100, period);
                        loanAcc.Add(newLoanAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }
                }
            }
            else
            {
                //TODO create mortgage account
                if (NewClientRadioBtn.Checked == true)
                {
                    //TODO create new client and new acc
                    if (NewIndividualRadioBtn.Checked == true)
                    {
                        //create individual client
                        try
                        {
                            string firstName = firstNameTB.Text;
                            string lastName = lastNameTB.Text;
                            string egn = egnTB.Text;
                            int age = int.Parse(ageTB.Text);
                            Individual.sexEnum sex;
                            Individual.sexEnum male = Individual.sexEnum.мъж;
                            Individual.sexEnum female = Individual.sexEnum.жена;
                            if (sexComboBox.Text == "мъж")
                            {
                                sex = male;
                            }
                            else
                            {
                                sex = female;
                            }
                            newClient = new Individual(firstName, lastName, egn, age, sex);
                            clients.Add(newClient);
                            try
                            {
                                balance = double.Parse(BalanceTB.Text);
                                interest = double.Parse(InterestTB.Text);
                                period = int.Parse(PeriodTB.Text);
                                newMortgageAcc = new MortgageAccount(newClient, balance, interest/100, period);
                                mortgageAcc.Add(newMortgageAcc);
                                generateExistingClientsCB();
                                ClearAll();
                            }
                            catch (FormatException)
                            {
                                notANumberError.SetError(BalanceTB, "Моля въведете число.");
                            }
                        }
                        catch (FormatException)
                        {
                            notANumberError.SetError(ageTB, "Моля въведете число.");
                        }
                    }
                    else
                    {
                        //create company
                        string name = companyNameTB.Text;
                        string eik = eikTB.Text;
                        newCompany = new Company(name, eik);
                        companies.Add(newCompany);
                        balance = double.Parse(BalanceTB.Text);
                        interest = double.Parse(InterestTB.Text);
                        period = int.Parse(PeriodTB.Text);
                        newMortgageAcc = new MortgageAccount(newCompany, balance, interest/100, period);
                        mortgageAcc.Add(newMortgageAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }
                }
                else
                {
                    //TODO create new acc with existing client
                    int counter = 0;
                    int index = -1;
                    bool found = false;
                    balance = double.Parse(BalanceTB.Text);
                    interest = double.Parse(InterestTB.Text);
                    period = int.Parse(PeriodTB.Text);
                    foreach (Individual client in clients)
                    {
                        if (client.Egn == ExistingClientComboBox.Text)
                        {
                            index = counter;
                            found = true;
                            break;
                        }
                        counter++;
                    }
                    if (found == true)
                    {
                        newClient = (Individual)clients[index];
                        newMortgageAcc = new MortgageAccount(newClient, balance, interest/100, period);
                        mortgageAcc.Add(newMortgageAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }
                    else
                    {
                        counter = 0;
                        index = -1;
                        foreach (Company company in companies)
                        {
                            if (company.Eik == ExistingClientComboBox.Text)
                            {
                                index = counter;
                                break;
                            }
                            counter++;
                        }
                        newCompany = (Company)companies[index];
                        newMortgageAcc = new MortgageAccount(newCompany, balance, interest/100, period);
                        mortgageAcc.Add(newMortgageAcc);
                        generateExistingClientsCB();
                        ClearAll();
                    }
                }
            }
        }

        private void ExistingClientRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ExistingClientRadioBtn.Checked == true)
            {
                ExistingClientComboBox.Enabled = true;
            }
            else
            {
                ExistingClientComboBox.Enabled = false;
            }
        }

        private void NewCompanyRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NewCompanyRadioBtn.Checked == true)
            {
                ShowCompaniesFields();
            }
            else
            {
                ShowIndividualsFields();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
