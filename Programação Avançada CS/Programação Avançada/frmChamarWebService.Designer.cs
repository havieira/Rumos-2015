namespace POOAvCS.Programação_Avançada
{
    partial class frmChamarWebService
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
            this.txtDiscurso = new System.Windows.Forms.TextBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.cboFrases = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDiscurso
            // 
            this.txtDiscurso.Location = new System.Drawing.Point(12, 41);
            this.txtDiscurso.Multiline = true;
            this.txtDiscurso.Name = "txtDiscurso";
            this.txtDiscurso.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDiscurso.Size = new System.Drawing.Size(446, 265);
            this.txtDiscurso.TabIndex = 7;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(315, 12);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(62, 23);
            this.btnVer.TabIndex = 6;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // cboFrases
            // 
            this.cboFrases.FormattingEnabled = true;
            this.cboFrases.Items.AddRange(new object[] {
            "To be, or not to be ",
            " My kingdom for a horse ",
            " Get thee to a nunnery ",
            " There are more things in heaven and earth ",
            " I will wear my heart upon my sleeve ",
            " When beggars die, there are no comets seen ",
            " Lord, what fools these mortals be ",
            " Et tu, Brute ",
            " Sound and fury ",
            " Friends, romans, countrymen ",
            " Something wicked this way comes ",
            " To sleep: perchance to dream ",
            " Green-eyed monster ",
            " This was the noblest Roman of them all ",
            " Oft expectation fails and most oft there Where most it promises ",
            " Eye of newt and toe of frog ",
            " Frailty, thy name is woman ",
            " What light through yonder window breaks ",
            " Think you I am no stronger than my sex ",
            " Cowards die many times before their deaths ",
            " How poor are they that have not patience ",
            " Quality of mercy ",
            " My words fly up, my thoughts remain below ",
            " Bell, book, and candle ",
            " Something is rotten in the state of Denmark ",
            " Beware the ides of March ",
            " A stage where every man must play a part ",
            " Though this be madness, yet there is method in \'t ",
            " Is this a dagger which I see before me ",
            " Now go we in content To liberty and not to banishment ",
            " Band of brothers ",
            " Alas, poor Yorick! I knew him ",
            " The world\'s mine oyster ",
            " Nothing will come of nothing ",
            " That man that hath a tongue ",
            " All the world\'s a stage ",
            " The course of true love never did run smooth ",
            " Love looks not with the eyes, but with the mind ",
            " Let every eye negotiate for itself ",
            " Kiss me, Kate ",
            " The play \'s the thing ",
            " I am constant as the northern star ",
            " The man that hath no music in himself ",
            " We are such stuff As dreams are made on ",
            " This was the most unkindest cut of all ",
            " Journeys end in lovers meeting ",
            " Yond Cassius has a lean and hungry look ",
            " My only love sprung from my only hate ",
            " I am fortune\'s fool ",
            " Loved not wisely but too well ",
            " O coward conscience, how dost thou afflict me ",
            " When shall we three meet again ",
            " A plague o\' both your houses ",
            " Out, damned spot ",
            " To-morrow, and to-morrow, and to-morrow ",
            " Our remedies oft in ourselves do lie ",
            " Not that I loved Caesar less ",
            " Winter of our discontent ",
            " Parting is such sweet sorrow ",
            " O Romeo, Romeo! wherefore art thou Romeo ",
            " The lady protests too much, methinks ",
            " What a piece of work is a man ",
            " The fault, dear Brutus, is not in our stars ",
            " All that glitters is not gold ",
            " What\'s in a name ",
            " Thus with a kiss I die"});
            this.cboFrases.Location = new System.Drawing.Point(12, 14);
            this.cboFrases.Name = "cboFrases";
            this.cboFrases.Size = new System.Drawing.Size(297, 21);
            this.cboFrases.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(383, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmChamarWebService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 318);
            this.Controls.Add(this.txtDiscurso);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.cboFrases);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmChamarWebService";
            this.Text = "Chamar WebService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtDiscurso;
        internal System.Windows.Forms.Button btnVer;
        internal System.Windows.Forms.ComboBox cboFrases;
        internal System.Windows.Forms.Button btnCancelar;
    }
}