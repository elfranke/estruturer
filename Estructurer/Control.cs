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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void desdeCeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.ShowDialog();
        }

        private void desdeCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesdeTablaATipo tabla = new DesdeTablaATipo();
            tabla.ShowDialog();

        }
    }
}
