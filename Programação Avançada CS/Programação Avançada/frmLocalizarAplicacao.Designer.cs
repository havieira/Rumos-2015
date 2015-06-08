namespace POOAvCS.Programação_Avançada
{
    partial class frmLocalizarAplicacao
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
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPT = new System.Windows.Forms.ToolStripButton();
            this.btnUK = new System.Windows.Forms.ToolStripButton();
            this.btnFR = new System.Windows.Forms.ToolStripButton();
            this.btnOlaMundo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPT,
            this.btnUK,
            this.btnFR});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(221, 25);
            this.ToolStrip1.TabIndex = 4;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btnPT
            // 
            this.btnPT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPT.Image = global::POOAvCS.Properties.Resources.ptflag;
            this.btnPT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPT.Name = "btnPT";
            this.btnPT.Size = new System.Drawing.Size(23, 22);
            this.btnPT.Text = "ToolStripButton1";
            // 
            // btnUK
            // 
            this.btnUK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUK.Image = global::POOAvCS.Properties.Resources.ukflag;
            this.btnUK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUK.Name = "btnUK";
            this.btnUK.Size = new System.Drawing.Size(23, 22);
            this.btnUK.Text = "ToolStripButton2";
            // 
            // btnFR
            // 
            this.btnFR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFR.Image = global::POOAvCS.Properties.Resources.frflag;
            this.btnFR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFR.Name = "btnFR";
            this.btnFR.Size = new System.Drawing.Size(23, 22);
            this.btnFR.Text = "ToolStripButton3";
            // 
            // btnOlaMundo
            // 
            this.btnOlaMundo.Location = new System.Drawing.Point(113, 32);
            this.btnOlaMundo.Name = "btnOlaMundo";
            this.btnOlaMundo.Size = new System.Drawing.Size(75, 23);
            this.btnOlaMundo.TabIndex = 8;
            this.btnOlaMundo.Text = "Olá Mundo!!";
            this.btnOlaMundo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(113, 61);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnTerminar
            // 
            this.btnTerminar.Location = new System.Drawing.Point(32, 61);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 6;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(32, 32);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // frmLocalizarAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 117);
            this.Controls.Add(this.btnOlaMundo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "frmLocalizarAplicacao";
            this.Text = "frmLocalizarAplicacao";
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btnPT;
        internal System.Windows.Forms.ToolStripButton btnUK;
        internal System.Windows.Forms.ToolStripButton btnFR;
        internal System.Windows.Forms.Button btnOlaMundo;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnTerminar;
        internal System.Windows.Forms.Button btnIniciar;
    }
}