namespace POOAvCS.Programação_Avançada
{
    partial class frmCarregarBitmap
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
            this.stsImagem = new System.Windows.Forms.StatusStrip();
            this.lblImagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCarregaImagem = new System.Windows.Forms.Button();
            this.pbxImagem = new System.Windows.Forms.PictureBox();
            this.stsImagem.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // stsImagem
            // 
            this.stsImagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImagem});
            this.stsImagem.Location = new System.Drawing.Point(0, 318);
            this.stsImagem.Name = "stsImagem";
            this.stsImagem.Size = new System.Drawing.Size(550, 22);
            this.stsImagem.TabIndex = 2;
            this.stsImagem.Text = "StatusStrip1";
            // 
            // lblImagem
            // 
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(116, 17);
            this.lblImagem.Text = "(Imagem a Carregar)";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.btnCancelar);
            this.SplitContainer1.Panel1.Controls.Add(this.btnCarregaImagem);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.pbxImagem);
            this.SplitContainer1.Size = new System.Drawing.Size(550, 318);
            this.SplitContainer1.SplitterDistance = 183;
            this.SplitContainer1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(33, 53);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCarregaImagem
            // 
            this.btnCarregaImagem.Location = new System.Drawing.Point(33, 24);
            this.btnCarregaImagem.Name = "btnCarregaImagem";
            this.btnCarregaImagem.Size = new System.Drawing.Size(117, 23);
            this.btnCarregaImagem.TabIndex = 0;
            this.btnCarregaImagem.Text = "Carrega Imagem";
            this.btnCarregaImagem.UseVisualStyleBackColor = true;
            // 
            // pbxImagem
            // 
            this.pbxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pbxImagem.Name = "pbxImagem";
            this.pbxImagem.Size = new System.Drawing.Size(363, 318);
            this.pbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagem.TabIndex = 0;
            this.pbxImagem.TabStop = false;
            // 
            // frmCarregarBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 340);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.stsImagem);
            this.Name = "frmCarregarBitmap";
            this.Text = "Carregar Bitmap";
            this.stsImagem.ResumeLayout(false);
            this.stsImagem.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.StatusStrip stsImagem;
        internal System.Windows.Forms.ToolStripStatusLabel lblImagem;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnCarregaImagem;
        internal System.Windows.Forms.PictureBox pbxImagem;
    }
}