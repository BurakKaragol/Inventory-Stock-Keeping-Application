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
    public partial class FormMaterial : Form
    {
        bool isDragging = false;
        System.Drawing.Point dragCursorPoint;
        System.Drawing.Point dragFormPoint;

        public FormMaterial()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        #region Functions

        // logs the material values if it's valid
        private void LogMaterial(bool isContinue = false)
        {
            if (/*Form1.CheckExist(stockCodeTextbox.Text)*/false)
            {
                MessageBox.Show("Materyal zaten var");
            }
            else
            {
                Log();
                if (isContinue)
                {
                    ClearTexts();
                }
                else
                {
                    this.Close();
                }
            }
        }

        // logging function
        private void Log()
        {
            if (stockCodeTextbox.Text != null && nameTextbox.Text != null && numberTextbox.Text != null)
            {
                if (Convert.ToInt16(stackTextbox.Text) >= 1)
                {
                    if (typeTextbox.Text == null)
                    {
                        typeTextbox.Text = "not - specified";
                    }
                    else if (priceTextbox.Text == null)
                    {
                        priceTextbox.Text = "0";
                    }
                    else if (fromTextbox.Text == null)
                    {
                        fromTextbox.Text = "unknown";
                    }
                    else if (dateTextbox.Text == null)
                    {
                        dateTextbox.Text = "empty";
                    }

                    StockPage.materialToAdd = new Material(stockCodeTextbox.Text, nameTextbox.Text,
                        Convert.ToInt16(numberTextbox.Text), Convert.ToInt16(stackTextbox.Text),
                        typeTextbox.Text, float.Parse(priceTextbox.Text), fromTextbox.Text,
                        dateTextbox.Text);
                    StockPage.AddNewMaterial();
                }
                else
                {
                    MessageBox.Show("Stack degeri 0 veya negatif olamaz urun stogu yoksa Number'i duzenle");
                }
            }
            else
            {
                MessageBox.Show("Stock Code / Name / Number alanlari bos birakilamaz");
            }
        }

        // set values of the material for editing
        public void SetTexts(string stockCode, string name, string number, string stack = null,
            string type = null, string price = null, string from = null, string date = null)
        {
            stockCodeTextbox.Text = stockCode;
            nameTextbox.Text = name;
            numberTextbox.Text = number;
            stackTextbox.Text = stack;
            typeTextbox.Text = type;
            priceTextbox.Text = price;
            fromTextbox.Text = from;
            dateTextbox.Text = date;
        }

        // clears the values for adding another component
        public void ClearTexts()
        {
            stockCodeTextbox.Text = null;
            nameTextbox.Text = null;
            numberTextbox.Text = null;
            stackTextbox.Text = null;
            typeTextbox.Text = null;
            priceTextbox.Text = null;
            fromTextbox.Text = null;
            dateTextbox.Text = null;
        }

        #endregion

        #region ProgramGenerated

        // hide this panel
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // change button color on hover
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        // change button color on hover
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = SystemColors.ButtonShadow;
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

        // for logging the values and closing form
        private void addButton_Click(object sender, EventArgs e)
        {
            LogMaterial(false);
        }

        // for logging values and continuing to add
        private void addContinueButton_Click(object sender, EventArgs e)
        {
            LogMaterial(true);
        }

        // for cancelling active log 
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion
    }
}
