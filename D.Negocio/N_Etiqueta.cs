using C_Entidades;
using C_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Negocio
{
    public class N_Etiqueta
    {
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public bool CrearEtiqueta(E_Etiqueta etiqueta1)
        {
            D_Etiqueta etiqueta2 = new D_Etiqueta();
            etiqueta2.Etiqueta = etiqueta1;
            if(!etiqueta2.CrearEtiqueta())
            {
                _mensaje = etiqueta2.Mensaje;
                return false;
            }
            else
            {
                _mensaje = "Etiqueta creada";
                return true;
            }
        }

        public List<E_Etiqueta> ListaEtiquetasFecha(string inicio, string fin)
        {
            D_Etiqueta etiqueta2 = new D_Etiqueta();
            List<E_Etiqueta> temp = new List<E_Etiqueta>();
            temp = etiqueta2.ListaEtiquetasFecha(inicio, fin);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }

        public List<E_Etiqueta> ListaEtiquetasGuia(string guia)
        {
            D_Etiqueta etiqueta2 = new D_Etiqueta();
            List<E_Etiqueta> temp = new List<E_Etiqueta>();
            temp = etiqueta2.ListaEtiquetasGuia(guia);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                _mensaje = etiqueta2.Mensaje;
                return null;
            }
        }
    }
}
