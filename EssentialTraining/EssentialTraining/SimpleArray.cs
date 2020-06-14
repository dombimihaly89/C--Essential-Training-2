using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GroceryList;


        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < GroceryList.Length; i++)
            {
                sb.AppendLine(GroceryList[i]);
            }
            return sb.ToString();
        }
    }
}
