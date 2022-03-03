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
    public class StockPage
    {
        ComboBox.ObjectCollection cbElements;
        List<Material> materialList;
        string searchText;
        int selectedIndex = 0;
        int listIndex = 0;

        public StockPage(ComboBox.ObjectCollection elements)
        {
            cbElements = elements;
            materialList = new List<Material>();
        }

        public void EditSelected()
        {
            // new form
        }

        public void AddComponent()
        {
            // new form
            Material material = materialList[listIndex];
            if (!materialList.Contains(material))
            {
                materialList.Add(material);
            }
            else
            {
                // material already exist
            }
        }

        public void RemoveComponent()
        {
            Material material = materialList[listIndex];
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
            selectedIndex = idx;
        }

        public void SelectList(int idx)
        {
            listIndex = idx;
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
