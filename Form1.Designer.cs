namespace Probabilidad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fACTORIALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALCULOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONJUNTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fACTORIALToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fACTORIALToolStripMenuItem
            // 
            this.fACTORIALToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculoToolStripMenuItem,
            this.cONJUNTOSToolStripMenuItem});
            this.fACTORIALToolStripMenuItem.Font = new System.Drawing.Font("Tiza", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fACTORIALToolStripMenuItem.Name = "fACTORIALToolStripMenuItem";
            this.fACTORIALToolStripMenuItem.Size = new System.Drawing.Size(208, 27);
            this.fACTORIALToolStripMenuItem.Text = "PROBABILIDAD";
            // 
            // calculoToolStripMenuItem
            // 
            this.calculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cALCULOToolStripMenuItem1});
            this.calculoToolStripMenuItem.Name = "calculoToolStripMenuItem";
            this.calculoToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.calculoToolStripMenuItem.Text = "FACTORIAL";
            this.calculoToolStripMenuItem.Click += new System.EventHandler(this.calculoToolStripMenuItem_Click);
            // 
            // cALCULOToolStripMenuItem1
            // 
            this.cALCULOToolStripMenuItem1.Name = "cALCULOToolStripMenuItem1";
            this.cALCULOToolStripMenuItem1.Size = new System.Drawing.Size(193, 28);
            this.cALCULOToolStripMenuItem1.Text = "CALCULO";
            this.cALCULOToolStripMenuItem1.Click += new System.EventHandler(this.cALCULOToolStripMenuItem1_Click);
            // 
            // cONJUNTOSToolStripMenuItem
            // 
            this.cONJUNTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem});
            this.cONJUNTOSToolStripMenuItem.Name = "cONJUNTOSToolStripMenuItem";
            this.cONJUNTOSToolStripMenuItem.Size = new System.Drawing.Size(222, 28);
            this.cONJUNTOSToolStripMenuItem.Text = "CONJUNTOS";
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(248, 28);
            this.calcularToolStripMenuItem.Text = "OPERACIONES";
            this.calcularToolStripMenuItem.Click += new System.EventHandler(this.calcularToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fACTORIALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALCULOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONJUNTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
    }
}

