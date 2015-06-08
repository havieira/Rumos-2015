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
    public partial class frmInserirEmpregadosEX2 : Form
    {
        public frmInserirEmpregadosEX2()
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

            //foreach (string data in empregadoAdd)
                //listaEmp.Add(data);
        }


        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Empregado dados in listaEmp)
            {
                lstVerEmpregados.Items.Add(dados.imprimeDados());
            }
        }

    }
}