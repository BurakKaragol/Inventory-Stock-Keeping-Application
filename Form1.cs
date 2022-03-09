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
        static List<Material> materialList;
        static StockPage stockPageController;
        ExcellHandler excellHandler;
        public static Material materialToAdd;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            excellHandler = new ExcellHandler("database");
            stockPageController = new StockPage(searchFilterComboBox.Items, materialList);
        }

        public static void AddNewMaterial()
        {
            //materialList.Append(materialToAdd);
            MessageBox.Show(materialToAdd.Id.ToString());
            MessageBox.Show(materialToAdd.StockCode);
            MessageBox.Show(materialToAdd.Name);
            MessageBox.Show(materialToAdd.Number.ToString());
            MessageBox.Show(materialToAdd.Stack.ToString());
            MessageBox.Show(materialToAdd.TotalNumber.ToString());
            MessageBox.Show(materialToAdd.Type);
            MessageBox.Show(materialToAdd.Price.ToString());
            MessageBox.Show(materialToAdd.From);
            MessageBox.Show(materialToAdd.Date);
    }

        public static bool CheckExist(string stockCode)
        {
            for (int i = 0; i < materialList.Count; i++)
            {
                if (stockCode == materialList[i].StockCode)
                {
                    return true;
                }
            }
            return false;
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

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.ButtonShadow;
        }
    }
}
