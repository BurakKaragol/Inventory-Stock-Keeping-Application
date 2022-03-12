using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Stock_Keeping_Application
{
    /// <summary>
    /// This class is going to be used for:
    /// importing or exporting excell data
    /// </summary>
    public class ExcellHandler
    {
        string filePath = "";
        Excel.Application app;
        Excel.Workbook wb;
        Excel.Worksheet ws;

        public ExcellHandler(string name)
        {
            //open default file
        }

        public bool ImportFromFile()
        {
            filePath = GetPath();
            OpenFile(filePath);
            return true;
        }

        public void OpenFile(string fileName)
        {
            Console.WriteLine("Excel file opening in: " + fileName);
            app = new Excel.Application();
            Console.WriteLine("App: " + app.Name);
            wb = app.Workbooks.Open(filePath);
            Console.WriteLine("Workbook: " + wb.Name);
            ws = wb.Worksheets[1];
            Console.WriteLine("Worksheet: " + ws.Name);
            Console.WriteLine("Excel file opened");
        }

        public string GetPath()
        {
            string path = "";
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "Select file";
            fileDialog.InitialDirectory = @"c:\";
            fileDialog.Filter = "Excel Sheet(*.xlsx)|*.xlsx";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                path = fileDialog.FileName;
            }
            return path;
        }

        public bool CheckValid()
        {
            return true;
        }

        ~ExcellHandler()
        {
            CloseFile();
        }

        public bool ExportAsExcell()
        {
            filePath = GetPath();
            MessageBox.Show(filePath);
            return true;
        }

        public void CloseFile()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Marshal.ReleaseComObject(ws);
            wb.Close();
            Marshal.ReleaseComObject(wb);
            app.Quit();
            Marshal.ReleaseComObject(app);
            Console.WriteLine("Excel file closed");
        }
    }
}
