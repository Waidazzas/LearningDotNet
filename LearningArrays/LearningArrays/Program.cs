using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Names = new string[] { "Vaidas", "Laurynas", "Zivile", "Lukrecija", "Grantas" };
            Console.WriteLine("The names from array are:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Names[i]);
            }
            Console.WriteLine();

            int[] Number = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            Array.Reverse(Number);
            Console.Write("An array by descending order are: ");
            foreach (var Descending in Number)
            {
                Console.Write(Descending + " ");
            }
            Console.ReadKey();
        }
    }
}
