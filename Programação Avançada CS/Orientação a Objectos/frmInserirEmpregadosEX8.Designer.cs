namespace POOAvCS.Orientação_a_Objectos
{
    partial class frmInserirEmpregadosEX8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabInserirEmpregados = new System.Windows.Forms.TabPage();
            this.btnInserirEmpregado = new System.Windows.Forms.Button();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtDerivada = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblDerivada = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabVerEmpregados = new System.Windows.Forms.TabPage();
            this.lstVerEmpregados = new System.Windows.Forms.ListBox();
            this.tabAumentaSalario = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAumentaSalario = new System.Windows.Forms.Button();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.rdbValor = new System.Windows.Forms.RadioButton();
            this.rdbPergentagem = new System.Windows.Forms.RadioButton();
            this.lblDepois = new System.Windows.Forms.Label();
            this.lblAntes = new System.Windows.Forms.Label();
            this.lstDepois = new System.Windows.Forms.ListBox();
            this.lstAntes = new System.Windows.Forms.ListBox();
            this.tabEstatisticas = new System.Windows.Forms.TabPage();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCompara = new System.Windows.Forms.TextBox();
            this.btnCompara = new System.Windows.Forms.Button();
            this.cboEmpregado1 = new System.Windows.Forms.ComboBox();
            this.cboEmpregado2 = new System.Windows.Forms.ComboBox();
            this.lblMediaRemuneracoes = new System.Windows.Forms.Label();
            this.lblEmpregadoMelhorRemunerado = new System.Windows.Forms.Label();
            this.lblTotalEmpregados = new System.Windows.Forms.Label();
            this.TabControl1.SuspendLayout();
            this.tabInserirEmpregados.SuspendLayout();
            this.tabVerEmpregados.SuspendLayout();
            this.tabAumentaSalario.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.tabEstatisticas.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabInserirEmpregados);
            this.TabControl1.Controls.Add(this.tabVerEmpregados);
            this.TabControl1.Controls.Add(this.tabAumentaSalario);
            this.TabControl1.Controls.Add(this.tabEstatisticas);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(524, 282);
            this.TabControl1.TabIndex = 1;
            // 
            // tabInserirEmpregados
            // 
            this.tabInserirEmpregados.Controls.Add(this.btnInserirEmpregado);
            this.tabInserirEmpregados.Controls.Add(this.cboDepartamento);
            this.tabInserirEmpregados.Controls.Add(this.dtpDataNascimento);
            this.tabInserirEmpregados.Controls.Add(this.txtDerivada);
            this.tabInserirEmpregados.Controls.Add(this.txtSalario);
            this.tabInserirEmpregados.Controls.Add(this.txtNome);
            this.tabInserirEmpregados.Controls.Add(this.Label3);
            this.tabInserirEmpregados.Controls.Add(this.lblDerivada);
            this.tabInserirEmpregados.Controls.Add(this.Label4);
            this.tabInserirEmpregados.Controls.Add(this.Label2);
            this.tabInserirEmpregados.Controls.Add(this.Label1);
            this.tabInserirEmpregados.Location = new System.Drawing.Point(4, 22);
            this.tabInserirEmpregados.Name = "tabInserirEmpregados";
            this.tabInserirEmpregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabInserirEmpregados.Size = new System.Drawing.Size(516, 256);
            this.tabInserirEmpregados.TabIndex = 0;
            this.tabInserirEmpregados.Text = "Inserir Empregados";
            this.tabInserirEmpregados.UseVisualStyleBackColor = true;
            // 
            // btnInserirEmpregado
            // 
            this.btnInserirEmpregado.Location = new System.Drawing.Point(119, 208);
            this.btnInserirEmpregado.Name = "btnInserirEmpregado";
            this.btnInserirEmpregado.Size = new System.Drawing.Size(311, 35);
            this.btnInserirEmpregado.TabIndex = 4;
            this.btnInserirEmpregado.Text = "Inserir Empregado";
            this.btnInserirEmpregado.UseVisualStyleBackColor = true;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Financeiro",
            "Comercial",
            "Informática",
            "Outro"});
            this.cboDepartamento.Location = new System.Drawing.Point(196, 88);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cboDepartamento.TabIndex = 3;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(196, 49);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(234, 20);
            this.dtpDataNascimento.TabIndex = 2;
            // 
            // txtDerivada
            // 
            this.txtDerivada.Location = new System.Drawing.Point(196, 158);
            this.txtDerivada.Name = "txtDerivada";
            this.txtDerivada.Size = new System.Drawing.Size(121, 20);
            this.txtDerivada.TabIndex = 1;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(196, 126);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(121, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 20);
            this.txtNome.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(116, 91);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Departamento";
            // 
            // lblDerivada
            // 
            this.lblDerivada.AutoSize = true;
            this.lblDerivada.Location = new System.Drawing.Point(190, 161);
            this.lblDerivada.Name = "lblDerivada";
            this.lblDerivada.Size = new System.Drawing.Size(0, 13);
            this.lblDerivada.TabIndex = 0;
            this.lblDerivada.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(151, 129);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Salário";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(86, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Data de Nascimento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(155, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nome";
            // 
            // tabVerEmpregados
            // 
            this.tabVerEmpregados.Controls.Add(this.lstVerEmpregados);
            this.tabVerEmpregados.Location = new System.Drawing.Point(4, 22);
            this.tabVerEmpregados.Name = "tabVerEmpregados";
            this.tabVerEmpregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerEmpregados.Size = new System.Drawing.Size(516, 256);
            this.tabVerEmpregados.TabIndex = 1;
            this.tabVerEmpregados.Text = "Ver Empregados";
            this.tabVerEmpregados.UseVisualStyleBackColor = true;
            // 
            // lstVerEmpregados
            // 
            this.lstVerEmpregados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstVerEmpregados.FormattingEnabled = true;
            this.lstVerEmpregados.HorizontalScrollbar = true;
            this.lstVerEmpregados.Location = new System.Drawing.Point(3, 3);
            this.lstVerEmpregados.Name = "lstVerEmpregados";
            this.lstVerEmpregados.Size = new System.Drawing.Size(510, 238);
            this.lstVerEmpregados.TabIndex = 0;
            // 
            // tabAumentaSalario
            // 
            this.tabAumentaSalario.Controls.Add(this.GroupBox1);
            this.tabAumentaSalario.Controls.Add(this.lblDepois);
            this.tabAumentaSalario.Controls.Add(this.lblAntes);
            this.tabAumentaSalario.Controls.Add(this.lstDepois);
            this.tabAumentaSalario.Controls.Add(this.lstAntes);
            this.tabAumentaSalario.Location = new System.Drawing.Point(4, 22);
            this.tabAumentaSalario.Name = "tabAumentaSalario";
            this.tabAumentaSalario.Padding = new System.Windows.Forms.Padding(3);
            this.tabAumentaSalario.Size = new System.Drawing.Size(516, 256);
            this.tabAumentaSalario.TabIndex = 2;
            this.tabAumentaSalario.Text = "Aumenta Salário";
            this.tabAumentaSalario.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAumentaSalario);
            this.GroupBox1.Controls.Add(this.txtAumento);
            this.GroupBox1.Controls.Add(this.rdbValor);
            this.GroupBox1.Controls.Add(this.rdbPergentagem);
            this.GroupBox1.Location = new System.Drawing.Point(206, 7);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(106, 212);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Aumento";
            // 
            // btnAumentaSalario
            // 
            this.btnAumentaSalario.Location = new System.Drawing.Point(7, 132);
            this.btnAumentaSalario.Name = "btnAumentaSalario";
            this.btnAumentaSalario.Size = new System.Drawing.Size(93, 58);
            this.btnAumentaSalario.TabIndex = 3;
            this.btnAumentaSalario.Text = "Aumenta\r\nSalário";
            this.btnAumentaSalario.UseVisualStyleBackColor = true;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(7, 92);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(93, 20);
            this.txtAumento.TabIndex = 2;
            // 
            // rdbValor
            // 
            this.rdbValor.AutoSize = true;
            this.rdbValor.Location = new System.Drawing.Point(6, 59);
            this.rdbValor.Name = "rdbValor";
            this.rdbValor.Size = new System.Drawing.Size(49, 17);
            this.rdbValor.TabIndex = 1;
            this.rdbValor.TabStop = true;
            this.rdbValor.Text = "Valor";
            this.rdbValor.UseVisualStyleBackColor = true;
            // 
            // rdbPergentagem
            // 
            this.rdbPergentagem.AutoSize = true;
            this.rdbPergentagem.Location = new System.Drawing.Point(6, 30);
            this.rdbPergentagem.Name = "rdbPergentagem";
            this.rdbPergentagem.Size = new System.Drawing.Size(33, 17);
            this.rdbPergentagem.TabIndex = 0;
            this.rdbPergentagem.TabStop = true;
            this.rdbPergentagem.Text = "%";
            this.rdbPergentagem.UseVisualStyleBackColor = true;
            // 
            // lblDepois
            // 
            this.lblDepois.AutoSize = true;
            this.lblDepois.Location = new System.Drawing.Point(315, 226);
            this.lblDepois.Name = "lblDepois";
            this.lblDepois.Size = new System.Drawing.Size(46, 13);
            this.lblDepois.TabIndex = 2;
            this.lblDepois.Text = "(Depois)";
            // 
            // lblAntes
            // 
            this.lblAntes.AutoSize = true;
            this.lblAntes.Location = new System.Drawing.Point(9, 226);
            this.lblAntes.Name = "lblAntes";
            this.lblAntes.Size = new System.Drawing.Size(40, 13);
            this.lblAntes.TabIndex = 1;
            this.lblAntes.Text = "(Antes)";
            // 
            // lstDepois
            // 
            this.lstDepois.FormattingEnabled = true;
            this.lstDepois.Location = new System.Drawing.Point(318, 7);
            this.lstDepois.Name = "lstDepois";
            this.lstDepois.Size = new System.Drawing.Size(190, 212);
            this.lstDepois.TabIndex = 0;
            // 
            // lstAntes
            // 
            this.lstAntes.FormattingEnabled = true;
            this.lstAntes.Location = new System.Drawing.Point(9, 7);
            this.lstAntes.Name = "lstAntes";
            this.lstAntes.Size = new System.Drawing.Size(190, 212);
            this.lstAntes.TabIndex = 0;
            // 
            // tabEstatisticas
            // 
            this.tabEstatisticas.Controls.Add(this.GroupBox2);
            this.tabEstatisticas.Controls.Add(this.lblMediaRemuneracoes);
            this.tabEstatisticas.Controls.Add(this.lblEmpregadoMelhorRemunerado);
            this.tabEstatisticas.Controls.Add(this.lblTotalEmpregados);
            this.tabEstatisticas.Location = new System.Drawing.Point(4, 22);
            this.tabEstatisticas.Name = "tabEstatisticas";
            this.tabEstatisticas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstatisticas.Size = new System.Drawing.Size(516, 256);
            this.tabEstatisticas.TabIndex = 3;
            this.tabEstatisticas.Text = "Estatisticas";
            this.tabEstatisticas.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtCompara);
            this.GroupBox2.Controls.Add(this.btnCompara);
            this.GroupBox2.Controls.Add(this.cboEmpregado1);
            this.GroupBox2.Controls.Add(this.cboEmpregado2);
            this.GroupBox2.Location = new System.Drawing.Point(32, 126);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(450, 113);
            this.GroupBox2.TabIndex = 1;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Compara";
            // 
            // txtCompara
            // 
            this.txtCompara.Location = new System.Drawing.Point(232, 63);
            this.txtCompara.Name = "txtCompara";
            this.txtCompara.Size = new System.Drawing.Size(209, 20);
            this.txtCompara.TabIndex = 2;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(299, 28);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(75, 23);
            this.btnCompara.TabIndex = 1;
            this.btnCompara.Text = "Compara";
            this.btnCompara.UseVisualStyleBackColor = true;
            // 
            // cboEmpregado1
            // 
            this.cboEmpregado1.FormattingEnabled = true;
            this.cboEmpregado1.Location = new System.Drawing.Point(6, 28);
            this.cboEmpregado1.Name = "cboEmpregado1";
            this.cboEmpregado1.Size = new System.Drawing.Size(221, 21);
            this.cboEmpregado1.TabIndex = 0;
            // 
            // cboEmpregado2
            // 
            this.cboEmpregado2.FormattingEnabled = true;
            this.cboEmpregado2.Location = new System.Drawing.Point(7, 63);
            this.cboEmpregado2.Name = "cboEmpregado2";
            this.cboEmpregado2.Size = new System.Drawing.Size(221, 21);
            this.cboEmpregado2.TabIndex = 0;
            // 
            // lblMediaRemuneracoes
            // 
            this.lblMediaRemuneracoes.AutoSize = true;
            this.lblMediaRemuneracoes.Location = new System.Drawing.Point(29, 91);
            this.lblMediaRemuneracoes.Name = "lblMediaRemuneracoes";
            this.lblMediaRemuneracoes.Size = new System.Drawing.Size(132, 13);
            this.lblMediaRemuneracoes.TabIndex = 0;
            this.lblMediaRemuneracoes.Text = "(Média de Remunerações)";
            // 
            // lblEmpregadoMelhorRemunerado
            // 
            this.lblEmpregadoMelhorRemunerado.AutoSize = true;
            this.lblEmpregadoMelhorRemunerado.Location = new System.Drawing.Point(29, 60);
            this.lblEmpregadoMelhorRemunerado.Name = "lblEmpregadoMelhorRemunerado";
            this.lblEmpregadoMelhorRemunerado.Size = new System.Drawing.Size(166, 13);
            this.lblEmpregadoMelhorRemunerado.TabIndex = 0;
            this.lblEmpregadoMelhorRemunerado.Text = "(Empregado Melhor Remunerado)";
            // 
            // lblTotalEmpregados
            // 
            this.lblTotalEmpregados.AutoSize = true;
            this.lblTotalEmpregados.Location = new System.Drawing.Point(29, 29);
            this.lblTotalEmpregados.Name = "lblTotalEmpregados";
            this.lblTotalEmpregados.Size = new System.Drawing.Size(114, 13);
            this.lblTotalEmpregados.TabIndex = 0;
            this.lblTotalEmpregados.Text = "(Total de Empregados)";
            // 
            // frmInserirEmpregadosEX8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 282);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmInserirEmpregadosEX8";
            this.Text = "Inserir Empregados";
            this.TabControl1.ResumeLayout(false);
            this.tabInserirEmpregados.ResumeLayout(false);
            this.tabInserirEmpregados.PerformLayout();
            this.tabVerEmpregados.ResumeLayout(false);
            this.tabAumentaSalario.ResumeLayout(false);
            this.tabAumentaSalario.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.tabEstatisticas.ResumeLayout(false);
            this.tabEstatisticas.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl TabControl1;
        protected System.Windows.Forms.TabPage tabInserirEmpregados;
        protected System.Windows.Forms.Button btnInserirEmpregado;
        protected System.Windows.Forms.ComboBox cboDepartamento;
        protected System.Windows.Forms.DateTimePicker dtpDataNascimento;
        protected System.Windows.Forms.TextBox txtDerivada;
        protected System.Windows.Forms.TextBox txtSalario;
        protected System.Windows.Forms.TextBox txtNome;
        protected System.Windows.Forms.Label Label3;
        protected System.Windows.Forms.Label lblDerivada;
        protected System.Windows.Forms.Label Label4;
        protected System.Windows.Forms.Label Label2;
        protected System.Windows.Forms.Label Label1;
        protected System.Windows.Forms.TabPage tabVerEmpregados;
        protected System.Windows.Forms.ListBox lstVerEmpregados;
        protected System.Windows.Forms.TabPage tabAumentaSalario;
        protected System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAumentaSalario;
        internal System.Windows.Forms.TextBox txtAumento;
        internal System.Windows.Forms.RadioButton rdbValor;
        internal System.Windows.Forms.RadioButton rdbPergentagem;
        protected System.Windows.Forms.Label lblDepois;
        protected System.Windows.Forms.Label lblAntes;
        protected System.Windows.Forms.ListBox lstDepois;
        protected System.Windows.Forms.ListBox lstAntes;
        protected System.Windows.Forms.TabPage tabEstatisticas;
        protected System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtCompara;
        internal System.Windows.Forms.Button btnCompara;
        internal System.Windows.Forms.ComboBox cboEmpregado1;
        internal System.Windows.Forms.ComboBox cboEmpregado2;
        protected System.Windows.Forms.Label lblMediaRemuneracoes;
        protected System.Windows.Forms.Label lblEmpregadoMelhorRemunerado;
        protected System.Windows.Forms.Label lblTotalEmpregados;
    }
}