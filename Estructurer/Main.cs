using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructurer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(string PK,DataGridView view,string nombre)
        {
            InitializeComponent();
            foreach (DataGridViewRow item in view.Rows)
            {
                dtgvtabla.Rows.Add(item.Cells[0].Value,item.Cells[1].Value);
            }
            pk = PK;
            tbnombre.Text = nombre;
        }

        public  string pk = "";


        public string Gclass()
        {
            StringBuilder classe = new StringBuilder();

            classe.AppendLine("using System;");
            classe.AppendLine("using System.Collections.Generic;");
            classe.AppendLine("using System.Data;");
            classe.AppendLine("using System.Linq;");
            classe.AppendLine("using System.Text;");
            classe.AppendLine("using System.Data.Sql;");
            classe.AppendLine("using System.Data.SqlClient;");
            classe.AppendLine();


            classe.AppendLine(string.Format($"namespace  {tbnamespace.Text}"));
            classe.AppendLine("{");
            classe.AppendLine(string.Format($" public class {tbnombre.Text}s"));
            classe.AppendLine("{");

            string encapsulado = " {get; set;}";
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                string valor = "";
                valor = string.Format("public {0} {1} {2}", item.Cells[Tipo.Index].Value.ToString(), item.Cells[Campo.Index].Value.ToString(), encapsulado);
                classe.AppendLine(valor);

            }
            classe.AppendLine();

            classe.AppendLine(string.Format($"public {tbnombre.Text}s (int id)"));
            classe.AppendLine("{");

            classe.AppendLine(string.Format($"DataTable table = util.ValoresEnTabla(\"Select * from {tbnombre.Text} where {pk}=\"+id+\" ;\");"));
            classe.AppendLine();

            classe.AppendLine("foreach (DataRow field in table.Rows)");
            classe.AppendLine("{");


            foreach (DataGridViewRow item in dtgvtabla.Rows)

            {
                string valor = "";
                valor = string.Format($"{item.Cells[Campo.Index].Value.ToString()} = ");

                switch (item.Cells[Tipo.Index].Value.ToString())
                {
                    case "int":
                        valor += string.Format($" Convert.ToInt32(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;

                    case "decimal":
                        valor += string.Format($" Convert.ToDecimal(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;

                    case "string":
                        valor += string.Format($" field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString();");
                        break;

                    case "bool":
                        valor += string.Format($" Convert.ToBoolean(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;
                    case "DateTime":
                        valor += string.Format($"DateTime.Parse(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;
                }
                classe.AppendLine(valor);



            }
            classe.AppendLine("}");


            classe.AppendLine("}");
            classe.AppendLine();


            classe.AppendLine(string.Format($"public {tbnombre.Text}s (DataRow field)"));
            classe.AppendLine("{");
            classe.AppendLine();

            foreach (DataGridViewRow item in dtgvtabla.Rows)

            {
                string valor = "";
                valor = string.Format($"{item.Cells[Campo.Index].Value.ToString()} = ");

                switch (item.Cells[Tipo.Index].Value.ToString())
                {
                    case "int":
                        valor += string.Format($" Convert.ToInt32(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;

                    case "decimal":
                        valor += string.Format($" Convert.ToDecimal(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;

                    case "string":
                        valor += string.Format($" field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString();");
                        break;

                    case "bool":
                        valor += string.Format($" Convert.ToBoolean(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;
                    case "DateTime":
                        valor += string.Format($"DateTime.Parse(field[\"{item.Cells[Campo.Index].Value.ToString()}\"].ToString());");
                        break;
                }
                classe.AppendLine(valor);



            }

            classe.AppendLine("}");
            classe.AppendLine();



            classe.AppendLine(string.Format($"public {tbnombre.Text}s ()"));
            classe.AppendLine("{");

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                string valor = "";
                valor = string.Format($"{item.Cells[Campo.Index].Value.ToString()} = ");

                switch (item.Cells[Tipo.Index].Value.ToString())
                {
                    case "int":
                        valor += "0;";
                        break;

                    case "decimal":
                        valor += "0;";
                        break;

                    case "string":
                        valor += "\"\";";
                        break;

                    case "bool":
                        valor += "false;";
                        break;
                    case "DateTime": 
                        valor += " DateTime.Now;"; 
                        break;
                }
                classe.AppendLine(valor);
            }


            classe.AppendLine("}");
            classe.AppendLine();


            classe.AppendLine("public bool guardar()");
            classe.AppendLine("{");
            classe.AppendLine();

            classe.AppendLine("SqlCommand cmd = new SqlCommand();");
            classe.AppendLine("cmd.CommandType = CommandType.StoredProcedure;");
            classe.AppendLine(string.Format($"cmd.CommandText = \"sp_G{tbnombre.Text}\";"));

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
            classe.AppendLine(string.Format($"cmd.Parameters.AddWithValue(\"@{item.Cells[Campo.Index].Value.ToString()}\", {item.Cells[Campo.Index].Value.ToString()});"));
            }
            classe.AppendLine("cmd.Parameters.Add(\"@Retorno\", SqlDbType.Int);");
            classe.AppendLine("cmd.Parameters[\"@Retorno\"].Direction = ParameterDirection.Output; //se debe especificar que es output");
            classe.AppendLine("return util.GuardarYUsarId(\"@Retorno\", ref cmd);");

            classe.AppendLine();
            classe.AppendLine("}");


            classe.AppendLine("}");
            classe.AppendLine();
            classe.AppendLine("}");

            return classe.ToString();
        }

        public string GDisenoclass(string name, bool control = true, bool list = false)
        {
            StringBuilder classe = new StringBuilder();

            classe.AppendLine("using System;");
            classe.AppendLine("using System.Collections.Generic;");
            classe.AppendLine("using System.ComponentModel;");
            classe.AppendLine("using System.Data;");
            classe.AppendLine("using System.Drawing;");
            classe.AppendLine("using System.Linq;");
            classe.AppendLine("using System.Text;");
            classe.AppendLine("using System.Threading.Tasks;");
            classe.AppendLine("using System.Windows.Forms;");
            classe.AppendLine();


            classe.AppendLine(string.Format($"namespace  {tbnamespace.Text}"));
            classe.AppendLine("{");
            classe.AppendLine(string.Format($" public partial class {name} : Form"));
            classe.AppendLine("{");


            classe.AppendLine();

            classe.AppendLine(string.Format($"public {name} ()"));
            classe.AppendLine("{");
            classe.AppendLine();
            classe.AppendLine("InitializeComponent();");
            classe.AppendLine();
            classe.AppendLine("}");
            classe.AppendLine();

            classe.AppendLine(string.Format($"public void  Limpiar()"));
            classe.AppendLine("{");
            classe.AppendLine();
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                if (control)
                {
                    if (item.Cells[Campo.Index].Value.ToString()==pk)
                    {

                    }
                    else
                    if (item.Cells[Tipo.Index].Value.ToString() != "bool")
                    {
                        classe.AppendLine(String.Format($"tb{item.Cells[Campo.Index].Value.ToString()}.Text =\"\";"));

                    }
                }

            }
            classe.AppendLine();
            classe.AppendLine("}");
            classe.AppendLine();

            if (list)
            {
                classe.AppendLine("public string id=\"0\";");
                classe.AppendLine($"public {tbnombre.Text}s clase;");
                 


                classe.AppendLine("public void btnGuardar_Click(object sender, EventArgs e)");
                classe.AppendLine("{");
                classe.AppendLine(string.Format($"dtgv{tbnombre.Text}.DataSource = util.BusquedatLista(cboCriterio.Text, cboTabla.Text, tbbusqueda.Text);"));
                classe.AppendLine("Limpiar();");
                classe.AppendLine("}");

                classe.AppendLine("private void tbbusqueda_KeyPress(object sender, KeyPressEventArgs e)");
                classe.AppendLine("{");
                classe.AppendLine("if (e.KeyChar == 13)");
                classe.AppendLine("{");

                classe.AppendLine("btnGuardar_Click(sender, e);");

                classe.AppendLine("}");
                classe.AppendLine("}");

                classe.AppendLine($"private void dtgv{tbnombre.Text}_DoubleClick(object sender, EventArgs e)");
                classe.AppendLine("{");

                classe.AppendLine($"id = dtgv{tbnombre.Text}.Rows[dtgv{tbnombre.Text}.CurrentRow.Index].Cells[{pk}.Index].Value.ToString();");
                classe.AppendLine($"DataTable dt = dtgv{tbnombre.Text}.DataSource as DataTable;");
                classe.AppendLine($"DataRow row = dt.Rows[dtgv{tbnombre.Text}.CurrentRow.Index];");
                classe.AppendLine($"clase = new {tbnombre.Text}s(row);");
                classe.AppendLine("this.Close();");

                classe.AppendLine("}");

            }

            if (control)
            {
                classe.AppendLine("public void btnGuardar_Click(object sender, EventArgs e)");
                classe.AppendLine("{");
                classe.AppendLine();
                classe.AppendLine(string.Format($"{tbnombre.Text}s {tbnombre.Text.ToLower()}= new {tbnombre.Text}s();"));

                foreach (DataGridViewRow item in dtgvtabla.Rows)
                {

                    switch (item.Cells[Tipo.Index].Value.ToString())
                    {
                        case "bool":
                            classe.AppendLine(string.Format($"{tbnombre.Text.ToLower()}.{item.Cells[Campo.Index].Value.ToString()}= chk{item.Cells[Campo.Index].Value.ToString()}.Checked;"));
                            break;

                        case "int":
                            classe.AppendLine(string.Format($"{tbnombre.Text.ToLower()}.{item.Cells[Campo.Index].Value.ToString()}= Convert.ToInt32(tb{item.Cells[Campo.Index].Value.ToString()}.Text);"));
                            break;

                        case "string":
                            classe.AppendLine(string.Format($"{tbnombre.Text.ToLower()}.{item.Cells[Campo.Index].Value.ToString()}= tb{item.Cells[Campo.Index].Value.ToString()}.Text;"));
                            break;

                        case "decimal":
                            classe.AppendLine(string.Format($"{tbnombre.Text.ToLower()}.{item.Cells[Campo.Index].Value.ToString()}= Convert.ToDecimal(tb{item.Cells[Campo.Index].Value.ToString()}.Text);"));
                            break;
                    }

                }
                classe.AppendLine(string.Format($"{tbnombre.Text.ToLower()}.guardar();"));
                classe.AppendLine("Limpiar();");
                classe.AppendLine();
                classe.AppendLine("}");
            }


            classe.AppendLine();
            classe.AppendLine("}");
            classe.AppendLine();
            classe.AppendLine("}");

            return classe.ToString();
        }

        public string GDdesignerClas(string name,string Inic="",string Publ="")
        {
            StringBuilder desiner = new StringBuilder();

            desiner.AppendLine(String.Format($"namespace {tbnamespace.Text}"));
            desiner.AppendLine("{");
            desiner.AppendLine(String.Format($"partial class {name}"));
            desiner.AppendLine("{");
            desiner.AppendLine("/// <summary>");
            desiner.AppendLine("/// Required designer variable.");
            desiner.AppendLine("/// </summary>");
            desiner.AppendLine("private System.ComponentModel.IContainer components = null;");
            desiner.AppendLine();

            desiner.AppendLine("/// <summary>");
            desiner.AppendLine("/// Clean up any resources being used.");
            desiner.AppendLine("/// </summary>");
            desiner.AppendLine("protected override void Dispose(bool disposing)");
            desiner.AppendLine("{");
            desiner.AppendLine("if (disposing && (components != null))");
            desiner.AppendLine("{");
            desiner.AppendLine("components.Dispose();");
            desiner.AppendLine("}");
            desiner.AppendLine("base.Dispose(disposing);");
            desiner.AppendLine("}");
            desiner.AppendLine();

            desiner.AppendLine("#region Windows Form Designer generated code");
            desiner.AppendLine();

            desiner.AppendLine("/// <summary>");
            desiner.AppendLine("/// Required method for Designer support - do not modify");
            desiner.AppendLine("/// the contents of this method with the code editor.");
            desiner.AppendLine("/// </summary>");
            desiner.AppendLine("private void InitializeComponent()");
            desiner.AppendLine("{");

            desiner.AppendLine("this.FLYPrincipal = new System.Windows.Forms.FlowLayoutPanel();");
            desiner.AppendLine("this.btnGuardar = new System.Windows.Forms.Button();");
            

            desiner.AppendLine(String.Format($"this.FLYPrincipal.SuspendLayout();"));
            desiner.AppendLine(String.Format($"this.SuspendLayout();"));


            desiner.AppendLine("//");
            desiner.AppendLine("// FLYPrincipal");
            desiner.AppendLine("//");
            desiner.AppendLine("this.FLYPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;");
            desiner.AppendLine("this.FLYPrincipal.Location = new System.Drawing.Point(0, 0);");
            desiner.AppendLine("this.FLYPrincipal.Name = \"FLYPrincipal\";");
            desiner.AppendLine("this.FLYPrincipal.Size = new System.Drawing.Size(467, 450);");
            desiner.AppendLine("this.FLYPrincipal.TabIndex = 0;");


            desiner.AppendLine(String.Format($"this.FLYPrincipal.Controls.Add(this.btnGuardar);"));
            desiner.AppendLine();
            // inicializado

            desiner.AppendLine(Inic);
            desiner.AppendLine();



            desiner.AppendLine();
            desiner.AppendLine("//");
            desiner.AppendLine(string.Format($"// btnGuardar"));
            desiner.AppendLine("//");
            desiner.AppendLine("this.btnGuardar.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));");
            desiner.AppendLine("this.btnGuardar.Name = \"btnGuardar\";");
            desiner.AppendLine("this.btnGuardar.Size = new System.Drawing.Size(190, 39);");
            desiner.AppendLine("this.btnGuardar.TabIndex = 200;");
            desiner.AppendLine("this.btnGuardar.Text = \"Guardar\";");
            desiner.AppendLine("this.btnGuardar.UseVisualStyleBackColor = true;");
            desiner.AppendLine("this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);");
            

            desiner.AppendLine();
            desiner.AppendLine("//");
            desiner.AppendLine(string.Format($"// {name}"));
            desiner.AppendLine("//");

            desiner.AppendLine(string.Format($"this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);"));
            desiner.AppendLine(string.Format($"this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;"));
            desiner.AppendLine(string.Format($"this.ClientSize = new System.Drawing.Size(467, 450);"));
            desiner.AppendLine(string.Format($"this.Controls.Add(this.FLYPrincipal);"));
            desiner.AppendLine(string.Format($"this.Name = \"{name}\";"));
            desiner.AppendLine(string.Format($" this.Text = \"{name}\";"));
            desiner.AppendLine(string.Format($" this.FLYPrincipal.ResumeLayout(false);"));


            desiner.AppendLine();
            desiner.AppendLine(string.Format($"this.ResumeLayout(false);"));
            desiner.AppendLine("}");
            desiner.AppendLine("#endregion");

            desiner.AppendLine("private System.Windows.Forms.FlowLayoutPanel FLYPrincipal;");

            // public

            desiner.AppendLine(String.Format($"private System.Windows.Forms.Button btnGuardar;"));
            desiner.AppendLine(Publ);

            desiner.AppendLine("}");
            desiner.AppendLine("}");

            return desiner.ToString();
        }

        public string gridIni()
        {
            StringBuilder classe = new StringBuilder();
            classe.AppendLine();
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text} = new System.Windows.Forms.DataGridView();"));

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                classe.AppendLine(string.Format($"this.{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.DataGridViewTextBoxColumn();"));
                classe.AppendLine(string.Format($"this.{item.Cells[Campo.Index].Value.ToString()}.DataPropertyName = \"{item.Cells[Campo.Index].Value.ToString()}\";"));
                classe.AppendLine("// next");
            }
            classe.AppendLine(string.Format($"((System.ComponentModel.ISupportInitialize)(this.dtgv{tbnombre.Text})).BeginInit();"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.AllowUserToAddRows = false;"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.DoubleClick += new System.EventHandler(this.dtgv{tbnombre.Text}_DoubleClick);"));
            classe.AppendLine(string.Format($" this.dtgv{tbnombre.Text}.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] "));
            classe.AppendLine("{");
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                classe.AppendLine(string.Format($"this.{item.Cells[Campo.Index].Value.ToString()},"));
            }
            classe.AppendLine("});");
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.Location = new System.Drawing.Point(12, 229);"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.Name =  \"dtgvtabla\";"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.ReadOnly = true;"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.Size = new System.Drawing.Size(414, 205);"));
            classe.AppendLine(string.Format($"this.dtgv{tbnombre.Text}.TabIndex = 3;"));

            classe.AppendLine(String.Format($"this.FLYPrincipal.Controls.Add(this.dtgv{tbnombre.Text});"));


            classe.AppendLine();
            return classe.ToString();
        }

        public string gridpub()
    {
            StringBuilder classe = new StringBuilder();
            classe.AppendLine();
            classe.AppendLine(string.Format($"private System.Windows.Forms.DataGridView dtgv{tbnombre.Text};"));
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                classe.AppendLine(string.Format($"private System.Windows.Forms.DataGridViewTextBoxColumn {item.Cells[Campo.Index].Value.ToString()};"));
            }
            classe.AppendLine();

            return classe.ToString();
    }

        public string controlsIni()
        {
            StringBuilder desiner = new StringBuilder();
            desiner.AppendLine();

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {

                desiner.AppendLine();
                desiner.AppendLine(String.Format($"//here with put the other panel"));
                desiner.AppendLine(String.Format($"//next panel"));

                if (item.Cells[Tipo.Index].Value.ToString() == "bool")
                {
                    desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.Label();"));
                    desiner.AppendLine(String.Format($"this.chk{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.CheckBox();"));
                    desiner.AppendLine(String.Format($"this.p{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.Panel();"));
                    desiner.AppendLine(String.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.SuspendLayout();"));
                }
                else
                {
                    desiner.AppendLine(String.Format($"this.p{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.Panel();"));
                    desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.Label();"));
                    desiner.AppendLine(String.Format($"this.tb{item.Cells[Campo.Index].Value.ToString()} = new System.Windows.Forms.TextBox();"));
                    desiner.AppendLine(String.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.SuspendLayout();"));

                }
                //switch (item.Cells[Tipo.Index].Value.ToString())
                //{
                //    default:

                //        break;

                //    case "bool":
                //        break;
                //}
            }
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                desiner.AppendLine(String.Format($"this.FLYPrincipal.Controls.Add(this.p{item.Cells[Campo.Index].Value.ToString()});"));

            }

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                desiner.AppendLine();
                desiner.AppendLine("//");
                desiner.AppendLine(string.Format($"// p{item.Cells[Campo.Index].Value.ToString()}"));
                desiner.AppendLine("//");

                if (item.Cells[Tipo.Index].Value.ToString() == "bool")
                {
                    desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Controls.Add(this.chk{item.Cells[Campo.Index].Value.ToString()});"));
                    desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Controls.Add(this.lb{item.Cells[Campo.Index].Value.ToString()});"));
                }
                else
                {
                    desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Controls.Add(this.tb{item.Cells[Campo.Index].Value.ToString()});"));
                    desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Controls.Add(this.lb{item.Cells[Campo.Index].Value.ToString()});"));

                }
                
                desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Location = new System.Drawing.Point(3, 3);"));
                desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Name = \"p{item.Cells[Campo.Index].Value.ToString()}\";"));
                desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.Size = new System.Drawing.Size(180, 52);"));
                desiner.AppendLine(string.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.TabIndex = {item.Index};"));

            }
            
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {

                desiner.AppendLine();
                desiner.AppendLine("//");
                desiner.AppendLine(string.Format($"// lb{item.Cells[Campo.Index].Value.ToString()}"));
                desiner.AppendLine("//");

                desiner.AppendLine(String.Format($" this.lb{item.Cells[Campo.Index].Value.ToString()}.AutoSize = true;"));
                desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()}.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));"));
                desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()}.Location = new System.Drawing.Point(3, 4);"));
                desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()}.Name = \"lb{item.Cells[Campo.Index].Value.ToString()}\";"));
                desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()}.Size = new System.Drawing.Size(57, 16);"));
                desiner.AppendLine(String.Format($"this.lb{item.Cells[Campo.Index].Value.ToString()}.TabIndex = 0;"));
                desiner.AppendLine(String.Format($" this.lb{item.Cells[Campo.Index].Value.ToString()}.Text = \"{item.Cells[Campo.Index].Value.ToString()}\";"));
                desiner.AppendLine(String.Format($""));



            }
            
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                if (item.Cells[Tipo.Index].Value.ToString() == "bool")
                {
                    desiner.AppendLine();
                    desiner.AppendLine("//");
                    desiner.AppendLine(string.Format($"// chk{item.Cells[Campo.Index].Value.ToString()}"));
                    desiner.AppendLine("//");

                    desiner.AppendLine(string.Format($"this.chk{item.Cells[Campo.Index].Value.ToString()}.Location = new System.Drawing.Point(3, 23);"));
                    desiner.AppendLine(string.Format($"this.chk{item.Cells[Campo.Index].Value.ToString()}.Name = \"chk{item.Cells[Campo.Index].Value.ToString()}\";"));
                    desiner.AppendLine(string.Format($"this.chk{item.Cells[Campo.Index].Value.ToString()}.TabIndex = 1;"));
                    desiner.AppendLine(string.Format($"this.chk{item.Cells[Campo.Index].Value.ToString()}.Checked = true;"));
                }
                else
                {
                    desiner.AppendLine();
                    desiner.AppendLine("//");
                    desiner.AppendLine(string.Format($"// tb{item.Cells[Campo.Index].Value.ToString()}"));
                    desiner.AppendLine("//");

                    desiner.AppendLine(string.Format($"this.tb{item.Cells[Campo.Index].Value.ToString()}.Location = new System.Drawing.Point(3, 23);"));
                    desiner.AppendLine(string.Format($"this.tb{item.Cells[Campo.Index].Value.ToString()}.Name = \"tb{item.Cells[Campo.Index].Value.ToString()}\";"));
                    desiner.AppendLine(string.Format($"this.tb{item.Cells[Campo.Index].Value.ToString()}.Size = new System.Drawing.Size(164, 20);"));
                    desiner.AppendLine(string.Format($"this.tb{item.Cells[Campo.Index].Value.ToString()}.TabIndex = 1;"));
                    if (item.Cells[Campo.Index].Value.ToString()==pk)
                    {
                        desiner.AppendLine(string.Format($"this.tb{item.Cells[Campo.Index].Value.ToString()}.Text = \"0\";"));
                    }
                }



            }

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                desiner.AppendLine();

                desiner.AppendLine(String.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.ResumeLayout(false);"));
                desiner.AppendLine(String.Format($"this.p{item.Cells[Campo.Index].Value.ToString()}.PerformLayout();"));

            }
            desiner.AppendLine();

            return desiner.ToString();
        }

        public string controlsPub()
        {
            StringBuilder desiner = new StringBuilder();

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                desiner.AppendLine();

                if (item.Cells[Tipo.Index].Value.ToString() == "bool")
                {
                    desiner.AppendLine(String.Format($"private System.Windows.Forms.CheckBox chk{item.Cells[Campo.Index].Value.ToString()};"));
                    desiner.AppendLine(String.Format($"private System.Windows.Forms.Label lb{item.Cells[Campo.Index].Value.ToString()};"));
                    desiner.AppendLine(String.Format($"private System.Windows.Forms.Panel p{item.Cells[Campo.Index].Value.ToString()};"));
                }
                else
                {
                    desiner.AppendLine(String.Format($"private System.Windows.Forms.Panel p{item.Cells[Campo.Index].Value.ToString()};"));
                    desiner.AppendLine(String.Format($"private System.Windows.Forms.TextBox tb{item.Cells[Campo.Index].Value.ToString()};"));
                    desiner.AppendLine(String.Format($"private System.Windows.Forms.Label lb{item.Cells[Campo.Index].Value.ToString()};"));
                }



            }


            return desiner.ToString();
        }

        public string ListIni()
        {
            StringBuilder desiner = new StringBuilder();
            desiner.AppendLine();

            desiner.AppendLine(String.Format($"//here with put the other panel"));
            desiner.AppendLine(String.Format($"//next panel"));

            desiner.AppendLine(String.Format($"this.pbusqueda = new System.Windows.Forms.Panel();"));
            desiner.AppendLine(String.Format($"this.lbbusqueda  = new System.Windows.Forms.Label();"));
            desiner.AppendLine(String.Format($"this.tbbusqueda = new System.Windows.Forms.TextBox();"));
            desiner.AppendLine(String.Format($"this.pbusqueda.SuspendLayout();"));
            desiner.AppendLine(String.Format($"this.FLYPrincipal.Controls.Add(this.pbusqueda);"));

            
            desiner.AppendLine(String.Format($"this.pCriterio = new System.Windows.Forms.Panel();"));
            desiner.AppendLine(String.Format($"this.cboTabla = new System.Windows.Forms.ComboBox();"));
            desiner.AppendLine(String.Format($"this.cboCriterio = new System.Windows.Forms.ComboBox();"));
            desiner.AppendLine(String.Format($"this.pCriterio.SuspendLayout();"));
            desiner.AppendLine(String.Format($"this.FLYPrincipal.Controls.Add(this.pCriterio);"));

            
            desiner.AppendLine(string.Format($"this.pbusqueda.Controls.Add(this.tbbusqueda);"));
            desiner.AppendLine(string.Format($"this.pbusqueda.Controls.Add(this.lbbusqueda);"));

            desiner.AppendLine(string.Format($"this.pCriterio.Controls.Add(this.cboTabla);"));
            desiner.AppendLine(string.Format($"this.pCriterio.Controls.Add(this.cboCriterio);"));


            desiner.AppendLine(string.Format($"this.pbusqueda.Location = new System.Drawing.Point(3, 3);"));
            desiner.AppendLine(string.Format($"this.pbusqueda.Name = \"pbusqueda\";"));
            desiner.AppendLine(string.Format($"this.pbusqueda.Size = new System.Drawing.Size(180, 52);"));
            desiner.AppendLine(string.Format($"this.pbusqueda.TabIndex = 1;"));

            desiner.AppendLine(string.Format($"this.pCriterio.Location = new System.Drawing.Point(3, 3);"));
            desiner.AppendLine(string.Format($"this.pCriterio.Name = \"pCriterio\";"));
            desiner.AppendLine(string.Format($"this.pCriterio.Size = new System.Drawing.Size(360, 52);"));
            desiner.AppendLine(string.Format($"this.pCriterio.TabIndex = 1;"));

            desiner.AppendLine();
            desiner.AppendLine("//");
            desiner.AppendLine(string.Format($"// lbbusqueda"));
            desiner.AppendLine("//");

            desiner.AppendLine(String.Format($" this.lbbusqueda.AutoSize = true;"));
            desiner.AppendLine(String.Format($"this.lbbusqueda.Font = new System.Drawing.Font(\"Microsoft Sans Serif\", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));"));
            desiner.AppendLine(String.Format($"this.lbbusqueda.Location = new System.Drawing.Point(3, 4);"));
            desiner.AppendLine(String.Format($"this.lbbusqueda.Name = \"lbbusqueda\";"));
            desiner.AppendLine(String.Format($"this.lbbusqueda.Size = new System.Drawing.Size(57, 16);"));
            desiner.AppendLine(String.Format($"this.lbbusqueda.TabIndex = 0;"));
            desiner.AppendLine(String.Format($" this.lbbusqueda.Text = \"Criterio de busqueda \";"));
            desiner.AppendLine(String.Format($""));

            desiner.AppendLine();
            desiner.AppendLine("//");
            desiner.AppendLine(string.Format($"// tbbusqueda"));
            desiner.AppendLine("//");

            desiner.AppendLine(string.Format($"this.tbbusqueda.Location = new System.Drawing.Point(3, 23);"));
            desiner.AppendLine(string.Format($"this.tbbusqueda.Name = \"tbbusqueda\";"));
            desiner.AppendLine(string.Format($"this.tbbusqueda.Size = new System.Drawing.Size(164, 20);"));
            desiner.AppendLine(string.Format($"this.tbbusqueda.TabIndex = 1;"));
            desiner.AppendLine(string.Format($"this.tbbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbbusqueda_KeyPress);"));
            



            desiner.AppendLine();
            desiner.AppendLine("//");
            desiner.AppendLine(string.Format($"// Combobox"));
            desiner.AppendLine("//");


            desiner.AppendLine(string.Format($"this.cboCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));"));
            desiner.AppendLine(string.Format($"this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;"));
            desiner.AppendLine(string.Format($"this.cboCriterio.FormattingEnabled = true;"));
            desiner.AppendLine("this.cboCriterio.Items.AddRange(new object[] {");
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                desiner.AppendLine();

                desiner.AppendLine(String.Format($"\"{item.Cells[Campo.Index].Value.ToString()}\","));

            }

            desiner.AppendLine("});");
            desiner.AppendLine(string.Format($"this.cboCriterio.Location = new System.Drawing.Point(3, 23);"));
            desiner.AppendLine(string.Format($"this.cboCriterio.Name = \"cboCriterio\";"));
            desiner.AppendLine(string.Format($"this.cboCriterio.TabIndex = 1;"));


            desiner.AppendLine();
            desiner.AppendLine("//");
            desiner.AppendLine(string.Format($"// Combobox"));
            desiner.AppendLine("//");


            desiner.AppendLine(string.Format($"this.cboTabla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)| System.Windows.Forms.AnchorStyles.Right)));"));
            desiner.AppendLine(string.Format($"this.cboTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;"));
            desiner.AppendLine(string.Format($"this.cboTabla.FormattingEnabled = true;"));
            desiner.AppendLine("this.cboTabla.Items.AddRange(new object[] {");
            desiner.AppendLine(String.Format($"\"{tbnombre.Text}\","));

            desiner.AppendLine("});");
            desiner.AppendLine(string.Format($"this.cboTabla.Location = new System.Drawing.Point(3, 23);"));
            desiner.AppendLine(string.Format($"this.cboTabla.Name = \"cboTabla\";"));
            desiner.AppendLine(string.Format($"this.cboTabla.TabIndex = 1;"));
            desiner.AppendLine(string.Format($"this.cboTabla.Visible = false;"));
            desiner.AppendLine();

            desiner.AppendLine(String.Format($"this.pbusqueda.ResumeLayout(false);"));
            desiner.AppendLine(String.Format($"this.pbusqueda.PerformLayout();"));

            desiner.AppendLine(String.Format($"this.pCriterio.ResumeLayout(false);"));
            desiner.AppendLine(String.Format($"this.pCriterio.PerformLayout();"));


            desiner.AppendLine();
            return desiner.ToString();

        }
        public string ListPub()
        {
            StringBuilder desiner = new StringBuilder();
            desiner.AppendLine();
            desiner.AppendLine("private System.Windows.Forms.Panel pbusqueda;");
            desiner.AppendLine("private System.Windows.Forms.Panel pCriterio;");
            desiner.AppendLine("private System.Windows.Forms.TextBox tbbusqueda;");
            desiner.AppendLine("private System.Windows.Forms.Label lbbusqueda;");
            desiner.AppendLine("private System.Windows.Forms.ComboBox cboTabla;");
            desiner.AppendLine("private System.Windows.Forms.ComboBox cboCriterio;");

            desiner.AppendLine();
            return desiner.ToString();
        }

        public string StoreProcedure()
        {
            StringBuilder store = new StringBuilder();
            store.AppendLine($"USE [{tbnamespace.Text}]");
            store.AppendLine($"go");
            store.AppendLine(string.Format($"CREATE PROCEDURE sp_G{tbnombre.Text}"));

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                    switch (item.Cells[Tipo.Index].Value.ToString())
                    {
                        case "bool":
                            store.AppendLine(String.Format($"@{item.Cells[Campo.Index].Value.ToString()} bit,"));
                            break;
                        case "int":
                            store.AppendLine(String.Format($"@{item.Cells[Campo.Index].Value.ToString()} int,"));
                            break;
                        case "decimal":
                            store.AppendLine(String.Format($"@{item.Cells[Campo.Index].Value.ToString()} float,"));
                            break;
                        case "string":
                            store.AppendLine(String.Format($"@{item.Cells[Campo.Index].Value.ToString()} nvarchar(max),"));
                            break;
                        case "DateTime":
                            store.AppendLine(String.Format($"@{item.Cells[Campo.Index].Value.ToString()} datetime,"));
                            break;
                    }


            }
            store.AppendLine(String.Format($"@Retorno int"));

            store.AppendLine("AS");
            store.AppendLine("BEGIN");
            store.AppendLine(string.Format($" if @{pk}=0 "));
            store.AppendLine("   BEGIN");

            store.AppendLine(string.Format($"   insert into {tbnombre.Text}"));

            store.Append("(");
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                if (pk == item.Cells[Campo.Index].Value.ToString())
                {

                }
                else
                {
                    if (dtgvtabla.Rows[dtgvtabla.Rows.Count - 1].Index == item.Index)
                    {
                        store.Append(item.Cells[Campo.Index].Value.ToString());
                    }
                    else
                    {
                        store.Append(item.Cells[Campo.Index].Value.ToString() + ",");
                    }
                }
            }
            store.Append(")");

            store.AppendLine("values");
            store.Append("(");
            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                if (pk == item.Cells[Campo.Index].Value.ToString())
                {

                }
                else
                {
                    if (dtgvtabla.Rows[dtgvtabla.Rows.Count - 1].Index == item.Index)
                    {
                        store.Append("@" + item.Cells[Campo.Index].Value.ToString());
                    }
                    else
                    {
                        store.Append("@" + item.Cells[Campo.Index].Value.ToString() + ",");
                    }
                }
            }
            store.Append(")");
            store.AppendLine(String.Format($"set @Retorno= @@identity"));

            store.AppendLine("   end");

            store.AppendLine(string.Format($"if @{pk}>0"));
            store.AppendLine("      BEGIN");
            store.AppendLine(string.Format($"update {tbnombre.Text} set "));

            foreach (DataGridViewRow item in dtgvtabla.Rows)
            {
                if (pk == item.Cells[Campo.Index].Value.ToString())
                {

                }
                else
                {
                    if (dtgvtabla.Rows[dtgvtabla.Rows.Count - 1].Index == item.Index)
                    {
                        store.AppendLine(string.Format($"{item.Cells[Campo.Index].Value.ToString()}=@{item.Cells[Campo.Index].Value.ToString()}"));
                    }
                    else
                    {
                        store.AppendLine(string.Format($"{item.Cells[Campo.Index].Value.ToString()}=@{item.Cells[Campo.Index].Value.ToString()},"));
                    }
                }
            }
            store.AppendLine(string.Format($"where {pk}=@{pk}"));
            store.AppendLine(String.Format($"set @Retorno= @@ROWCOUNT"));

            store.AppendLine("      end");



            store.AppendLine("      end");
            store.AppendLine("      end_proc:");


            return store.ToString();
        }

        public void garchivo (string Contenido, string nombre,string extencion="cs")
        {
            TextWriter archivo;

            archivo = new StreamWriter(string.Format($"{nombre}."+extencion));

            archivo.Write(Contenido);
            archivo.Close();

        }

        private void btngD_Click(object sender, EventArgs e)
        {
            string nombre = "M" + tbnombre.Text;
            string nombred = "M" + tbnombre.Text + ".Designer" ;

            garchivo(GDisenoclass(nombre), nombre);
            garchivo(GDdesignerClas(nombre,controlsIni(),controlsPub()), nombred);
            MessageBox.Show("Formulario listo");
        }

        private void btngCyD_Click(object sender, EventArgs e)
        {
            btnGcl_Click(sender,e);
            btngD_Click(sender,e);
        }

        private void btnanadir_Click(object sender, EventArgs e)
        {
            if (chkPK.Checked == true)
            {
                chkPK.Visible = false;
                chkPK.Checked = false;
                pk = tbcampo.Text;
            }
            dtgvtabla.Rows.Add(tbcampo.Text, CboTipo.Text);
        }

        private void btnGcl_Click(object sender, EventArgs e)
        {

            garchivo(Gclass(), tbnombre.Text + "s");
            MessageBox.Show("Clase listo");
        }

        private void btnGwfomG_Click(object sender, EventArgs e)
        {
            string nombre = "G" + tbnombre.Text;
            string nombred = "G" + tbnombre.Text + ".Designer";

            garchivo(GDisenoclass(nombre,list:true,control:false), nombre);
            garchivo(GDdesignerClas(nombre, controlsIni()+gridIni(), controlsPub()+gridpub()), nombred);
            MessageBox.Show("Formulario listo");
        }

        private void btnGwfomList_Click(object sender, EventArgs e)
        {
            string nombre = "L" + tbnombre.Text;
            string nombred = "L" + tbnombre.Text + ".Designer";
            
            garchivo(GDisenoclass(nombre,control:false,list:true), nombre);
            garchivo(GDdesignerClas(nombre, ListIni() + gridIni(), ListPub() + gridpub()), nombred);
            MessageBox.Show("Formulario listo");
        }

        private void btnGStoreProcedure_Click(object sender, EventArgs e)
        {
            garchivo(StoreProcedure(), string.Format($"sp_G{tbnombre.Text}"),"sql");
            MessageBox.Show("Procedure Listo");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            chkPK.Visible = true;
            tbcampo.Text = "";
            tbnombre.Text = "";
            dtgvtabla.Rows.Clear();
        }

    }
}
