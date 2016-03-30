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
    public partial class EditClient : Form
    {
        ArrayList clients = new ArrayList();
        public EditClient(ref ArrayList clients)
        {
            InitializeComponent();
            this.clients = clients;
            individualBindingSource.DataSource = clients;
        }
    }
}
