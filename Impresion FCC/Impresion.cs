using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Negocio;
using Entidad;

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

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " ";
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.CustomFormat = " ";
        }

        private void Limpiar()
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = " ";
            dtpHora.Format = DateTimePickerFormat.Custom;
            dtpHora.CustomFormat = " ";
            txtGuia.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtCliente.Text = string.Empty;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGuia.Text) || string.IsNullOrWhiteSpace(txtGuia.Text))
            {
                MessageBox.Show("Ingrese Guia", "Agregar");
                return;
            }
            if (txtGuia.Text.Length < 4)
            {
                MessageBox.Show("Guia debe tener minimo 4 numeros", "Agregar");
                return;
            }
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Ingrese Cliente", "Agregar");
                return;
            }
            if (string.IsNullOrEmpty(dtpFecha.Text) || string.IsNullOrWhiteSpace(dtpFecha.Text))
            {
                MessageBox.Show("Ingrese Fecha", "Agregar");
                return;
            }
            if (string.IsNullOrEmpty(dtpHora.Text) || string.IsNullOrWhiteSpace(dtpHora.Text))
            {
                MessageBox.Show("Ingrese Hora", "Agregar");
                return;
            }
            if (string.IsNullOrEmpty(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Ingrese Cantidad", "Agregar");
                return;
            }
            string guia = txtGuia.Text;
            string cliente = txtCliente.Text;
            DateTime fecha = dtpFecha.Value;
            string fechaString = fecha.ToString("yyyy-MM-dd");
            //string hora = DateTime.ParseExact(dtpHora.Text, "h:mm:ss tt", CultureInfo.InvariantCulture).ToString("HH:mm:ss");
            //string hora = DateTime.ParseExact(dtpHora.Text, "HH:mm:ss", CultureInfo.InvariantCulture).ToString("HH:mm:ss");            
            string hora = dtpHora.Value.ToString("HH:mm:ss");
            DateTime hora2 = dtpHora.Value;
            int cant = Convert.ToInt32(txtCantidad.Text);

            N_Etiqueta etiqueta1 = new N_Etiqueta();
            E_Etiqueta etiqueta2 = new E_Etiqueta()
            {
                Correlativo = 0,
                Guia_aerea = guia,
                Fecha = fechaString,
                Hora = hora,
                Cliente = cliente
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
                    N_CodigoDPL codigo = new N_CodigoDPL();
                    string substrng = etiqueta2.Guia_aerea.Substring(etiqueta2.Guia_aerea.Length-4);
                    //codigo.ImpresionCodigoBarra(substrng, fecha.ToString("dd-MM-yyyy"), etiqueta2.Hora, etiqueta2.Correlativo.ToString());
                    codigo.ImpresionCodigoBarraV2(substrng, fecha.ToString("dd-MM-yyyy"), hora2.ToString("HH:mm"),etiqueta2.Correlativo.ToString());
                    Limpiar();
                }
            }           
        }

        private void dtpFecha_MouseDown(object sender, MouseEventArgs e)
        {
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dd-MM-yyyy";
        }

        private void dtpHora_MouseDown(object sender, MouseEventArgs e)
        {
            dtpHora.Format = DateTimePickerFormat.Time;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
