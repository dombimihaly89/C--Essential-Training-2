using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{
    public class SimpleArray
    {
        public string[] GroceryList { get; set; }
        public int[,] Multi { get; set; }
        public List<string> myList { get; set; }

        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };

            Multi = new int[3,4]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 }
            };

            myList = new List<string>();
            myList.Add("dog");
            myList.Add("cat");
            myList.Add("zebra");
        }

        public bool containsAnimal(string animal)
        {
            return myList.Contains(animal);
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
