using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    public class ExemploFila
    {
        public void Exemplo()
        {
            Fila minhaFila = new Fila();

            while (true)
            {
                Console.WriteLine("1 - Adicionar Item\n2 - Remover Um Item\n3 - Remover Todos Itens");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("\nDigite o item a ser adicionado: ");
                    int item = int.Parse(Console.ReadLine());
                    minhaFila.Enqueue(new Node<int>(item));
                    Console.WriteLine("\n");
                    Console.WriteLine("Total de itens na fila: {0}", minhaFila.Count);
                    Console.WriteLine("-------------------------");
                    minhaFila.MostrarFila();
                    
                }
                else if(escolha == 2)
                {
                    if (minhaFila.Peek() == null)
                    {
                        Console.WriteLine("\nFila vazia!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nRemovendo frente da fila: {0}", minhaFila.Dequeue()?.item);
                        Console.WriteLine("Total de itens na fila: {0}", minhaFila.Count);

                        if (minhaFila.Peek() == null)
                        {
                            Console.WriteLine("Fila vazia!");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------");
                            minhaFila.MostrarFila();
                        }
                    }   
                }
                else
                {
                    if(minhaFila.Count == 0)
                    {
                        Console.WriteLine("\nFila vazia!\n");
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("-------------------------");
                        minhaFila.MostrarFila();
                        while (minhaFila.Count > 0)
                        {
                            Console.WriteLine("\nRemovendo frente da fila: {0}", minhaFila.Dequeue()?.item);
                            Console.WriteLine("Total de itens na fila: {0}", minhaFila.Count);
                            Console.WriteLine("-------------------------");
                            minhaFila.MostrarFila();
                        }
                    }  
                }

                Console.WriteLine("1 - Continuar Adicionando/Removendo\n2 - Sair");
                int escolha2 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (escolha2 == 2)
                {
                    break;
                }

            }
        }
    }
}
