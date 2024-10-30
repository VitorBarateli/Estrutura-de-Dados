using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    public class InsertionSort
    {
        public int[] array;

        public InsertionSort(int[] array)
        {
            this.array = array;
        }

        public void Ordernar()
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int aux = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > aux)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = aux;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
