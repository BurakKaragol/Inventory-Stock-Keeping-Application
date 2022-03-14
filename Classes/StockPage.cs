using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Inventory_Stock_Keeping_Application.Classes
{
    /// <summary>
    /// this class is going to be used for events on stock page
    /// </summary>
    public class StockPage
    {
        ComboBox.ObjectCollection cbElements;
        FormMaterial formMaterial;
        public static Material materialToAdd;
        static List<Material> materialList;
        string searchText;
        int selectedCboxItem = 0;
        int selectedIndex = 0;

        public StockPage(ComboBox.ObjectCollection elements)
        {
            cbElements = elements;
            formMaterial = new FormMaterial();
        }

        public bool ExcelToMaterial(Object[,] values)
        {
            int rows = values.GetLength(0);
            int colmns = values.GetLength(1);
            for (int i = 2; i <= rows; i++)
            {
                materialList.Append(LogMaterial(values[i, 2].ToString(), values[i, 3].ToString(),
                    values[i, 4].ToString(), values[i, 5].ToString(), values[i, 7].ToString(),
                    values[i, 8].ToString(), values[i, 9].ToString(), values[i, 10].ToString()));
            }
            return true;
        }

        public Material LogMaterial(string stockCode, string name, string number, string stack = "1",
            string type = "not-specified", string price = "0.0f", string from = "unknown", string date = "empty")
        {
            if (stockCode != null && name != null && number != null)
            {
                stack = stack == null ? "1" : stack;
                if (Convert.ToInt16(stack) >= 1)
                {
                    if (type == null)
                    {
                        type = "not - specified";
                    }
                    else if (price == null)
                    {
                        price = "0.0f";
                    }
                    else if (from == null)
                    {
                        from = "unknown";
                    }
                    else if (date == null)
                    {
                        date = "empty";
                    }
                    Material temp = new Material(stockCode, name, Convert.ToInt16(number),
                        Convert.ToInt16(stack), type, float.Parse(price), from, date);
                    return temp;
                }
                else
                {
                    MessageBox.Show("Stack degeri 0 veya negatif olamaz urun stogu yoksa Number'i duzenle");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Stock Code / Name / Number alanlari bos birakilamaz");
                return null;
            }
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

        public static void AddNewMaterial()
        {
            //materialList.Append(materialToAdd);
        }

        public void EditSelected()
        {
            formMaterial.SetTexts(materialList[selectedIndex].StockCode, materialList[selectedIndex].Name,
                materialList[selectedIndex].Number.ToString(), materialList[selectedIndex].Stack.ToString(),
                materialList[selectedIndex].Type, materialList[selectedIndex].Price.ToString(),
                materialList[selectedIndex].From, materialList[selectedIndex].Date);
            formMaterial.Show();
        }

        public void AddComponent()
        {
            formMaterial.ClearTexts();
            formMaterial.Show();
        }

        public void RemoveComponent()
        {
            Material material = materialList[selectedIndex];
            if (materialList.Contains(material))
            {
                materialList.Remove(material);
            }
            else
            {
                // material already exist
            }
        }

        public void SearchText(string txt)
        {
            searchText = txt;
            bool isMatch = Search();
        }

        private bool Search()
        {
            // searching algo
            return true;
        }

        public void SelectCbox(int idx)
        {
            selectedCboxItem = idx;
        }

        public void SelectList(int idx)
        {
            selectedIndex = idx;
        }

        public void ShowItems()
        {
            for (int i = 0; i < cbElements.Count; i++)
            {
                MessageBox.Show(cbElements[i].ToString());
            }
        }
    }
}
