namespace POOAvCS.Orientação_a_Objectos
{
    partial class frmInserirEmpregadosEX2
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabVerEmpregados = new System.Windows.Forms.TabPage();
            this.lstVerEmpregados = new System.Windows.Forms.ListBox();
            this.TabControl1.SuspendLayout();
            this.tabInserirEmpregados.SuspendLayout();
            this.tabVerEmpregados.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabInserirEmpregados);
            this.TabControl1.Controls.Add(this.tabVerEmpregados);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(431, 278);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabInserirEmpregados
            // 
            this.tabInserirEmpregados.Controls.Add(this.btnInserirEmpregado);
            this.tabInserirEmpregados.Controls.Add(this.cboDepartamento);
            this.tabInserirEmpregados.Controls.Add(this.dtpDataNascimento);
            this.tabInserirEmpregados.Controls.Add(this.txtSalario);
            this.tabInserirEmpregados.Controls.Add(this.txtNome);
            this.tabInserirEmpregados.Controls.Add(this.Label3);
            this.tabInserirEmpregados.Controls.Add(this.Label4);
            this.tabInserirEmpregados.Controls.Add(this.Label2);
            this.tabInserirEmpregados.Controls.Add(this.Label1);
            this.tabInserirEmpregados.Location = new System.Drawing.Point(4, 22);
            this.tabInserirEmpregados.Name = "tabInserirEmpregados";
            this.tabInserirEmpregados.Padding = new System.Windows.Forms.Padding(3);
            this.tabInserirEmpregados.Size = new System.Drawing.Size(423, 252);
            this.tabInserirEmpregados.TabIndex = 0;
            this.tabInserirEmpregados.Text = "Inserir Empregados";
            this.tabInserirEmpregados.UseVisualStyleBackColor = true;
            // 
            // btnInserirEmpregado
            // 
            this.btnInserirEmpregado.Location = new System.Drawing.Point(59, 185);
            this.btnInserirEmpregado.Name = "btnInserirEmpregado";
            this.btnInserirEmpregado.Size = new System.Drawing.Size(311, 35);
            this.btnInserirEmpregado.TabIndex = 4;
            this.btnInserirEmpregado.Text = "Inserir Empregado";
            this.btnInserirEmpregado.UseVisualStyleBackColor = true;
            this.btnInserirEmpregado.Click += new System.EventHandler(this.btnInserirEmpregado_Click);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Financeiro",
            "Comercial",
            "Informática",
            "Outro"});
            this.cboDepartamento.Location = new System.Drawing.Point(136, 88);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(121, 21);
            this.cboDepartamento.TabIndex = 3;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(136, 49);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(234, 20);
            this.dtpDataNascimento.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(136, 126);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(121, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 14);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(234, 20);
            this.txtNome.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(56, 91);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(74, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Departamento";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(91, 129);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Salário";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(26, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(104, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Data de Nascimento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(95, 17);
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
            this.tabVerEmpregados.Size = new System.Drawing.Size(423, 252);
            this.tabVerEmpregados.TabIndex = 1;
            this.tabVerEmpregados.Text = "Ver Empregados";
            this.tabVerEmpregados.UseVisualStyleBackColor = true;
            // 
            // lstVerEmpregados
            // 
            this.lstVerEmpregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVerEmpregados.FormattingEnabled = true;
            this.lstVerEmpregados.HorizontalScrollbar = true;
            this.lstVerEmpregados.Location = new System.Drawing.Point(3, 3);
            this.lstVerEmpregados.Name = "lstVerEmpregados";
            this.lstVerEmpregados.Size = new System.Drawing.Size(417, 246);
            this.lstVerEmpregados.TabIndex = 0;
            // 
            // frmInserirEmpregadosEX2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 278);
            this.Controls.Add(this.TabControl1);
            this.Name = "frmInserirEmpregadosEX2";
            this.Text = "Inserir Empregados";
            this.TabControl1.ResumeLayout(false);
            this.tabInserirEmpregados.ResumeLayout(false);
            this.tabInserirEmpregados.PerformLayout();
            this.tabVerEmpregados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tabInserirEmpregados;
        internal System.Windows.Forms.Button btnInserirEmpregado;
        internal System.Windows.Forms.ComboBox cboDepartamento;
        internal System.Windows.Forms.DateTimePicker dtpDataNascimento;
        internal System.Windows.Forms.TextBox txtSalario;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage tabVerEmpregados;
        internal System.Windows.Forms.ListBox lstVerEmpregados;
    }
}