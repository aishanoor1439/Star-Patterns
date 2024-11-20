using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;

            // Right-Angled Triangle
            Console.WriteLine("Right-Angled Triangle:");
            Console.Write("Enter the number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Inverted Right-Angled Triangle
            Console.WriteLine("Inverted Right-Angled Triangle:");
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Pyramid Star Pattern
            Console.WriteLine("Pyramid Star Pattern:");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" "); // Print space
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); // Print stars
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Diamond Star Pattern
            Console.WriteLine("Diamond Star Pattern:");
            // Upper part of the diamond
            for (int i = 1; i <= rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" "); // Print space
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); // Print stars
                }
                Console.WriteLine();
            }
            // Lower part of the diamond
            for (int i = rows - 1; i >= 1; i--)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(" "); // Print space
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); // Print stars
                }
                Console.WriteLine();
            }
        }
    }
}
