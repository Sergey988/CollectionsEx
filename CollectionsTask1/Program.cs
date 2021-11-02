using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsTask1
{
        //Task 1:
        //Create the ArrayList collection and initialize with random value of bool, int, double type.
        //Then separate the elements to 3 different List<T> collections (List<bool>, List<int>, List<double>).
        //Display the collections to the console.

    class Program
    {
        public static void Print<T>(IEnumerable<T> list)
        {
            Console.WriteLine($"List of - {list.GetType()}");

            foreach (var item in list)
                Console.Write($"{item}\t");

            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            
            int elemOfArray = 20;
            int n = 0;
            int boolValue;
            Random random = new Random();

            for (int i = 0; i < elemOfArray; i++)
            {
                n = random.Next(3);
                switch (n)
                {
                    case 0:
                        arrayList.Add(random.Next(100));
                        break;
                    case 1:
                        arrayList.Add(Math.Round(random.NextDouble(),2));
                        break;
                    case 2:
                        boolValue = random.Next(2);
                        if (boolValue == 1)
                            arrayList.Add(true);
                        else
                            arrayList.Add(false);
                        break;
                }
            }
            Console.WriteLine($"ArrayList with random value (bool, int, double)");
            foreach (var item in arrayList)
                Console.Write($"{item}\t");
            Console.WriteLine("\n");

            List<bool> listBool = new List<bool>(elemOfArray);
            List<int> listInt = new List<int>(elemOfArray);
            List<double> listDouble = new List<double>(elemOfArray);

            for (int i = 0; i < elemOfArray; i++)
            {
                if (arrayList[i].GetType() == typeof(int))
                {
                    listInt.Add((int)arrayList[i]);
                } 
                else if (arrayList[i].GetType() == typeof(double))
                {
                    listDouble.Add((double)arrayList[i]);
                }
                else
                {
                    listBool.Add((bool)arrayList[i]);
                }
            }

            Print(listInt);
            Print(listDouble);
            Print(listBool);

        }
    }
}
