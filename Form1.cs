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
        static StockPage stockPageController;
        ExcellHandler excellHandler;
        OthersPage othersPage;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            excellHandler = new ExcellHandler();
            othersPage = new OthersPage();
            stockPageController = new StockPage(searchFilterComboBox.Items);
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

        #endregion

        #region ProgramGenerated

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

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
