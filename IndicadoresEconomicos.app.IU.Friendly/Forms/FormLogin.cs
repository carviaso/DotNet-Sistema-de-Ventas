using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndicadoresEconomicos.app.IU.Friendly.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text == string.Empty)
            {
                errorProvider.SetError(txtuser, "No puede estar vacio.");
            }
            else if (txtpass.Text == string.Empty)
            {
                errorProvider.SetError(txtpass, "No puede estar vacio.");
            }
            else
            {
                MessageBox.Show("Bienvenido.");
            }
        }
    }
}
