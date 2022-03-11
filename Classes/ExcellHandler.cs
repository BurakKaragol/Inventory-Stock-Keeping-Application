using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Stock_Keeping_Application
{
    /// <summary>
    /// This class is going to be used for:
    /// importing or exporting excell data
    /// </summary>
    public class ExcellHandler
    {
        public ExcellHandler(string name)
        {
            //excell dosyasini ac
        }

        public bool ImportFromFile()
        {
            return true;
        }

        public bool ExportAsExcell()
        {
            return true;
        }

        ~ExcellHandler()
        {
            //excell dosyasin kapat
        }
    }
}
