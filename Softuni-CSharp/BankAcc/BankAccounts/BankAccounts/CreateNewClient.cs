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
    public partial class CreateNewClient : Form
    {

        ArrayList clients = new ArrayList();
        ArrayList companies = new ArrayList();

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
        public CreateNewClient(ref ArrayList clients, ref ArrayList companies)
        {
            InitializeComponent();
            this.clients = clients;
            this.companies = companies;
            sexComboBox.Items.Add("мъж");
            sexComboBox.Items.Add("жена");
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
            //TODO create new client
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
                    Individual newClient = new Individual(firstName, lastName, egn, age, sex);
                    clients.Add(newClient);
                    firstNameTB.ResetText();
                    lastNameTB.ResetText();
                    egnTB.ResetText();
                    ageTB.ResetText();
                    sexComboBox.ResetText();
                }
                catch (FormatException)
                {
                    errorProvider1.SetError(ageTB, "Моля въведете число.");
                }
            }
            else
            {
                //create company
                string name = companyNameTB.Text;
                string eik = eikTB.Text;
                companies.Add(new Company(name, eik));
                companyNameTB.ResetText();
                eikTB.ResetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
