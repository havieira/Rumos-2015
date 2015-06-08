using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POOAvCS.Programação_Avançada
{
    public partial class frmBemVindo : Form
    {
        public frmBemVindo()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmPrincipal fPrincipal = new frmPrincipal();
            fPrincipal.Show();
            this.Hide();
        }
    }
}