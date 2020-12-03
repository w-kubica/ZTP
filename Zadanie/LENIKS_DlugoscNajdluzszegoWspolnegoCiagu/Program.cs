using System;

namespace LENIKS_DlugoscNajdluzszegoWspolnegoCiagu
{
    class Program
    {
        static void Main(string[] args)
        {
            int tests = int.Parse(Console.ReadLine());

            for (int i = 0; i < tests; i++)
            {
                int dlugoscSlowa_U = int.Parse(Console.ReadLine());
                string slowo_U = Console.ReadLine();

                int dlugoscSlowa_V = int.Parse(Console.ReadLine());
                string slowo_V = Console.ReadLine();

                NajdluzszyWspolnyPodciag(dlugoscSlowa_U, dlugoscSlowa_V, slowo_U, slowo_V);
            }
        }

        private static void NajdluzszyWspolnyPodciag(int dlugoscSlowa_U, int dlugoscSlowa_V, string slowo_U, string slowo_V)
        {
            int[,] tab = new int[dlugoscSlowa_U +1, dlugoscSlowa_V +1];

            for (int i = 0; i <= dlugoscSlowa_U; i++)
            {
                tab[i, 0] = 0;                 
            }

            for (int j = 0; j <= dlugoscSlowa_V; j++)
            {
                tab[0, j] = 0;
            }

            for (int i = 1; i <= dlugoscSlowa_U; i++)
            {
                for (int j = 1; j <= dlugoscSlowa_V; j++)
                {
                   if (slowo_U[i-1] == slowo_V[j-1])
                    {
                        tab[i, j] = tab[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        tab[i, j] = Math.Max(tab[i - 1, j], tab[i, j - 1]);
                    }
                }
            }
            Console.WriteLine(tab[dlugoscSlowa_U, dlugoscSlowa_V]);
        }
    }
}
