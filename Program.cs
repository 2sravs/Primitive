using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 5, 20, 30, 15 };

            double[] prices = { 9.99, 15.49, 20.0, 7.25 };

            char[] characters = { 'A', 'B', 'C', 'D', 'E' };

            string[] names = { "John", "Alice", "Bob", "Eve" };

            int sumOfNumbers = 0;
            foreach (int num in numbers)
            {
                sumOfNumbers += num;
            }

            double averagePrice = 0.0;
            foreach (double price in prices)
            {
                averagePrice += price;
            }
            averagePrice /= prices.Length;

            char firstCharacter = characters[0];
            string firstPersonName = names[0];


            Console.WriteLine("Array of integers:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n\nArray of doubles:");
            foreach (double price in prices)
            {
                Console.Write(price + " ");
            }

            Console.WriteLine("\n\nArray of characters:");
            foreach (char ch in characters)
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine("\n\nArray of strings:");
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine($"\n\nSum of numbers: {sumOfNumbers}");
            Console.WriteLine($"Average price: {averagePrice:F2}");
            Console.WriteLine($"First character: {firstCharacter}");
            Console.WriteLine($"First person name: {firstPersonName}");
            Console.ReadKey();
        }

    }
}


