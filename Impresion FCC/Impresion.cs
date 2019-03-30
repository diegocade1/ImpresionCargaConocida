using System;
using C_Entidades;
using C_Negocio;
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
    public partial class Impresion : Form
    {
        public Impresion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Impresion_Load(object sender, EventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd-MM-yyyy";

            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string guia = txtGuia.Text;
            DateTime fecha = Convert.ToDateTime(dtpFecha.Text);
            string fechaString = fecha.ToString("yyyy-MM-dd");
            string hora = dtpHora.Text;
            int cant = Convert.ToInt32(txtCantidad.Text);

            N_Etiqueta etiqueta1 = new N_Etiqueta();
            E_Etiqueta etiqueta2 = new E_Etiqueta()
            {
                Correlativo = 0,
                Guia_aerea = guia,
                Fecha = fechaString,
                Hora = hora
            };
            for(int i = 0; i<cant;i++)
            {
                if (!etiqueta1.CrearEtiqueta(etiqueta2))
                {
                    MessageBox.Show(etiqueta1.Mensaje);
                    break;
                }
                else
                {
                    //Imprimir Etiqueta
                }
            }           
        }
    }
}
