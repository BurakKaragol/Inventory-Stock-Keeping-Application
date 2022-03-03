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
        public string StockCode;
        public string Name;
        public int Number;
        public int Stack;
        private int TotalNumber;
        public string Type;
        public float Price;
        public string From;
        public string Date;

        public Material(string stockCode, string name, int number, int stack = 1,
            string type = "not-specified", float price = 0.0f, string from = "unknown", string date = "empty")
        {
            Id = idx;
            idx = idx + 1;
            StockCode = stockCode;
            Name = name;
            Number = number;
            Stack = stack;
            TotalNumber = number * stack;
            Type = type;
            Price = price;
            From = from;
            Date = date;
        }

        public static bool operator ==(Material a, Material b)
        {
            return a.Id == b.Id || a.StockCode == b.StockCode || a.Name == b.Name;
        }

        public static bool operator !=(Material a, Material b)
        {
            return a.Id != b.Id || a.StockCode != b.StockCode || a.Name != b.Name;
        }
    }
}
