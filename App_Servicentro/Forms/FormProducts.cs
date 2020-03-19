using DA_Servicentro.DBContects;
using DA_Servicentro.EntityTypes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Servicentro.Forms
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }
        private Database_BikestoreContext contexto;

        private void FormProducts_Load(object sender, EventArgs e)
        {          
            using (var context = new Database_BikestoreContext())
            {
                var product = (from p in context.Products select p).ToList();
                dataGridView1.DataSource = product;
            }
        }
    }
}
