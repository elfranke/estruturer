namespace Estructurer
{
    partial class Control
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.desdeCeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desdeCadenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desdeLaDbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desdeCeroToolStripMenuItem,
            this.desdeCadenaToolStripMenuItem,
            this.desdeLaDbToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // desdeCeroToolStripMenuItem
            // 
            this.desdeCeroToolStripMenuItem.Name = "desdeCeroToolStripMenuItem";
            this.desdeCeroToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.desdeCeroToolStripMenuItem.Text = "Desde cero";
            this.desdeCeroToolStripMenuItem.Click += new System.EventHandler(this.desdeCeroToolStripMenuItem_Click);
            // 
            // desdeCadenaToolStripMenuItem
            // 
            this.desdeCadenaToolStripMenuItem.Name = "desdeCadenaToolStripMenuItem";
            this.desdeCadenaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.desdeCadenaToolStripMenuItem.Text = "Desde cadena";
            this.desdeCadenaToolStripMenuItem.Click += new System.EventHandler(this.desdeCadenaToolStripMenuItem_Click);
            // 
            // desdeLaDbToolStripMenuItem
            // 
            this.desdeLaDbToolStripMenuItem.Name = "desdeLaDbToolStripMenuItem";
            this.desdeLaDbToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.desdeLaDbToolStripMenuItem.Text = "desde la Db";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Control";
            this.Text = "Control";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem desdeCeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desdeCadenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desdeLaDbToolStripMenuItem;
    }
}