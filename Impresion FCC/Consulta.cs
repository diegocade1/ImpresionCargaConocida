using C_Entidades;
using C_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impresion_FCC
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            N_Etiqueta etiqueta1 = new N_Etiqueta();
            List<E_Etiqueta> lista = new List<E_Etiqueta>();
            DateTime fecha1 = DateTime.ParseExact(dtpComienzo.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string fechaInicio = fecha1.ToString("yyyy-MM-dd");
            DateTime fecha2 = DateTime.ParseExact(dtpFin.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            string fechaFin = fecha2.ToString("yyyy-MM-dd");
            lista = etiqueta1.ListaEtiquetasFecha(fechaInicio,fechaFin);
            if (lista !=null)
            {
                dgvLista.DataSource = lista;
            }
            else
            {
                MessageBox.Show(etiqueta1.Mensaje);
            }
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            dtpComienzo.Format = DateTimePickerFormat.Custom;
            dtpComienzo.CustomFormat = "dd-MM-yyyy";

            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dd-MM-yyyy";
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if(btnFiltro.Text.ToLower() != "fecha")
            {
                panelGuia.Visible = false;
                btnFiltro.Text = "Fecha";
            }
            else
            {
                Point locationOnForm = lblBuscar.FindForm().PointToClient(
                lblBuscar.Parent.PointToScreen(lblBuscar.Location));
                panelGuia.Top = Convert.ToInt32(locationOnForm.Y.ToString())-16;
                panelGuia.Left = Convert.ToInt32(locationOnForm.X.ToString());
                panelGuia.Visible = true;
                btnFiltro.Text = "Guia";
            }
        }

        private void btnBuscarGuia_Click(object sender, EventArgs e)
        {
            N_Etiqueta etiqueta1 = new N_Etiqueta();
            List<E_Etiqueta> lista = new List<E_Etiqueta>();
            string guia = txtGuia.Text;

            lista = etiqueta1.ListaEtiquetasGuia(guia);
            if (lista != null)
            {
                dgvLista.DataSource = lista;
            }
            else
            {
                MessageBox.Show(etiqueta1.Mensaje);
            }
        }
    }
}
