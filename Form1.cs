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
    /// On development for Rezonans Elektronik A.S.
    /// http://www.rezonanselektronik.net/
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

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            excellHandler = new ExcellHandler("database");
            stockPageController = new StockPage(searchFilterComboBox.Items);
        }

        #region Funcitons

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

        private void upperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void upperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                System.Drawing.Point dif = System.Drawing.Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = System.Drawing.Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void upperPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            ToggleMaximize();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upperPanel_DoubleClick(object sender, EventArgs e)
        {
            ToggleMaximize();
        }

        private void searchFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockPageController.SelectCbox(searchFilterComboBox.SelectedIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            stockPageController.SearchText(textBox1.Text);
        }

        private void editComponentButton_Click(object sender, EventArgs e)
        {
            stockPageController.EditSelected();
        }

        private void removeComponentButton_Click(object sender, EventArgs e)
        {
            stockPageController.RemoveComponent();
        }

        private void addComponentButton_Click(object sender, EventArgs e)
        {
            stockPageController.AddComponent();
        }

        private void componentListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            stockPageController.SelectList(componentListbox.SelectedIndex);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.ButtonShadow;
        }

        #endregion
    }
}
