using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_CodigoDPL
    {
        private N_Archivo archivo = new N_Archivo();
        public string Nombre_archivo;
        private N_Impresion impresora = new N_Impresion();

        public void ImpresionCodigoBarra(string guia, string fecha, string hora,string correlativo)
        {
            Nombre_archivo = "C:\\Temp\\EtiquetaTemp.txt";
            archivo.Nombre_archivo = Nombre_archivo;
            impresora.Archivo = Nombre_archivo;
            impresora.NuevaImpresion();
            impresora.Grabar(correlativo);
            impresora.Grabar(guia);
            impresora.Grabar(fecha);
            impresora.Grabar(hora);
            //RawPrinter.SendFileToPrinter("HPA4ECBA (HP Deskjet 3540 series)", Nombre_archivo);
        }
    }
}
