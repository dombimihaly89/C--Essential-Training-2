using System;
using EssentialTraining;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleArray simpleArray = new SimpleArray();
            Console.WriteLine(simpleArray.ToString());
            for (int i = 0; i < simpleArray.Multi.GetLength(0); i++)
            {
                for (int j = 0; j < simpleArray.Multi.GetLength(1); j++)
                {
                    Console.WriteLine(simpleArray.Multi[i, j]);
                }
            }

        }
    }
}
