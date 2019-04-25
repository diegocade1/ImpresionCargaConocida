using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

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

        private void mdiMenu_Principal_Load(object sender, EventArgs e)
        {
            N_Conexion.setConnectionString(ConfigurationManager.ConnectionStrings["MiConexion"].ConnectionString);
            NameValueCollection settings = ConfigurationManager.GetSection("CoordenadasGroup/Coordenada") as NameValueCollection;

            if (settings != null)
            {
                foreach (string key in settings.AllKeys)
                {
                    Console.Write(key + ": " + settings[key]);
                    if(key.ToLower().Equals("x"))
                    {
                        N_CodigoZPL.axisX = Convert.ToInt32(settings[key]);
                    }
                    else
                    {
                        N_CodigoZPL.axisY = Convert.ToInt32(settings[key]);
                    }
                }
            }
        }
    }
}
