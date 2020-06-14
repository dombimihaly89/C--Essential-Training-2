using System;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var groceryList = new string[4];
            groceryList[0] = "Milk";
            groceryList[1] = "Cheese";
            groceryList[2] = "Eggs";
            groceryList[3] = "Apples";

            var groceryList2 = new string[2] { "Milk", "Egg" };
            Array.Resize(ref groceryList2, 3);
            groceryList2[2] = "Bread";
            var groceryList3 = groceryList2;
            groceryList3[2] = "Water";
            Console.WriteLine(groceryList2[2]);
        }
    }
}
