namespace POOAvCS.Programação_Avançada
{
    partial class frmDragDrop
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HelpDesk");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Comercial");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Administrativo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Informática");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Empresa", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Joaquina");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Cipriano");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Amilcar");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Paula");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Rui");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Ana");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Cristina");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Paulo");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("João");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Francisca");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Empresa", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.trvDepartamentosColaboradores = new System.Windows.Forms.TreeView();
            this.trvColaboradores = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(290, 13);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(158, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Departamentos / Colaboradores";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(75, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Colaboradores";
            // 
            // trvDepartamentosColaboradores
            // 
            this.trvDepartamentosColaboradores.AllowDrop = true;
            this.trvDepartamentosColaboradores.Location = new System.Drawing.Point(293, 33);
            this.trvDepartamentosColaboradores.Name = "trvDepartamentosColaboradores";
            treeNode1.Name = "HelpDEsk";
            treeNode1.Text = "HelpDesk";
            treeNode2.Name = "Comercial";
            treeNode2.Text = "Comercial";
            treeNode3.Name = "Node9";
            treeNode3.Text = "Administrativo";
            treeNode4.Name = "Informática";
            treeNode4.Text = "Informática";
            treeNode5.Name = "Empresa";
            treeNode5.Text = "Empresa";
            this.trvDepartamentosColaboradores.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.trvDepartamentosColaboradores.Size = new System.Drawing.Size(249, 291);
            this.trvDepartamentosColaboradores.TabIndex = 3;
            // 
            // trvColaboradores
            // 
            this.trvColaboradores.AllowDrop = true;
            this.trvColaboradores.Location = new System.Drawing.Point(19, 33);
            this.trvColaboradores.Name = "trvColaboradores";
            treeNode6.Name = "Joaquina";
            treeNode6.Text = "Joaquina";
            treeNode7.Name = "Cipriano";
            treeNode7.Text = "Cipriano";
            treeNode8.Name = "Amilcar";
            treeNode8.Text = "Amilcar";
            treeNode9.Name = "Paula";
            treeNode9.Text = "Paula";
            treeNode10.Name = "Rui";
            treeNode10.Text = "Rui";
            treeNode11.Name = "Ana";
            treeNode11.Text = "Ana";
            treeNode12.Name = "Cristina";
            treeNode12.Text = "Cristina";
            treeNode13.Name = "Paulo";
            treeNode13.Text = "Paulo";
            treeNode14.Name = "João";
            treeNode14.Text = "João";
            treeNode15.Name = "Francisca";
            treeNode15.Text = "Francisca";
            treeNode16.Name = "Empresa";
            treeNode16.Text = "Empresa";
            this.trvColaboradores.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.trvColaboradores.Size = new System.Drawing.Size(249, 291);
            this.trvColaboradores.TabIndex = 4;
            // 
            // frmDragDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 337);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.trvDepartamentosColaboradores);
            this.Controls.Add(this.trvColaboradores);
            this.Name = "frmDragDrop";
            this.Text = "Drag & Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TreeView trvDepartamentosColaboradores;
        internal System.Windows.Forms.TreeView trvColaboradores;
    }
}