using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
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
            Console.Write("Itens da Fila:\n");

            if(current != null)
            {
                while (current != null)
                {
                    Console.Write(current.item + "\n");
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("Fila vazia!\n");
            }
            

            Console.WriteLine();
        }

        public bool IsEmpty() => size == 0;

        public int Count { get { return size; } }
    }
}
