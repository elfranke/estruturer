namespace Estructurer
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnanadir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbnamespace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvtabla = new System.Windows.Forms.DataGridView();
            this.Campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGcl = new System.Windows.Forms.Button();
            this.btngD = new System.Windows.Forms.Button();
            this.btngCyD = new System.Windows.Forms.Button();
            this.btnGwfomG = new System.Windows.Forms.Button();
            this.chkPK = new System.Windows.Forms.CheckBox();
            this.btnGwfomList = new System.Windows.Forms.Button();
            this.btnGStoreProcedure = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbcampo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 52);
            this.panel1.TabIndex = 1;
            // 
            // tbcampo
            // 
            this.tbcampo.Location = new System.Drawing.Point(3, 23);
            this.tbcampo.Name = "tbcampo";
            this.tbcampo.Size = new System.Drawing.Size(164, 20);
            this.tbcampo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.CboTipo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(198, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 52);
            this.panel2.TabIndex = 1;
            // 
            // CboTipo
            // 
            this.CboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Items.AddRange(new object[] {
            "int",
            "string",
            "decimal",
            "bool",
            "DateTime"});
            this.CboTipo.Location = new System.Drawing.Point(3, 23);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(341, 21);
            this.CboTipo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo";
            // 
            // btnanadir
            // 
            this.btnanadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanadir.Location = new System.Drawing.Point(12, 152);
            this.btnanadir.Name = "btnanadir";
            this.btnanadir.Size = new System.Drawing.Size(440, 51);
            this.btnanadir.TabIndex = 2;
            this.btnanadir.Text = "Añadir";
            this.btnanadir.UseVisualStyleBackColor = true;
            this.btnanadir.Click += new System.EventHandler(this.btnanadir_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbnamespace);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 52);
            this.panel3.TabIndex = 1;
            // 
            // tbnamespace
            // 
            this.tbnamespace.Location = new System.Drawing.Point(3, 23);
            this.tbnamespace.Name = "tbnamespace";
            this.tbnamespace.Size = new System.Drawing.Size(164, 20);
            this.tbnamespace.TabIndex = 1;
            this.tbnamespace.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Namespace";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.tbnombre);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(198, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(352, 52);
            this.panel4.TabIndex = 1;
            // 
            // tbnombre
            // 
            this.tbnombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbnombre.Location = new System.Drawing.Point(3, 23);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(341, 20);
            this.tbnombre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre";
            // 
            // dtgvtabla
            // 
            this.dtgvtabla.AllowUserToAddRows = false;
            this.dtgvtabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvtabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campo,
            this.Tipo});
            this.dtgvtabla.Location = new System.Drawing.Point(12, 213);
            this.dtgvtabla.Name = "dtgvtabla";
            this.dtgvtabla.ReadOnly = true;
            this.dtgvtabla.Size = new System.Drawing.Size(538, 205);
            this.dtgvtabla.TabIndex = 3;
            // 
            // Campo
            // 
            this.Campo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Campo.HeaderText = "Campo";
            this.Campo.Name = "Campo";
            this.Campo.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // btnGcl
            // 
            this.btnGcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGcl.Location = new System.Drawing.Point(12, 425);
            this.btnGcl.Name = "btnGcl";
            this.btnGcl.Size = new System.Drawing.Size(67, 51);
            this.btnGcl.TabIndex = 2;
            this.btnGcl.Text = "Generar Clase";
            this.btnGcl.UseVisualStyleBackColor = true;
            this.btnGcl.Click += new System.EventHandler(this.btnGcl_Click);
            // 
            // btngD
            // 
            this.btngD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngD.Location = new System.Drawing.Point(85, 425);
            this.btngD.Name = "btngD";
            this.btngD.Size = new System.Drawing.Size(84, 51);
            this.btngD.TabIndex = 2;
            this.btngD.Text = "WF formlario";
            this.btngD.UseVisualStyleBackColor = true;
            this.btngD.Click += new System.EventHandler(this.btngD_Click);
            this.btngD.MouseCaptureChanged += new System.EventHandler(this.btngD_Click);
            // 
            // btngCyD
            // 
            this.btngCyD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngCyD.Location = new System.Drawing.Point(278, 425);
            this.btngCyD.Name = "btngCyD";
            this.btngCyD.Size = new System.Drawing.Size(84, 51);
            this.btngCyD.TabIndex = 2;
            this.btngCyD.Text = "WF Mante.";
            this.btngCyD.UseVisualStyleBackColor = true;
            this.btngCyD.Click += new System.EventHandler(this.btngCyD_Click);
            // 
            // btnGwfomG
            // 
            this.btnGwfomG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGwfomG.Location = new System.Drawing.Point(175, 425);
            this.btnGwfomG.Name = "btnGwfomG";
            this.btnGwfomG.Size = new System.Drawing.Size(97, 51);
            this.btnGwfomG.TabIndex = 2;
            this.btnGwfomG.Text = "WF Consulta";
            this.btnGwfomG.UseVisualStyleBackColor = true;
            this.btnGwfomG.Click += new System.EventHandler(this.btnGwfomG_Click);
            // 
            // chkPK
            // 
            this.chkPK.AutoSize = true;
            this.chkPK.Location = new System.Drawing.Point(13, 127);
            this.chkPK.Name = "chkPK";
            this.chkPK.Size = new System.Drawing.Size(80, 17);
            this.chkPK.TabIndex = 4;
            this.chkPK.Text = "Primary key";
            this.chkPK.UseVisualStyleBackColor = true;
            // 
            // btnGwfomList
            // 
            this.btnGwfomList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGwfomList.Location = new System.Drawing.Point(368, 425);
            this.btnGwfomList.Name = "btnGwfomList";
            this.btnGwfomList.Size = new System.Drawing.Size(84, 51);
            this.btnGwfomList.TabIndex = 2;
            this.btnGwfomList.Text = "WF Lista";
            this.btnGwfomList.UseVisualStyleBackColor = true;
            this.btnGwfomList.Click += new System.EventHandler(this.btnGwfomList_Click);
            // 
            // btnGStoreProcedure
            // 
            this.btnGStoreProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGStoreProcedure.Location = new System.Drawing.Point(458, 425);
            this.btnGStoreProcedure.Name = "btnGStoreProcedure";
            this.btnGStoreProcedure.Size = new System.Drawing.Size(79, 51);
            this.btnGStoreProcedure.TabIndex = 2;
            this.btnGStoreProcedure.Text = "Generar Procedure";
            this.btnGStoreProcedure.UseVisualStyleBackColor = true;
            this.btnGStoreProcedure.Click += new System.EventHandler(this.btnGStoreProcedure_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.AutoSize = true;
            this.btnlimpiar.BackColor = System.Drawing.Color.Red;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(458, 153);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(88, 50);
            this.btnlimpiar.TabIndex = 5;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 503);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.chkPK);
            this.Controls.Add(this.dtgvtabla);
            this.Controls.Add(this.btngCyD);
            this.Controls.Add(this.btnGwfomG);
            this.Controls.Add(this.btnGwfomList);
            this.Controls.Add(this.btngD);
            this.Controls.Add(this.btnGStoreProcedure);
            this.Controls.Add(this.btnGcl);
            this.Controls.Add(this.btnanadir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Control";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvtabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbcampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnanadir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbnamespace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button btnGcl;
        private System.Windows.Forms.Button btngD;
        private System.Windows.Forms.Button btngCyD;
        private System.Windows.Forms.ComboBox CboTipo;
        private System.Windows.Forms.Button btnGwfomG;
        private System.Windows.Forms.CheckBox chkPK;
        private System.Windows.Forms.Button btnGwfomList;
        private System.Windows.Forms.Button btnGStoreProcedure;
        private System.Windows.Forms.Button btnlimpiar;
        public System.Windows.Forms.TextBox tbnombre;
        public System.Windows.Forms.DataGridView dtgvtabla;
    }
}

