using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSAvancadoClasses;

namespace POOAvCS.Orientação_a_Objectos
{
    public partial class frmInserirEmpregadosEX4 : Form
    {
        public frmInserirEmpregadosEX4()
        {
            InitializeComponent();
        }

        List<Empregado> listaEmp = new List<Empregado>();

        private void btnInserirEmpregado_Click(object sender, EventArgs e)
        {
            Empregado empregadoAdd = new Empregado();

            empregadoAdd.Nome = txtNome.Text;
            empregadoAdd.DataNascimento = dtpDataNascimento.Value.Date;
            empregadoAdd.Departamento = cboDepartamento.ToString();
            empregadoAdd.Salario = Convert.ToDecimal(txtSalario.Text);

            listaEmp.Add(empregadoAdd);
            txtNome.Select();
        }

        private void TabControl1_Click(object sender, EventArgs e)
        {
            foreach (Empregado dados in listaEmp)
            {
                lstVerEmpregados.Items.Add(dados.imprimeDados());
            }
        }



    }
}