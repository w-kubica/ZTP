using System;

namespace ZabawneDodawaniePiotrusia_568
{
    class Program
    {
        static string reverse(string s)
        {
            char[] tmp = s.ToCharArray();
            Array.Reverse(tmp);
            return new string(tmp);
        }

        static bool isPalindrom(string number)
        {
            string number2 = reverse(number);
            if (number == number2) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] tab = new string[n];

            for (int i = 0; i < n; i++)
            {
                tab[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                if (isPalindrom(tab[i]))
                {
                    Console.WriteLine("{0} {1}", tab[i], counter);
                }
                else
                {
                    int liczba = int.Parse(tab[i]);
                    do
                    {
                        counter++;
                        liczba += int.Parse(reverse(liczba.ToString()));
                    } while (!isPalindrom(liczba.ToString()));
                    Console.WriteLine("{0} {1}", liczba, counter);
                }
            }
        }
    }
}