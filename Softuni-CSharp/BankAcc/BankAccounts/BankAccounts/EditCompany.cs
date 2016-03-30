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
    public partial class EditCompany : Form
    {
        ArrayList companies = new ArrayList();
        public EditCompany(ref ArrayList companies)
        {
            InitializeComponent();
            this.companies = companies;
            companyBindingSource.DataSource = companies;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
