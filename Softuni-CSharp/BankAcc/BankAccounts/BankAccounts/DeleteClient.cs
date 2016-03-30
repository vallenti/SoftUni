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
    public partial class DeleteClient : Form
    {
        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();
        public DeleteClient(ref ArrayList clients, ref ArrayList companies)
        {
            InitializeComponent();
            this.clients = clients;
            this.companies = companies;
            UpdateData();
        }
        private void UpdateData()
        {
            egnCB.Items.Clear();
            eikCB.Items.Clear();
            egnCB.ResetText();
            eikCB.ResetText();
            foreach (Individual person in clients)
            {
                egnCB.Items.Add(person.Egn);
            }
            foreach (Company firm in companies)
            {
                eikCB.Items.Add(firm.Eik);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewIndividualRadioBtn.Checked == true)
            {
                string egn = egnCB.Text;
                int index = -1;
                int counter = 0;
                foreach (Individual client in clients)
                {
                    if (client.Egn == egn)
                    {
                        index = counter;
                        break;
                    }
                    counter++;
                }
                if (index >= 0)
                {
                    clients.RemoveAt(index);
                    UpdateData();
                }
                else
                {
                    MessageBox.Show(String.Format("Не съществува клиент със ЕГН: {0}",egn));
                }
            }
            else
            {
                string eik = eikCB.Text;
                int index = -1;
                int counter = 0;
                foreach (Company company in companies)
                {
                    if (company.Eik == eik)
                    {
                        index = counter;
                        break;
                    }
                    counter++;
                }
                if (index >= 0)
                {
                    companies.RemoveAt(index);
                    UpdateData();
                }
                else
                {
                    MessageBox.Show(String.Format("Не съществува фирма с ЕИК: {0}", eik));
                }
            }
        }

        private void NewIndividualRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (NewIndividualRadioBtn.Checked)
            {
                egnCB.Enabled = true;
                eikCB.Enabled = false;
            }
            else
            {
                egnCB.Enabled = false;
                eikCB.Enabled = true;
            }
        }
    }
}
