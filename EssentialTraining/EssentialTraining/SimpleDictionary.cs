using System;
using System.Collections.Generic;

namespace EssentialTraining
{
    public class SimpleDictionary
    {
        public Dictionary<string, string> dictionaryWords { get; set; }

        public SimpleDictionary()
        {
            dictionaryWords = new Dictionary<string, string>();
        }

        public void WorkWithDictionary()
        {
            dictionaryWords.Add("var", "shorthand for variable");
            Console.WriteLine(dictionaryWords["var"]);
            dictionaryWords.Add("variable", "a container for data");
            Console.WriteLine("Size of the dictionary: " + dictionaryWords.Count);
            Dictionary<string, string>.KeyCollection keyColl = dictionaryWords.Keys;
            foreach (string key in keyColl)
            {
                Console.WriteLine(key);
            }

        }
    }
}
