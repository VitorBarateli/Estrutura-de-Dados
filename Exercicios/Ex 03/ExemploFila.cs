using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    public class ExemploFila
    {
        public void Exemplo()
        {
            Fila normal = new Fila();
            Fila covid = new Fila();
            Fila aux = new Fila();
            bool plantao = false;
            string medico = "Medico 1";

            while (true)
            {
                Console.WriteLine("Plantao do: " + medico);
                Console.WriteLine("1 - Iniciar Plantão\n2 - Paciente\n3 - Atendimento\n4 - Encerrar Plantão\n5 - Encerrar sistema\n6 - Ver total de pessoas nas filas");
                int escolha0 = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (escolha0 == 1)
                {
                    plantao = true;
                }

                else if(escolha0 == 2)
                {
                    if(plantao == true)
                    {
                        Console.WriteLine("Nome do Paciente: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("\n");
                        Console.WriteLine("1 - Entrar na Fila Normal\n2 - Entrar na Fila COVID");
                        int escolha = int.Parse(Console.ReadLine());

                        if (escolha == 1)
                        {
                            

                            Console.WriteLine("\n1 - Jovem Sem Deficiencia\n2 - Grávida\n3 - Idoso\n4 - PcDs");
                            int pessoa = int.Parse(Console.ReadLine());
                            var frente = normal.Peek();

                            if (pessoa > frente?.item && frente?.item != 0)
                            {
                                if (aux.Count > 0)
                                {
                                    while (normal.Count > 0)
                                    {
                                        Console.WriteLine("\nRemovendo frente da fila: {0}", normal.Dequeue()?.item);
                                        Console.WriteLine("Total de pessoas na fila: {0}", normal.Count);
                                        Console.WriteLine("\n-------------------------");
                                        Console.Write("Pessoas da Fila Normal:\n");
                                        normal.MostrarFila();
                                        Console.WriteLine("-------------------------\n");
                                    }
                                }

                                aux.Enqueue(new Node<int>(pessoa));

                                while (normal.Count > 0)
                                {
                                    var trocar = normal.Dequeue();
                                    aux.Enqueue(new Node<int>(trocar.item));
                                }

                                while (aux.Count > 0)
                                {
                                    var trocar = aux.Dequeue();
                                    normal.Enqueue(new Node<int>(trocar.item));
                                }

                                Console.WriteLine("\n");
                                Console.WriteLine("Total de pessoas na fila: {0}", normal.Count);
                                Console.WriteLine("\n-------------------------");
                                Console.Write("Pessoas da Fila Normal:\n");
                                normal.MostrarFila();
                                Console.WriteLine("-------------------------\n");
                            }
                            else
                            {
                                normal.Enqueue(new Node<int>(pessoa));
                                Console.WriteLine("\n");
                                Console.WriteLine("Total de pessoas na fila: {0}", normal.Count);
                                Console.WriteLine("\n-------------------------");
                                Console.Write("Pessoas da Fila Normal:\n");
                                normal.MostrarFila();
                                Console.WriteLine("-------------------------\n");
                            }
                        }
                        else if (escolha == 2)
                        {
                            Console.WriteLine("\n1 - Jovem Sem Deficiencia\n2 - Grávida\n3 - Idoso\n4 - PcDs");
                            int pessoa = int.Parse(Console.ReadLine());
                            var frente = covid.Peek();

                            if (pessoa > frente?.item && frente?.item != 0)
                            {
                                if (aux.Count > 0)
                                {
                                    while (covid.Count > 0)
                                    {
                                        Console.WriteLine("\nAtendendo frente da fila: {0}", covid.Dequeue()?.item);
                                        Console.WriteLine("Total de pessoas na fila: {0}", covid.Count);
                                        Console.WriteLine("\n-------------------------");
                                        Console.Write("Pessoas da Fila COVID:\n");
                                        covid.MostrarFila();
                                        Console.WriteLine("-------------------------\n");
                                    }
                                }

                                aux.Enqueue(new Node<int>(pessoa));

                                while (covid.Count > 0)
                                {
                                    var trocar = covid.Dequeue();
                                    aux.Enqueue(new Node<int>(trocar.item));
                                }

                                while (aux.Count > 0)
                                {
                                    var trocar = aux.Dequeue();
                                    covid.Enqueue(new Node<int>(trocar.item));
                                }

                                Console.WriteLine("\n");
                                Console.WriteLine("Total de pessoas na fila: {0}", covid.Count);
                                Console.WriteLine("\n-------------------------");
                                Console.Write("Pessoas da Fila COVID:\n");
                                covid.MostrarFila();
                                Console.WriteLine("-------------------------\n");
                            }
                            else
                            {
                                covid.Enqueue(new Node<int>(pessoa));
                                Console.WriteLine("\n");
                                Console.WriteLine("Total de pessoas na fila: {0}", covid.Count);
                                Console.WriteLine("\n-------------------------");
                                Console.Write("Pessoas da Fila COVID:\n");
                                covid.MostrarFila();
                                Console.WriteLine("-------------------------\n");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Plantao está fechado");
                    }
                }


                else if( escolha0 == 3)
                {
                    if(plantao == true)
                    {
                        if (covid.Count == 0)
                        {
                            Console.WriteLine("\n-------------------------");
                            Console.Write("Pessoas da Fila COVID:\n");
                            Console.WriteLine("Fila vazia!");
                            Console.WriteLine("-------------------------\n");
                        }
                        else
                        {
                            Console.WriteLine("\n-------------------------");
                            Console.Write("Pessoas da Fila COVID:\n");
                            covid.MostrarFila();
                            Console.WriteLine("-------------------------\n");

                            Console.WriteLine("Atendendo frente da fila: {0}", covid.ConveterTopo());
                            covid.Dequeue();
                            Console.WriteLine("Total de pessoas na fila: {0}", covid.Count);
                            Console.WriteLine("\n-------------------------");
                            Console.Write("Pessoas da Fila COVID:\n");
                            covid.MostrarFila();
                            Console.WriteLine("-------------------------\n");

                            Console.WriteLine("Atendendo frente da fila: {0}", covid.ConveterTopo());
                            covid.Dequeue();
                            Console.WriteLine("Total de pessoas na fila: {0}", covid.Count);
                            Console.WriteLine("\n-------------------------");
                            Console.Write("Pessoas da Fila COVID:\n");
                            covid.MostrarFila();
                            Console.WriteLine("-------------------------\n");
                        }

                        if (normal.Count == 0)
                        {
                            Console.WriteLine("\nFila vazia!\n");
                        }
                        else
                        {
                            Console.WriteLine("\n-------------------------");
                            Console.Write("Pessoas da Fila Normal:\n");
                            normal.MostrarFila();
                            Console.WriteLine("-------------------------\n");

                            Console.WriteLine("Atendendo frente da fila: {0}", normal.ConveterTopo());
                            normal.Dequeue();
                            Console.WriteLine("Total de pessoas na fila: {0}", normal.Count);
                            Console.WriteLine("\n-------------------------");
                            Console.Write("Pessoas da Fila Normal:\n");
                            normal.MostrarFila();
                            Console.WriteLine("-------------------------\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Plantao está fechado");
                    }
                }


                else if(escolha0 == 4)
                {
                    Console.WriteLine("Nome do proximo medico: ");
                    medico = Console.ReadLine();
                    plantao = false;
                }


                else if(escolha0 == 5)
                {
                    if (covid.Count > 0 || normal.Count > 0)
                    {
                        Console.WriteLine("As filas não estão vazias\n");
                    }
                    else
                    {
                        break;
                    }

                }


                else if(escolha0 == 6)
                {
                    int total = covid.Count + normal.Count;
                    Console.WriteLine("Total de pessoas em todas as filas: " +  total);
                }


                else
                {
                    Console.WriteLine("Escolha um dos numeros validos");
                }

            }



        }
    }
}
