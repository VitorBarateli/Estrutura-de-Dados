using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    public class Fila
    {
        Node<int>? front;
        Node<int>? rear;
        int size;

        public Fila(Node<int> node)
        {
            Enqueue(node);
        }

        public Fila()
        {
            size = 0;
        }

        public void Enqueue(Node<int> node)
        {
            if (rear != null)
                rear.SetNext(node);

            rear = node;

            if (front == null)
                front = rear;

            size++;
        }

        public Node<int>? Dequeue()
        {
            if (size <= 0)
            {
                return null;
            }

            var temp = front;

            size--;

            front = temp.Next;

            if (front == null)
                rear = null;

            return temp;
        }

        public Node<int>? Peek()
        {
            return front;
        }

        public void MostrarFila()
        {
            Node<int>? current = front;

            if (current != null)
            {
                while (current != null)
                {
                    if (current.item == 1)
                    {
                        Console.Write("Jovem Sem Deficiencia\n");
                    }
                    else if(current.item == 2)
                    {
                        Console.Write("Grávida\n");
                    }
                    else if (current.item == 3)
                    {
                        Console.Write("Idoso\n");
                    }
                    else if( current.item == 4)
                    {
                        Console.Write("PcDs\n");
                    }
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("Fila vazia!\n");
            }

            Console.WriteLine();
        }

        public string ConveterTopo()
        {
            Node<int>? current = front;

            if (current != null)
            {
                if (current.item == 41 || current.item == 31 || current.item == 21 || current.item == 11)
                {
                    return "Jovem Sem Deficiencia\n";
                }
                else if (current.item == 42 || current.item == 32 || current.item == 22 || current.item == 12)
                {
                    return "Grávida\n";
                }
                else if (current.item == 43 || current.item == 33 || current.item == 23 || current.item == 13)
                {
                    return "Idoso\n";
                }
                else if (current.item == 44 || current.item == 34 || current.item == 24 || current.item == 14)
                {
                    return "PcDs\n";
                }
            }
            else
            {
                return "Fila vazia!\n";
            }
            return "";
        }

        public bool IsEmpty() => size == 0;

        public int Count { get { return size; } }
    }
}
