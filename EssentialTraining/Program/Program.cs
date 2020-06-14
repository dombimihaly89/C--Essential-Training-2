using System;
using System.Collections.Generic;
using EssentialTraining;
using System.IO;

namespace Program
{
    public class Program
    {
        public static List<string> Words;
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
            //Console.WriteLine("LINQ: ");
            //var simpleLINQ = new SimpleLINQ();
            //simpleLINQ.SomeLinqMethods();

            //Console.WriteLine("Dictionary: ");
            //var simpleDictionary = new SimpleDictionary();
            //simpleDictionary.WorkWithDictionary();

            //var ternary = ("Blue".ToLower() == "blue") ? "Yes" : "No";
            //Console.WriteLine(ternary);

            //var initializedList = new List<int> { 1, 3, 4, 6, 12 };
            /*
            // If an object implements the IEnumerable interface then it can be iterated through with foreach.
            // Collections usually are implementing the interface.
            */

            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Water");
            Words.Add("Butter");
            CrazyMathProblem();
            ReadTextFile();

        }

        private static void ReadTextFile()
        {
            string path = @"C:\temp\test.txt";
            try
            {
                // If we use the @ sign before the quote then we don't get any problem with tha backslash character's
                // escaping behaviour. If we didn't use then it would escape the character after that.
                // We use the using statement here because we want to use a class that implements the IDisposable
                // interface. When we use a class like this we don't have to deal with opening and closing the filestream.
                using (var sr = new StreamReader(path))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("Couldn't find the directory");
                DirectoryInfo di = Directory.CreateDirectory(@"c:\temp");
                CreateFile(path);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Couldn't find the file");
                CreateFile(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured " + ex.Message);
            }
        }

        public static void CreateFile(string path)
        {
            using (FileStream fs = File.Create(path))
            {
                byte[] info = new System.Text.UTF8Encoding(true).GetBytes("This is a test");
                fs.Write(info, 0, info.Length);
            }
        }

        public static int CrazyMathProblem()
        {
            int income = 1000;
            for (int i = 10; i > 0; i--)
            {
                income = (income / i);
            }

            return income;
        }
    }
}
