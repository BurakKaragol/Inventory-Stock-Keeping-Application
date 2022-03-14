using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory_Stock_Keeping_Application.Classes;

namespace Inventory_Stock_Keeping_Application
{
    /// <summary>
    /// main form of the application
    /// can access and edit material and product lists
    /// calculate required parts and export as list
    /// see how many parts you can produce with your existing stock
    /// </summary>
    public partial class Form1 : Form
    {
        bool isMaximized = false;
        bool isDragging = false;
        System.Drawing.Point dragCursorPoint;
        System.Drawing.Point dragFormPoint;
        List<Product> productList;
        public static StockPage stockPageController;
        ExcellHandler excellHandler;
        OthersPage othersPage;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            othersPage = new OthersPage();
            stockPageController = new StockPage(searchFilterComboBox.Items);
            excellHandler = new ExcellHandler();
            materialGridView.ColumnCount = 10;
            materialGridView.RowCount = 1;
            materialGridView.Columns[0].Name = "ID";
            materialGridView.Columns[1].Name = "STOCK CODE";
            materialGridView.Columns[2].Name = "NAME";
            materialGridView.Columns[3].Name = "NUMBER";
            materialGridView.Columns[4].Name = "STACK";
            materialGridView.Columns[5].Name = "TOTAL NUMBER";
            materialGridView.Columns[6].Name = "TYPE";
            materialGridView.Columns[7].Name = "PRICE";
            materialGridView.Columns[8].Name = "FROM";
            materialGridView.Columns[9].Name = "DATE";
        }

        #region Funcitons

        // toggles fullscreen
        public void ToggleMaximize()
        {
            if (isMaximized)
            {
                Console.WriteLine("normal");
                this.WindowState = FormWindowState.Normal;
                isMaximized = false;
            }
            else
            {
                Console.WriteLine("maximize");
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
        }

        public void MaterialToDataTable(List<Material> mList)
        {
            if (mList.Count != 0)
            {
                materialGridView.ColumnCount = excellHandler.column;
                materialGridView.RowCount = excellHandler.row - 1;
                for (int i = 2; i <= excellHandler.row; i++)
                {
                    for (int j = 1; j <= materialGridView.ColumnCount; j++)
                    {
                        var temp = excellHandler.range.Cells[i, j].Value2;
                        if (temp != null)
                        {
                            string temp2 = temp.ToString();
                            if (temp2 != "" || temp2 != null)
                            {
                                materialGridView.Rows[i - 2].Cells[j - 1].Value = temp2;
                            }
                        }
                    }
                }
            }
        }

        public void ExcelToDataTable()
        {
            if (excellHandler.isOpen)
            {
                materialGridView.ColumnCount = excellHandler.column;
                materialGridView.RowCount = excellHandler.row - 1;
                for (int i = 2; i <= excellHandler.row; i++)
                {
                    for (int j = 1; j <= materialGridView.ColumnCount; j++)
                    {
                        var temp = excellHandler.range.Cells[i, j].Value2;
                        if (temp != null)
                        {
                            string temp2 = temp.ToString();
                            if (temp2 != "" || temp2 != null)
                            {
                                materialGridView.Rows[i - 2].Cells[j - 1].Value = temp2;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region ProgramGenerated

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (excellHandler.isOpen)
            {
                MessageBox.Show(excellHandler.row.ToString());
                MessageBox.Show(excellHandler.column.ToString());
            }
        }

        // for dragging the form
        private void upperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        // for dragging the form
        private void upperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                System.Drawing.Point dif = System.Drawing.Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = System.Drawing.Point.Add(dragFormPoint, new Size(dif));
            }
        }

        // for dragging the form
        private void upperPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        // minimize form
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // toggle fullscreen
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            ToggleMaximize();
        }

        //exit application
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // toggle fullscreen
        private void upperPanel_DoubleClick(object sender, EventArgs e)
        {
            ToggleMaximize();
        }

        // set the searching filter type
        private void searchFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockPageController.SelectCbox(searchFilterComboBox.SelectedIndex);
        }

        // search and show automatically
        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            stockPageController.SearchText(searchTextbox.Text);
        }

        // set the parameters and open editing form
        private void editComponentButton_Click(object sender, EventArgs e)
        {
            stockPageController.EditSelected();
        }

        // delete the selected component
        private void removeComponentButton_Click(object sender, EventArgs e)
        {
            stockPageController.RemoveComponent();
        }

        // add new component
        private void addComponentButton_Click(object sender, EventArgs e)
        {
            stockPageController.AddComponent();
        }

        // set close button color on hover
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        // set close button color on hover
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.ButtonShadow;
        }

        // import existing data
        private void importExcellButton_Click(object sender, EventArgs e)
        {
            excellHandler.ImportFromFile();
        }

        // export data from application
        private void exportExcellButton_Click(object sender, EventArgs e)
        {
            excellHandler.ExportAsExcell();
        }

        ~Form1()
        {
            excellHandler = null;
            Console.WriteLine("application quit");
        }

        #endregion
    }
}
