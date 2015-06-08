namespace POOAvCS.Programação_Avançada
{
    partial class frmCriarReport
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreVisualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFormatarLetra = new System.Windows.Forms.Button();
            this.btnFormatarPagina = new System.Windows.Forms.Button();
            this.btnFicheiroImprimir = new System.Windows.Forms.Button();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnPreVisualizar);
            this.GroupBox2.Controls.Add(this.btnImprimir);
            this.GroupBox2.Location = new System.Drawing.Point(353, 19);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(167, 144);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Imprimir";
            // 
            // btnPreVisualizar
            // 
            this.btnPreVisualizar.Location = new System.Drawing.Point(42, 31);
            this.btnPreVisualizar.Name = "btnPreVisualizar";
            this.btnPreVisualizar.Size = new System.Drawing.Size(96, 32);
            this.btnPreVisualizar.TabIndex = 3;
            this.btnPreVisualizar.Text = "Pré Visualizar";
            this.btnPreVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(42, 82);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(96, 32);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnFormatarLetra);
            this.GroupBox1.Controls.Add(this.btnFormatarPagina);
            this.GroupBox1.Location = new System.Drawing.Point(174, 19);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(162, 144);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Formatar";
            // 
            // btnFormatarLetra
            // 
            this.btnFormatarLetra.Location = new System.Drawing.Point(31, 82);
            this.btnFormatarLetra.Name = "btnFormatarLetra";
            this.btnFormatarLetra.Size = new System.Drawing.Size(96, 32);
            this.btnFormatarLetra.TabIndex = 3;
            this.btnFormatarLetra.Text = "Formatar Letra";
            this.btnFormatarLetra.UseVisualStyleBackColor = true;
            // 
            // btnFormatarPagina
            // 
            this.btnFormatarPagina.Location = new System.Drawing.Point(31, 31);
            this.btnFormatarPagina.Name = "btnFormatarPagina";
            this.btnFormatarPagina.Size = new System.Drawing.Size(96, 32);
            this.btnFormatarPagina.TabIndex = 3;
            this.btnFormatarPagina.Text = "Formatar Página";
            this.btnFormatarPagina.UseVisualStyleBackColor = true;
            // 
            // btnFicheiroImprimir
            // 
            this.btnFicheiroImprimir.Location = new System.Drawing.Point(32, 19);
            this.btnFicheiroImprimir.Name = "btnFicheiroImprimir";
            this.btnFicheiroImprimir.Size = new System.Drawing.Size(126, 32);
            this.btnFicheiroImprimir.TabIndex = 6;
            this.btnFicheiroImprimir.Text = "Ficheiro a Imprimir";
            this.btnFicheiroImprimir.UseVisualStyleBackColor = true;
            // 
            // frmCriarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 183);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnFicheiroImprimir);
            this.Name = "frmCriarReport";
            this.Text = "Criar Report";
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnPreVisualizar;
        internal System.Windows.Forms.Button btnImprimir;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnFormatarLetra;
        internal System.Windows.Forms.Button btnFormatarPagina;
        internal System.Windows.Forms.Button btnFicheiroImprimir;
    }
}