using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Stock_Keeping_Application.Classes
{
    internal class Material
    {
        private static int idx = 1;
        public int Id;
        public string Name;
        public int Number;
        public float Price;
        public string From;
        public string Link;

        public Material(string name, int number, float price = 0.0f, string from = "unknown", string link = "empty")
        {
            Id = idx;
            idx = idx + 1;
            Name = name;
            Number = number;
            Price = price;
            From = from;
            Link = link;
        }

        public static bool operator ==(Material a, Material b)
        {
            return a.Id == b.Id;
        }

        public static bool operator !=(Material a, Material b)
        {
            return a.Id != b.Id;
        }
    }
}
