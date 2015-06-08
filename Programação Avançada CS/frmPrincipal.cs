using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using POOAvCS.Orientação_a_Objectos;
using POOAvCS.Programação_Avançada;

namespace POOAvCS
{
    public partial class frmPrincipal : Form
    {
        frmInserirEmpregadosEX2 fInserirEmpregadoEX2;
        frmInserirEmpregadosEX4 fInserirEmpregadoEX4;
        frmInserirEmpregadosEX6 fInserirEmpregadoEX6;
        frmInserirEmpregadosEX8 fInserirEmpregadoEX8;
        frmInserirEmpregadosEX10 fInserirEmpregadoEX10;
        frmInserirEmpregadosEX12 fInserirEmpregadoEX12;
        frmTesteMinhaCaixaTexto fTesteMinhaCaixaTexto;
        frmTesteRelogio fTesteRelogio;
        frmCarregarBitmap fCarregaBitmap;
        frmChamarWebService fChamarWebService;
        frmCriarReport fCriarReport;
        frmDesenharGrafico fDesenharGrafico;
        frmDragDrop fDragDrop;
        frmLocalizarAplicacao fLocalizarAplicacao;
        frmSomaNumeros fSomaNumeros;


        public frmPrincipal()
        {
            InitializeComponent();

            fInserirEmpregadoEX2 = new frmInserirEmpregadosEX2();
            fInserirEmpregadoEX4 = new frmInserirEmpregadosEX4();
            fInserirEmpregadoEX6 = new frmInserirEmpregadosEX6();
            fInserirEmpregadoEX8 = new frmInserirEmpregadosEX8();
            fInserirEmpregadoEX10 = new frmInserirEmpregadosEX10();
            fInserirEmpregadoEX12 = new frmInserirEmpregadosEX12();
            fTesteMinhaCaixaTexto = new frmTesteMinhaCaixaTexto();
            fTesteRelogio = new frmTesteRelogio();
            fCarregaBitmap = new frmCarregarBitmap();
            fChamarWebService = new frmChamarWebService();
            fCriarReport = new frmCriarReport();
            fDesenharGrafico = new frmDesenharGrafico();
            fDragDrop = new frmDragDrop();
            fLocalizarAplicacao = new frmLocalizarAplicacao();
            fSomaNumeros = new frmSomaNumeros();

        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuInserirEmpregadoEX2_Click(object sender, EventArgs e)
        {
            ActivaForm(fInserirEmpregadoEX2);
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuInserirEmpregadoEX4_Click(object sender, EventArgs e)
        {
            ActivaForm(fInserirEmpregadoEX4);
        }

        private void ActivaForm(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void mnuInserirEmpregadoEX6_Click(object sender, EventArgs e)
        {
            ActivaForm(fInserirEmpregadoEX6);
        }

        private void mnuInserirEmpregadoEX8_Click(object sender, EventArgs e)
        {
            ActivaForm(fInserirEmpregadoEX8);
        }

        private void mnuInserirEmpregadoEX10_Click(object sender, EventArgs e)
        {
            ActivaForm(fInserirEmpregadoEX10);
        }

        private void mnuInserirEmpregadoEX12_Click(object sender, EventArgs e)
        {
            ActivaForm(fInserirEmpregadoEX12);
        }

        private void mnuTesteÀMinhaCaixaTexto_Click(object sender, EventArgs e)
        {
            ActivaForm(fTesteMinhaCaixaTexto);
        }

        private void mnuTesteRelógio_Click(object sender, EventArgs e)
        {
            ActivaForm(fTesteRelogio);
        }

        private void mnuCarregarBitmap_Click(object sender, EventArgs e)
        {
            ActivaForm(fCarregaBitmap);
        }

        private void mnuSomarNumeros_Click(object sender, EventArgs e)
        {
            ActivaForm(fSomaNumeros);
        }

        private void mnuChamarWebService_Click(object sender, EventArgs e)
        {
            ActivaForm(fChamarWebService);
        }

        private void mnuDesenharGrafico_Click(object sender, EventArgs e)
        {
            ActivaForm(fDesenharGrafico);
        }

        private void mnuCriarReport_Click(object sender, EventArgs e)
        {
            ActivaForm(fCriarReport);
        }

        private void mnuLocalizarAplicação_Click(object sender, EventArgs e)
        {
            ActivaForm(fLocalizarAplicacao);
        }

        private void mnuDragDrop_Click(object sender, EventArgs e)
        {
            ActivaForm(fDragDrop);
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCascata_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

    }
}