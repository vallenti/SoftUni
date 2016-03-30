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
    public partial class DeleteAccount : Form
    {
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();
        public DeleteAccount(ref ArrayList depositAcc, ref ArrayList loanAcc, ref ArrayList mortgageAcc)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            this.loanAcc = loanAcc;
            this.mortgageAcc = mortgageAcc;
            updateIBANlist();
        }
        private void updateIBANlist()
        {
            delIbanCB.Items.Clear();
            foreach (DepositAccount depAcc in depositAcc)
            {
                delIbanCB.Items.Add(depAcc.Iban);
            }
            foreach (LoanAccount loAcc in loanAcc)
            {
                delIbanCB.Items.Add(loAcc.Iban);
            }
            foreach (MortgageAccount mortAcc in mortgageAcc)
            {
                delIbanCB.Items.Add(mortAcc.Iban);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //TODO erase bankaccount from collection
            string iban = delIbanCB.Text;
            int index = -1;
            int counter = 0;
            bool found = false;
            foreach (DepositAccount depAcc in depositAcc)
            {
                if (depAcc.Iban == iban)
                {
                    index = counter;
                    found = true;
                    break;
                }
                counter++;
            }
            if (found == true)
            {
                depositAcc.RemoveAt(index);
                updateIBANlist();
            }
            else
            {
                index = -1;
                counter = 0;
                foreach (LoanAccount loAcc in loanAcc)
                {
                    if (loAcc.Iban == iban)
                    {
                        index = counter;
                        found = true;
                        break;
                    }
                    counter++;
                }
                if (found == true)
                {
                    //erase acc from loan array
                    loanAcc.RemoveAt(index);
                    updateIBANlist();

                }
                else
                {
                    index = -1;
                    counter = 0;
                    foreach (MortgageAccount mortgAcc in mortgageAcc)
                    {
                        if (mortgAcc.Iban == iban)
                        {
                            index = counter;
                            found = true;
                            break;
                        }
                        counter++;
                    }
                    if (found == true)
                    {
                        //erase acc from mortgage acc
                        mortgageAcc.RemoveAt(index);
                        updateIBANlist();

                    }
                    else
                    {
                        MessageBox.Show(String.Format("Не съществува сметка с IBAN: {0}", iban));
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
