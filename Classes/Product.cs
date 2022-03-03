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
        public int number { get; set; }
    }

    internal class Product
    {
        public List<MaterialData> materials;

        public Product(Material[] mats, int[] nums)
        {
            materials = new List<MaterialData>();
            for (int i = 0; i < mats.Length; i++)
            {
                MaterialData temp = new MaterialData();
                temp.material = mats[i];
                temp.number = nums[i];
                materials.Add(temp);
            }
        }

        public bool AddMaterial(Material mat, int number)
        {
            bool hasMaterial = false;
            for (int i = 0; i < materials.Count; i++)
            {
                Console.WriteLine(materials[i]);
            }
            return !hasMaterial;
        }
    }
}
