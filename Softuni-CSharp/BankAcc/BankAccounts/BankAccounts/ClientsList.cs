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
    public partial class ClientsList : Form
    {
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        public ClientsList(ArrayList clients, ArrayList companies)
        {
           InitializeComponent();
           this.clients = clients;
           this.companies = companies;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewIndividualRadioBtn.Checked == true)
            {
                listofComapniesDGV.Visible = false;
                listOfClientsDGV.Visible = true;
                listOfClientsDGV.DataSource = null;
                listOfClientsDGV.DataSource = clients;
            }
            else
            {
                listofComapniesDGV.Visible = true;
                listOfClientsDGV.Visible = false;
                listofComapniesDGV.DataSource = null;
                listofComapniesDGV.DataSource = companies;
            }

        }
    }
}
