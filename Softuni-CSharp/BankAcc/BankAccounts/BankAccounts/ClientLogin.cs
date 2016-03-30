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
    public partial class ClientLogin : Form
    {
        ArrayList depositAcc = new ArrayList();
        ArrayList loanAcc = new ArrayList();
        ArrayList mortgageAcc = new ArrayList();
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        string userName, password;
        public ClientLogin(string userName, string password, ref ArrayList depositAcc, ref ArrayList loanAcc, ref ArrayList mortgageAcc)
        {
            InitializeComponent();
            this.depositAcc = depositAcc;
            this.loanAcc = loanAcc;
            this.mortgageAcc = mortgageAcc;
            this.userName = userName;
            this.password = password;
        }

        private void ClientLogin_Load(object sender, EventArgs e)
        {
            foreach (DepositAccount depAcc in depositAcc)
            {
                if (depAcc.SomeCliendID == userName)
                {
                    textBox1.Text = depAcc.Iban;
                    textBox2.Text = depAcc.ClientName;
                    textBox3.Text = depAcc.SomeCliendID;
                    textBox4.Text = depAcc.Balance.ToString();
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
