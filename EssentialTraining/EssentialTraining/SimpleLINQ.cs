using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EssentialTraining
{
    public class SimpleLINQ
    {
        public int[] ListOfNumbers { get; set; }

        public SimpleLINQ()
        {
            ListOfNumbers = new int[5] { 1, 3, 5, 7, 9 };
        }

        public void SomeLinqMethods()
        {
            Console.WriteLine("Sum: " + ListOfNumbers.Sum());
            Console.WriteLine("Average: " + ListOfNumbers.Average());
            Console.WriteLine("Numbers bigger than or equal to 5:");
            var result = ListOfNumbers.Where(element => element >= 5);
            foreach(int element in result)
            {
                Console.WriteLine(element);
            }
        }
    }
}
