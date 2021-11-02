using System;
using System.Collections.Generic;

namespace TowerOfHanoi
{
    //Using the Stack collection, create a solution to the "Tower of Hanoi" task (at least N disks)
    class Program
    {

        static int moveCount = 0;
        
        public static void MoveDisks(int source, int dest, int temp, int numDisk, ref int m)
        {
            if (numDisk > 1)
                MoveDisks(source, temp, dest, numDisk - 1, ref m);
            Console.WriteLine(source + " to " + dest + ".\t");
            m++;
            if (numDisk > 1)
                MoveDisks(temp, dest, source, numDisk-1, ref m);

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of disks:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"Moving {n} disks from peg 1 to peg 3:");
            
            MoveDisks(1, 3, 2, n, ref moveCount);

            Console.WriteLine();
            Console.Write("Total number of moves: ");
            Console.WriteLine(moveCount);

        }
    }
}
