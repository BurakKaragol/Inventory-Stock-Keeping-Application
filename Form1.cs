using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Material = Inventory_Stock_Keeping_Application.Classes.Material;
using Product = Inventory_Stock_Keeping_Application.Classes.Product;
using StockPage = Inventory_Stock_Keeping_Application.Classes.StockPage;

namespace Inventory_Stock_Keeping_Application
{
    public partial class Form1 : Form
    {
        bool isMaximized = false;
        bool isDragging = false;
        System.Drawing.Point dragCursorPoint;
        System.Drawing.Point dragFormPoint;
        List<Product> productList;
        StockPage stockPageController;
        ExcellHandler excell;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            excell = new ExcellHandler("database");
            stockPageController = new StockPage(searchFilterComboBox.Items);
        }

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
    }
}
