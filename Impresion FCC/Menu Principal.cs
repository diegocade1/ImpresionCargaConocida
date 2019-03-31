using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresion_FCC
{
    public partial class mdiMenu_Principal : Form
    {
        public mdiMenu_Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void impresionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impresion frmObj = new Impresion();
            frmObj.MdiParent = this;
            frmObj.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta frmObj = new Consulta();
            frmObj.MdiParent = this;
            frmObj.Show();
        }
    }
}
