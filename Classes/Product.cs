using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Material = Inventory_Stock_Keeping_Application.Classes.Material;

namespace Inventory_Stock_Keeping_Application.Classes
{
    public struct MaterialData
    {
        Material material;
        int number;
    }

    internal class Product
    {
        public MaterialData[] materials;

        public Product(string[] names, int[] numbers)
        {
            materials = new MaterialData[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                materials.SetValue(names[i], i);
                materials.SetValue(numbers[i], i);
            }
        }

        public bool AddMaterial(Material mat, int number)
        {
            bool hasMaterial = false;
            for (int i = 0; i < materials.Length; i++)
            {
                Console.WriteLine(materials.GetValue(i).ToString());
            }
            return !hasMaterial;
        }
    }
}
