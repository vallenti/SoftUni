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
    public partial class Query : Form
    {
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        public Query(ref ArrayList depositAcc, ref ArrayList loanAcc, ref ArrayList mortgageAcc,ref ArrayList clients,ref ArrayList companies)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            this.loanAcc = loanAcc;
            this.mortgageAcc = mortgageAcc;
            this.clients = clients;
            this.companies = companies;
        }

        private void Query_Load(object sender, EventArgs e)
        {
            long depAccSum = 0;
            long loAccSum = 0;
            long mortAccSum = 0;
            label10.Text = String.Format(depositAcc.Count.ToString());
            label11.Text = String.Format(loanAcc.Count.ToString());
            label12.Text = String.Format(mortgageAcc.Count.ToString());

            foreach (DepositAccount depAcc in depositAcc)
            {
                depAccSum += (long)depAcc.Balance;
            }
            label13.Text = depAccSum.ToString();
            foreach (LoanAccount loAcc in loanAcc)
            {
                loAccSum += (long)loAcc.Balance;
            }
            label14.Text = loAccSum.ToString();
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                mortAccSum += (long)mortAcc.Balance;
            }
            label15.Text = mortAccSum.ToString();
            label16.Text = (loAccSum + mortAccSum).ToString();
            label17.Text = String.Format(clients.Count.ToString());
            label18.Text = String.Format(companies.Count.ToString());

        }
    }
}
