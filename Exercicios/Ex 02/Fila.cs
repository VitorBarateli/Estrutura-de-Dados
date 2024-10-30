using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    public class Fila
    {
        private int[] itens;
        private int tamanho;
        private int capacidade;
        private int inicio;
        private int fim;

        public Fila(int capacidade)
        {
            this.capacidade = capacidade;
            itens = new int[capacidade];
            tamanho = 0;
            inicio = 0;
            fim = -1;
        }

        public void Enqueue(int elemento)
        {
            fim = (fim + 1) % capacidade;
            itens[fim] = elemento;
            tamanho++;
        }

        public void Dequeue()
        {
            if (IsEmpty() == false)
            {
                Console.WriteLine("Removendo frente da fila: " + itens[inicio]);
                inicio = (inicio + 1) % capacidade;
                tamanho--;
            }
            else
            {
                Console.WriteLine("\nFila vazia!");
            }
        }

        public void MostrarFila()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Fila vazia!");
            }
            else
            {
                Console.WriteLine("\n-------------------------");
                Console.Write("Elementos na fila:\n");
                int indice = inicio;

                for (int i = 0; i < tamanho; i++)
                {
                    Console.Write(itens[indice] + "\n");
                    indice = (indice + 1) % itens.Length;
                }

                Console.WriteLine("\n");
            }
        }

        public bool IsEmpty()
        {
            return tamanho == 0;
        }


    }
}