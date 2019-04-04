using RawPrinterDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
            /*
            impresora.Grabar(correlativo);
            impresora.Grabar(guia);
            impresora.Grabar(fecha);
            impresora.Grabar(hora);
            */
            impresora.Grabar("n");
            impresora.Grabar("M1477");
            impresora.Grabar("O0220");
            impresora.Grabar("d");
            impresora.Grabar("D");
            impresora.Grabar("L");
            impresora.Grabar("D11");
            impresora.Grabar("ySPM");
            impresora.Grabar("A2");
            impresora.Grabar("1911A2405230304"+correlativo);
            impresora.Grabar("1911A1802480102CARGA CONOCIDA");
            impresora.Grabar("1911A1002330105N DE ACREDITACION: AC 04/2019");
            impresora.Grabar("1X1100001610180L131001");
            impresora.Grabar("1911A1001670121FECHA:");
            impresora.Grabar("1X1100001260180L131001");
            impresora.Grabar("1911A1001320125HORA:");
            impresora.Grabar("1X1100001980180L131001");
            impresora.Grabar("1911A2401920209"+guia);
            impresora.Grabar("1911A1801600183"+fecha);
            impresora.Grabar("1911A1801250214"+hora);
            impresora.Grabar("1X1100000910137L160016");
            impresora.Grabar("A1");
            impresora.Grabar("1911A1000910138"+""+"CARGO NET CENTER"+"");
            impresora.Grabar("Q0001");
            impresora.Grabar("E");
            RawPrinter.SendFileToPrinter("DatamaxDPL", Nombre_archivo);
        }
    }
}
