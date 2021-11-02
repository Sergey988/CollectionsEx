using System;
using System.Collections.Generic;

namespace CollectionsTask2
{
    class Program
    {
        //Task 2:
        //Find the longest word in the List<string> collection.
        //If there is more than one, display the one that is first alphabetically.

        static void Main(string[] args)
        {
            List<string> listOfWords = new List<string>() { "Hello", "worlds", "howf", "are", "you", "welcome", "backsdf"};
            foreach (var item in listOfWords)
                Console.Write($"{item} ");

            Console.WriteLine();

            Console.WriteLine("Length of words in a sentence");
            foreach (var item in listOfWords)
                Console.Write($"{item.Length} ");

            Console.WriteLine();

            string str = "";
            int maxLength = 0;
            string maxLengthWord = "";
            
            listOfWords.Sort();

            foreach (var item in listOfWords)
            {
                str = item;
                if (maxLength < str.Length)
                {
                    maxLength = str.Length;
                    maxLengthWord = str;
                }
            }

            Console.WriteLine($"Longest word - {maxLengthWord}. Has {maxLength} letters");


        }
    }
}
