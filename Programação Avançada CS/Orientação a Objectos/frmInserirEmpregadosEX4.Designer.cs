namespace POOAvCS.Orientação_a_Objectos
{
    partial class frmInserirEmpregadosEX4
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
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(575, 342);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.Click += new System.EventHandler(this.TabControl1_Click);
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
            this.tabInserirEmpregados.Location = new System.Drawing.Point(4, 25);
            this.tabInserirEmpregados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInserirEmpregados.Name = "tabInserirEmpregados";
            this.tabInserirEmpregados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabInserirEmpregados.Size = new System.Drawing.Size(567, 313);
            this.tabInserirEmpregados.TabIndex = 0;
            this.tabInserirEmpregados.Text = "Inserir Empregados";
            this.tabInserirEmpregados.UseVisualStyleBackColor = true;
            // 
            // btnInserirEmpregado
            // 
            this.btnInserirEmpregado.Location = new System.Drawing.Point(79, 228);
            this.btnInserirEmpregado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserirEmpregado.Name = "btnInserirEmpregado";
            this.btnInserirEmpregado.Size = new System.Drawing.Size(415, 43);
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
            this.cboDepartamento.Location = new System.Drawing.Point(181, 108);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(160, 24);
            this.cboDepartamento.TabIndex = 3;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(181, 60);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(311, 22);
            this.dtpDataNascimento.TabIndex = 2;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(181, 155);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(160, 22);
            this.txtSalario.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(181, 17);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 22);
            this.txtNome.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(75, 112);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 17);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Departamento";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(121, 159);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 17);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Salário";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(35, 68);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 17);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Data de Nascimento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(127, 21);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nome";
            // 
            // tabVerEmpregados
            // 
            this.tabVerEmpregados.Controls.Add(this.lstVerEmpregados);
            this.tabVerEmpregados.Location = new System.Drawing.Point(4, 25);
            this.tabVerEmpregados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabVerEmpregados.Name = "tabVerEmpregados";
            this.tabVerEmpregados.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabVerEmpregados.Size = new System.Drawing.Size(567, 313);
            this.tabVerEmpregados.TabIndex = 1;
            this.tabVerEmpregados.Text = "Ver Empregados";
            this.tabVerEmpregados.UseVisualStyleBackColor = true;
            // 
            // lstVerEmpregados
            // 
            this.lstVerEmpregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVerEmpregados.FormattingEnabled = true;
            this.lstVerEmpregados.HorizontalScrollbar = true;
            this.lstVerEmpregados.ItemHeight = 16;
            this.lstVerEmpregados.Location = new System.Drawing.Point(4, 4);
            this.lstVerEmpregados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstVerEmpregados.Name = "lstVerEmpregados";
            this.lstVerEmpregados.Size = new System.Drawing.Size(559, 305);
            this.lstVerEmpregados.TabIndex = 0;
            // 
            // frmInserirEmpregadosEX4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 342);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInserirEmpregadosEX4";
            this.Text = "Inserir Empregados";
            this.TabControl1.ResumeLayout(false);
            this.tabInserirEmpregados.ResumeLayout(false);
            this.tabInserirEmpregados.PerformLayout();
            this.tabVerEmpregados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
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