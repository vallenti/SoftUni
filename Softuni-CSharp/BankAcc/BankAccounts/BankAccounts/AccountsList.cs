using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountsNamespace
{
    public partial class AccountsList : Form
    {
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        ArrayList criteriaList = new ArrayList();
        public AccountsList(ref ArrayList depositAcc, ref ArrayList loanAcc, ref ArrayList mortgageAcc,ref ArrayList clients,ref ArrayList companies)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            this.loanAcc = loanAcc;
            this.mortgageAcc = mortgageAcc;
            this.clients = clients;
            this.companies = companies;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            string typeAccount = "";
            string typeClient = "";
            double sum = 0;
            try
            {
                if (textBox1.Text != "")
                {
                    sum = double.Parse(textBox1.Text);
                }     
            }
            catch (FormatException)
            {
                errorProvider1.SetError(textBox1, "Въведете число");
            }
            if (DepositRadioBtn.Checked == true)
            {
                typeAccount = "депозит";
            }
            else if (LoanRadioBtn.Checked == true)
            {
                typeAccount = "заем";
            }
            else if (MortgageRadioBtn.Checked == true)
            {
                typeAccount = "ипотека";
            }
            if (NewIndividualRadioBtn.Checked == true)
            {
                typeClient = "клиент";
            }
            else if (NewCompanyRadioBtn.Checked == true)
            {
                typeClient = "фирма";
            }
            foreach (DepositAccount depAcc in depositAcc)
            {
                if (typeAccount == depAcc.AccountType && typeClient == depAcc.ClientType && depAcc.Balance >= sum)
                {
                    criteriaList.Add(depAcc);
                }
            }
            foreach (LoanAccount loAcc in loanAcc)
            {
                if (typeAccount == loAcc.AccountType && typeClient == loAcc.ClientType && loAcc.Balance >= sum)
                {
                    criteriaList.Add(loAcc);
                }
            }
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                if (typeAccount == mortAcc.AccountType && typeClient == mortAcc.ClientType && mortAcc.Balance >= sum)
                {
                    criteriaList.Add(mortAcc);
                }
            }
            dataGridView1.DataSource = criteriaList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string clientID = textBox2.Text;
            foreach (DepositAccount depAcc in depositAcc)
            {
                if (depAcc.SomeCliendID == clientID)
                {
                    criteriaList.Add(depAcc);
                }
            }
            foreach (LoanAccount loAcc in loanAcc)
            {
                if (loAcc.SomeCliendID == clientID)
                {
                    criteriaList.Add(loAcc);
                }
            }
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                if (mortAcc.SomeCliendID == clientID)
                {
                    criteriaList.Add(mortAcc);
                }
            }
            
            dataGridView1.DataSource = criteriaList;
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            DepositRadioBtn.Checked = false;
            LoanRadioBtn.Checked = false;
            MortgageRadioBtn.Checked = false;
            NewIndividualRadioBtn.Checked = false;
            NewCompanyRadioBtn.Checked = false;
            textBox1.ResetText();
            textBox2.ResetText();
            dataGridView1.DataSource = null;
        }
    }
}
