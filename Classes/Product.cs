using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Stock_Keeping_Application.Classes
{
    /// <summary>
    /// product data is going to be stored in this class
    /// </summary>

    public class Product
    {
        public List<MaterialData> materials { get; set; }
        public int number { get; set; }

        public Product()
        {
            materials = new List<MaterialData>();
            for (int i = 0; i < materials.Count; i++)
            {
                MaterialData temp = new MaterialData();
                temp.material = new Material("abcd", "deneme", 5);
                temp.required = 0;
                materials[i] = temp;
            }
        }

        public Product(List<MaterialData> mData)
        {
            materials = mData;
        }

        public bool AddMaterial(Material mat, int number)
        {
            bool hasMaterial = false;
            MaterialData temp = new MaterialData();
            temp.material = mat;
            temp.required = number;
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials.ElementAt(i).material == mat)
                {
                    materials.Add(temp);
                    hasMaterial = true;
                }
                else
                {
                    hasMaterial = false;
                }
            }
            return !hasMaterial;
        }

        public bool RemoveMaterial(Material mat)
        {
            bool hasMaterial = false;
            for (int i = 0; i < materials.Count; i++)
            {
                if (materials.ElementAt(i).material == mat)
                {
                    materials.RemoveAt(i);
                    hasMaterial = true;
                }
                else
                {
                    hasMaterial = false;
                }
            }
            return hasMaterial;
        }
    }
}
