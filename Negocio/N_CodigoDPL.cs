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
        public static int axisX { get; set; }
        public static int axisY { get; set; }

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

            /*
            impresora.Grabar("n");
            impresora.Grabar("M1477");
            impresora.Grabar("O0220");
            impresora.Grabar("d");
            impresora.Grabar("D");
            impresora.Grabar("L");
            impresora.Grabar("D11");
            impresora.Grabar("ySPM");
            impresora.Grabar("A2");
            impresora.Grabar("1911"+"A24"+"05230304"+correlativo);
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
            */

            /*
                        X     Y
              1X11 000 0108 0173 L131001           Linea
                 (+)    X     Y                  
              1911 A18 0199 0096 CARGA CONOCIDA    Label
  
              '(+)' = Tamaño letra 
            */
            impresora.Grabar("KS15");
            impresora.Grabar("n");
            impresora.Grabar("M1477");
            impresora.Grabar("O0220");
            impresora.Grabar("d");
            impresora.Grabar("D");
            impresora.Grabar("L");
            impresora.Grabar("D11");
            impresora.Grabar("H20");
            impresora.Grabar("ySPM");
            impresora.Grabar("A2");
            impresora.Grabar("1911"+"A36"+(0504 + axisY).ToString().PadLeft(4,'0') + (0277 + axisX).ToString().PadLeft(4, '0') + correlativo);
            impresora.Grabar("1911"+"A18"+(0199 + axisY).ToString().PadLeft(4, '0') + (0096 + axisX).ToString().PadLeft(4, '0') + "CARGA CONOCIDA");
            impresora.Grabar("1911"+"A10"+(0182 + axisY).ToString().PadLeft(4, '0') + (0099 + axisX).ToString().PadLeft(4, '0') + "N DE ACREDITACION: AC 04/2019");
            impresora.Grabar("1X11000"+(0108 + axisY).ToString().PadLeft(4, '0') + (0173 + axisX).ToString().PadLeft(4, '0') + "L131001");
            impresora.Grabar("1911"+"A10"+(0113 + axisY).ToString().PadLeft(4, '0') + (0115 + axisX).ToString().PadLeft(4, '0') + "FECHA:");
            impresora.Grabar("1X11000"+(0080 + axisY).ToString().PadLeft(4, '0') + (0173 + axisX).ToString().PadLeft(4, '0') + "L131001");
            impresora.Grabar("1911"+"A10"+(0085 + axisY).ToString().PadLeft(4, '0') + (0119 + axisX).ToString().PadLeft(4, '0') + "HORA:");
            impresora.Grabar("1X11000"+(0140 + axisY).ToString().PadLeft(4, '0') + (0173 + axisX).ToString().PadLeft(4, '0') + "L131001");
            impresora.Grabar("1911"+"A24"+(0133 + axisY).ToString().PadLeft(4, '0') + (0203 + axisX).ToString().PadLeft(4, '0') + guia);
            impresora.Grabar("1911"+"A18"+(0106 + axisY).ToString().PadLeft(4, '0') + (0177 + axisX).ToString().PadLeft(4, '0') + fecha);
            impresora.Grabar("1911"+"A18"+(0078 + axisY).ToString().PadLeft(4, '0') + (0188 + axisX).ToString().PadLeft(4, '0') + hora);
            impresora.Grabar("1X11000"+(0055 + axisY).ToString().PadLeft(4, '0') + (0131 + axisX).ToString().PadLeft(4, '0') + "L160016");
            impresora.Grabar("A1");
            impresora.Grabar("1911"+"A10"+(0055 + axisY).ToString().PadLeft(4, '0') + (0133 + axisX).ToString().PadLeft(4, '0') + "" + "CARGO NET CENTER" + "");
            impresora.Grabar("Q0001");
            impresora.Grabar("E");

            RawPrinter.SendFileToPrinter("DatamaxDPL", Nombre_archivo);
        }

        public void ImpresionCodigoBarraPrueba(string guia, string fecha, string hora, string correlativo)
        {
            Nombre_archivo = "C:\\Temp\\EtiquetaTemp.txt";
            archivo.Nombre_archivo = Nombre_archivo;
            impresora.Archivo = Nombre_archivo;
            impresora.NuevaImpresion();

            /*
                        X     Y
              1X11 000 0108 0173 L131001           Linea
                 (+)    X     Y                  
              1911 A18 0199 0096 CARGA CONOCIDA    Label
  
              '(+)' = Tamaño letra 
            */
            impresora.Grabar("n");
            impresora.Grabar("M1477");
            impresora.Grabar("d");
            impresora.Grabar("L");
            impresora.Grabar("D11");
            impresora.Grabar("H30");
            impresora.Grabar("R0000");
            impresora.Grabar("ySU8");
            impresora.Grabar("A2");
            impresora.Grabar("1911S00"+ "0504" + "0277" + "P024P024"+correlativo);
            impresora.Grabar("1911S0002140073P022P024CARGA CONOCIDA");
            impresora.Grabar("1911S0001240082P018P012FECHA:");
            impresora.Grabar("1911S0000850105P020P013HORA:");
            impresora.Grabar("1X1100000720146L139004");
            impresora.Grabar("1X1100001500128L193004");
            impresora.Grabar("1X1100101120130P0010001010801300108030901120309");
            impresora.Grabar("1X1100000500129L154023");
            impresora.Grabar("A1");
            impresora.Grabar("1911S0000540131P013P012"+ @"CARGO NET CENTER");
            impresora.Grabar("A2");
            impresora.Grabar("1911S0001210155P026P023"+fecha);
            impresora.Grabar("A2");
            impresora.Grabar("1911S0000830188P022P032"+hora);
            impresora.Grabar("1911S0001530164P024P046"+guia);
            impresora.Grabar("1911S0001850039P023P016N° DE ACREDITACION: AC 04/2019");
            impresora.Grabar("1911S0001540043P018P012No CONTROL:");
            impresora.Grabar("Q0001");
            impresora.Grabar("E");

            RawPrinter.SendFileToPrinter("DatamaxDPL", Nombre_archivo);
        }
    }
}
