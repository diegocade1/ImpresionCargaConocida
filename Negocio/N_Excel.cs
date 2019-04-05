using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class N_Excel
    {
        private string _mensaje;

        public string Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value; }
        }

        public bool ExportarExcel(DataTable grilla)
        {
            try
            {
                //Exportar a Excel
                string folderPath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                folderPath = folderPath + @"\Impresion Folio CC Excel\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(grilla, "ImpresionFCC");
                    wb.SaveAs(folderPath + "excel_impresionfcc_" + DateTime.Now.ToString("dd-MM-yyyy HH_mm_") + ".xlsx");
                    _mensaje = "Archivo generado en: " + folderPath;
                }
                return true;
            }
            catch(Exception ex)
            {
                _mensaje = ex.Message;
                return false;
            }

        }
    }
}
