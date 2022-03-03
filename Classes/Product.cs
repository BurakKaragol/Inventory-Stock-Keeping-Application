using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material = Inventory_Stock_Keeping_Application.Classes.Material;

namespace Inventory_Stock_Keeping_Application.Classes
{
    struct MaterialData
    {
        public Material material { get; set; }
        public int required { get; set; }
    }

    internal class Product
    {
        public List<MaterialData> materials;
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

        public Product(Material[] mats, int[] nums)
        {
            materials = new List<MaterialData>();
            for (int i = 0; i < mats.Length; i++)
            {
                MaterialData temp = new MaterialData();
                temp.material = mats[i];
                temp.required = nums[i];
                materials[i] = temp;
            }
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
