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
    public partial class DepositInAccount : Form
    {
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();

        public DepositInAccount(ArrayList depositAcc, ArrayList loanAcc, ArrayList mortgageAcc)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            this.loanAcc = loanAcc;
            this.mortgageAcc = mortgageAcc;
            foreach (DepositAccount depAcc in depositAcc)
            {
                ibanCB.Items.Add(depAcc.Iban);
            }
            foreach (LoanAccount loAcc in loanAcc)
            {
                ibanCB.Items.Add(loAcc.Iban);
            }
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                ibanCB.Items.Add(mortAcc.Iban);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iban = ibanCB.Text;
            try
            {
                double money = double.Parse(balanceTB.Text);
                bool found = false;
                foreach (DepositAccount depAcc in depositAcc)
                {
                    if (depAcc.Iban == iban)
                    {
                        depAcc.Deposit(money);
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    foreach (LoanAccount loAcc in loanAcc)
                    {
                        if (loAcc.Iban == iban)
                        {
                            loAcc.Deposit(money);
                            found = true;
                            break;
                        }
                    }
                }
                if (found == false)
                {
                    foreach (MortgageAccount mortAcc in mortgageAcc)
                    {
                        if (mortAcc.Iban == iban)
                        {
                            mortAcc.Deposit(money);
                            break;
                        }
                    }
                }
                ibanCB.ResetText();
                balanceTB.ResetText();
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля въведете сума", "Грешни данни");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
