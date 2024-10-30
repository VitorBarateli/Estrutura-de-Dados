using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pilha
{
    public class Pilha
    {
        Node<int>? top;
        int size;
        public Pilha(Node<int> top)
        {
            Push(top);
        }

        public Pilha()
        {
            size = 0;
        }

        public void Push(Node<int> node)
        {
            if (top != null)
                node.SetNext(top);

            top = node;

            size++;
        }

        public Node<int>? Pop()
        {
            if (size <= 0)
            {
                return null;
            }

            var temp = top;

            size--;

            top = temp.Prev;

            return temp;
        }

        public Node<int>? Peek()
        {
            return top;
        }

        public void MostrarPilha()
        {
            Node<int>? current = top;
            Console.Write("Itens da Pilha:\n");

            if (current != null)
            {
                while (current != null)
                {
                    Console.Write(current.item + "\n");
                    current = current.Prev;
                }
            }
            else
            {
                Console.WriteLine("Pilha vazia!\n");
            }


            Console.WriteLine();
        }

        public bool IsEmpty() => size == 0;
        public int Count { get { return size; } }
    }
}
