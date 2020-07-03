using System;

namespace App33
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] check = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int number = Int32.Parse(Console.ReadLine());
            if (number <= check.Length)
            {
                string found = check[number-1];
                Console.WriteLine(found);
            }
            else
            {
                Console.WriteLine("N/A");
            }

        }
    }
}
