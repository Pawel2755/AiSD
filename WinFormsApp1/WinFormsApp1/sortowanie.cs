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

        public static void przezWstawianie(int[] tab)
        {
            int n = tab.Length;
            int value,j;
            for(int i=1;i< n; ++i)
            {
                value = tab[i];
                for(j=i-1;j>= 0 && tab[j] > value; --j)
                {
                    tab[j + 1] = tab[j];
                }
                tab[j + 1] = value;
            }
        }
        public static void przezScalanie(int[] tab)
        {
            int n = tab.Length;
            int[] temp = new int[n];
            for(int width = 1; width < n; width *= 2)
            {
                for(int lewa =0; lewa< n;lewa += 2 * width)
                {
                    int mid = Math.Min(lewa + width, n);
                    int prawa = Math.Min(lewa + 2 * width, n);
                    int i = lewa, j = mid, k = lewa;

                    while(i<mid && j < prawa)
                    {
                        if (tab[i] <= tab[j])
                        {
                            temp[k++] = tab[i++];
                        }
                        else
                            temp[k++] = tab[j++];
                    }
                    while (i < mid)  temp[k++] = tab[i++]; 
                    while (j < prawa) temp[k++] = tab[j++]; 

                    for(int m =lewa; m<prawa;m++)
                    {
                        tab[m] = temp[m];
                    }
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
