using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class ExemploPilha
    {
        public void ExemploPushPop()
        {
            Pilha minhaPilha = new Pilha();

            while (true)
            {
                Console.WriteLine("1 - Adicionar Item\n2 - Remover Um Item\n3 - Remover Todos Itens");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("\nDigite o item a ser adicionado: ");
                    int item = int.Parse(Console.ReadLine());
                    minhaPilha.Push(new Node<int>(item));
                    Console.WriteLine("\n");
                    Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);
                    Console.WriteLine("-------------------------");
                    minhaPilha.MostrarPilha();

                }
                else if (escolha == 2)
                {
                    if (minhaPilha.Peek() == null)
                    {
                        Console.WriteLine("\nPilha vazia!\n");
                    }
                    else
                    {
                        Console.WriteLine("\nRemovendo topo da pilha: {0}", minhaPilha.Pop()?.item);
                        Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);

                        if (minhaPilha.Peek() == null)
                        {
                            Console.WriteLine("Pilha vazia!");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------");
                            minhaPilha.MostrarPilha();
                        }
                    }
                }
                else
                {
                    if (minhaPilha.Count == 0)
                    {
                        Console.WriteLine("\nPilha vazia!\n");
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("-------------------------");
                        minhaPilha.MostrarPilha();
                        while (minhaPilha.Count > 0)
                        {
                            Console.WriteLine("\nRemovendo topo da pilha: {0}", minhaPilha.Pop()?.item);
                            Console.WriteLine("Total de itens na pilha: {0}", minhaPilha.Count);
                            Console.WriteLine("-------------------------");
                            minhaPilha.MostrarPilha();
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
