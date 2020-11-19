using System;

namespace Przedszkolanka_522
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfOperations; i++)
            {
                string input = Console.ReadLine();
                string[] tab = input.Split(" ");
                int less = Convert.ToInt32(tab[0]);
                int grater = Convert.ToInt32(tab[1]);
                int tmp;
                if (less > grater)
                {
                    tmp = less;
                    less = grater;
                    grater = tmp;
                }

                int result = grater;

                while (result % less != 0 || result % grater != 0)
                {
                    result += grater;
                }
                Console.WriteLine(result);
            }
        }
    }
}