using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
