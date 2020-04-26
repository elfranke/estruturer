using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructurer
{
    public partial class DesdeTablaATipo : Form
    {


        string pk = "";
        string nombre = "";
        public DesdeTablaATipo()
        {
            InitializeComponent();
        }

        public string obtenerNombre(string old)
        {
            string n = "";
            bool listo = false;

            foreach (char item in old.ToCharArray())
            {
                if (item == char.Parse("("))
                {
                    listo = true;
                }

                if (listo)
                {
                        n += item;
                }
                else
                {
                    if (item == char.Parse("[") || item == char.Parse("]"))
                    {
                    }
                    else
                    {
                        nombre += item;
                    }
                }

            }
            return n;
        }

        public string nuevaCadena(string old)
        {
            string n = "";
            bool number = false;
            foreach (char item in old.ToCharArray())
            {
                bool ag = true;
                switch (item.ToString())
                {
                    case "[":
                    case "]":
                    case "(":
                    case ")":
                    case "":
                    case " ":
                        n += " ";
                        ag = false;
                        number = false;
                        break;

                    case ",":
                        if (number)
                        {
                            number = false;
                            ag = false;
                        }
                        else
                        {
                            ag = true;
                        }
                    
                        break;


                }
                   
                if(ag)
                {
                    if (!char.IsNumber(item))
                    {
                        n += item;
                    }
                    else
                    {
                        number = true;
                    }
                }
            }

            return n;

        }

        public string Separar(string old)
        {
            string n = "";

            bool fs = true;
            string[] linea = old.Split(char.Parse(" "));
            foreach (string world in linea)
            {
                switch (world.Trim())
                {
                    case "not":
                    case "null":
                    case "notnull":
                    case "max":
                        fs = false;
                        break;

                    case "not,":
                    case "null,":
                        n += ",";
                        fs = false;
                        break;

                    case "identity":
                    case "identity,":
                        string[] vs = n.Trim().Split(char.Parse(" "));
                        pk = vs[0];
                        fs = false;
                        break;

                    case " ":
                    case "":
                        n += " ";
                        fs = false;
                        break;


                }
                    if (fs)
                    {
                        n += world.ToString();

                    }
                
                fs = true;
            }



            return n;

        }

        public void agregaraldtgv (string old)
        {
            string[] linea = old.Split(char.Parse(","));

            foreach (string item in linea)
            {
                string[] world = item.Split(char.Parse(" "));
                string tipo = world[1];
                switch (tipo)
                {
                    case "nvarchar":
                    case "varchar":
                        tipo = "string";
                        break;
                    case "int":
                        tipo = "int";
                        break;
                    case "datetime":
                        tipo = "DateTime";
                        break;
                    case "bit":
                        tipo = "bool";
                        break;
                    case "float":
                        tipo = "decimal";
                        break;
                }

                dtgvtabla.Rows.Add(world[0], tipo);

            }



        }

        public string arregalarespacios(string old)
        {
            string n = "";
            bool space = false;
            bool fs = true;
            foreach (char item in old.ToCharArray())
            {

                switch (item.ToString())
                {
                    case"":
                    case" ":
                        if (fs)
                            goto salida;
                                                
                        if (!space)
                             n += " ";
                        space = true;
                        break;
                    case ",":
                        n += item;
                        space = true;
                        break;
                    case "13":
                        salida:
                        space = true;
                        break;
                    default:
                        space = false;
                        break;
                }


                if (!space)
                {
                    n += item;

                    space = false;
                }
                fs = false;

            }

            return n;
        }

        private void btnprocesar_Click(object sender, EventArgs e)
        {
            textBox1.Text = obtenerNombre(textBox1.Text.ToLower().Trim());
            textBox1.Text = nuevaCadena(textBox1.Text);
            textBox1.Text = Separar(textBox1.Text);
            textBox1.Text = arregalarespacios(textBox1.Text);
            agregaraldtgv(textBox1.Text);

            Main m = new Main(pk,dtgvtabla,nombre);
            m.ShowDialog();
            this.Close();
        }
    }
}
