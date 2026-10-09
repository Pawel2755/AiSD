using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class sortowanie
    {
        public static void Babelkowe(int[] tab)
        {
            int n = tab.Length;
            for(int i = 0; i < n - 1; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int tmp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = tmp;
                    }
                }
            }
        }
        public static void przezWybieranie(int[] tab)
        {
            int n = tab.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i+1; j < n; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int tmp = tab[min];
                    tab[min] = tab[i];
                    tab[i] = tmp;
                }
            }
        }
        public static int[] Konwertuj(string liczby)
        {
            
            string[] liczby1 = liczby.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var wynik = new int[liczby1.Length];
            for(int i = 0; i < wynik.Length; i++)
            {
                wynik[i] = int.Parse(liczby1[i]);
            }
            
            return wynik;

        }
    }
}
