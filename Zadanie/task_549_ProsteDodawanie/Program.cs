using System;

namespace _549_ProsteDodawanie
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            if (numberOfTests > 0 && numberOfTests < 80)
            {
                for (int i = 0; i < numberOfTests; i++)
                {
                    int input = int.Parse(Console.ReadLine());
                    string cyfry = Console.ReadLine();
                    string[] tab = cyfry.Split(" ");

                    int suma = 0;
                    foreach (string v in tab)
                    {
                        int cyfra = int.Parse(v);
                        suma += cyfra;
                    }
                    Console.WriteLine(suma);
                }
            }
        }
    }
}
