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
        string filePath = Application.StartupPath + "\\Inventory_Stock_Keeping_Application.xlsx";
        public bool isOpen = false;
        Excel.Application app;
        Excel.Workbook wb;
        Excel.Worksheet ws;
        public Excel.Range range;
        public int row = 0;
        public int column = 0;

        public ExcellHandler()
        {
            //open default file
            OpenFile(filePath);
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
            range = ws.UsedRange;
            row = range.Rows.Count;
            column = range.Columns.Count;
            Console.WriteLine("Excel file opened");
            isOpen = true;
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
            app = null;
            Console.WriteLine("Excel file closed");
            isOpen = false;
        }
    }
}
