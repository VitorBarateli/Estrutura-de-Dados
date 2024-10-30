using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    public class SelectionSort
    {
        public int[] array;
        public SelectionSort(int[] array)
        {
            this.array = array;
        }

        public void Ordernar()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int menor = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[menor])
                    {
                        menor = j;
                    }
                }
                int aux = array[menor];
                array[menor] = array[i];
                array[i] = aux;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
