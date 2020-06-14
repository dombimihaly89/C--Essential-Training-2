using System;
using System.Collections.Generic;
using EssentialTraining;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleArray simpleArray = new SimpleArray();
            //Console.WriteLine(simpleArray.ToString());

            //for (int i = 0; i < simpleArray.Multi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < simpleArray.Multi.GetLength(1); j++)
            //    {
            //        Console.WriteLine(simpleArray.Multi[i, j]);
            //    }
            //}

            //Console.WriteLine(simpleArray.myList[1]);
            //simpleArray.myList.Sort();
            //Console.WriteLine(simpleArray.myList[1]);
            //Console.WriteLine(simpleArray.containsAnimal("zebra"));
            Console.WriteLine("LINQ: ");
            var simpleLINQ = new SimpleLINQ();
            simpleLINQ.SomeLinqMethods();

            Console.WriteLine("Dictionary: ");
            var simpleDictionary = new SimpleDictionary();
            simpleDictionary.WorkWithDictionary();

            var ternary = ("Blue".ToLower() == "blue") ? "Yes" : "No";
            Console.WriteLine(ternary);

            var initializedList = new List<int> { 1, 3, 4, 6, 12 };
            // If an object implements the IEnumerable interface then it can be iterated through with foreach.
            // Collections usually are implementing the interface.
        }
    }
}
