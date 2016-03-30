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
    public partial class DrowFromAccount : Form
    {
        ArrayList depositAcc = new ArrayList();
        public DrowFromAccount(ref ArrayList depositAcc)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            foreach (DepositAccount depAcc in depositAcc)
            {
                ibanCB.Items.Add(depAcc.Iban);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string iban = ibanCB.Text;
            try
            {
                double money = double.Parse(balanceTB.Text);
                foreach (DepositAccount depAcc in depositAcc)
                {
                    if (depAcc.Iban == iban)
                    {
                        try
                        {
                            depAcc.Drow(money);
                        }
                        catch (Exception)
                        {
                            string message = String.Format("Желаната сума за теглене е по-голяма от наличната сума в сметката.\nОт сметката ще бъдат изтеглени останалите {0} лв.", depAcc.Balance);
                            MessageBox.Show(message, "Съобщение");
                            depAcc.Drow(depAcc.Balance);
                        }
                        break;
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
