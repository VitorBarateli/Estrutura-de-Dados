using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Sort
{
    public class MergeSort
    {
        public int[] array;
        public MergeSort(int[] array) 
        {
            this.array = array;
            Ordenar(this.array);
        }

        public void Ordenar(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            int meio = array.Length / 2;

            int[] esquerda = new int[meio];
            int[] direita = new int[array.Length - meio];

            for (int i = 0; i < meio; i++)
            {
                esquerda[i] = array[i];
            }
                

            for (int i = meio; i < array.Length; i++)
            {
                direita[i - meio] = array[i];
            }    

            Ordenar(esquerda);
            Ordenar(direita);

            Merge(array, esquerda, direita);
            
        }

        public void Merge(int[] array, int[] esquerda, int[] direita)
        {
            int i = 0, j = 0, k = 0;

            while (i < esquerda.Length && j < direita.Length)
            {
                if (esquerda[i] <= direita[j])
                {
                    array[k++] = esquerda[i++];
                }

                else
                {
                    array[k++] = direita[j++];
                }
                    
            }

            while (i < esquerda.Length)
            {
                array[k++] = esquerda[i++];
            }
                

            while (j < direita.Length)
            {
                array[k++] = direita[j++];
            }
                
        }
    }
}
