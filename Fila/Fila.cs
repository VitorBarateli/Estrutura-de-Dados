using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila2
{
    public class Fila
    {
        private int[] vetor;
        private int tamanhoFila;
        private int frente;
        Random num = new Random();

        public Fila(int[] elementos)
        {
            vetor = elementos;
            tamanhoFila = elementos.Length;
            frente = 0;
        }

        public void AvancarFrente()
        {
            frente = (frente + 1) % tamanhoFila;
        }

        public void AdicionarNovoElemento()
        {
            int novoElemento = num.Next(1, 11);
            Console.WriteLine($"Novo Pedido adicionado: {novoElemento}");
            vetor[(frente + tamanhoFila - 1) % tamanhoFila] = novoElemento;
        }

        public void RemoverElemento()
        {
            int elementoRemovido = vetor[frente];
            Console.WriteLine($"\nPedido {elementoRemovido} removido");
            AvancarFrente();
        }

        public void Print()
        {
            for (int i = 0; i < tamanhoFila; i++)
            {
                Console.Write($"{vetor[(frente + i) % tamanhoFila]} ");
            }
            Console.WriteLine();
        }
    }

}
