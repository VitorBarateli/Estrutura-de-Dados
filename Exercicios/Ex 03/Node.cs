using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    public class Node<T>
    {
        public T item;
        Node<T>? next = null;

        public Node()
        {
        }

        public Node(T _item)
        {
            item = _item;
        }

        public Node<T>? Next { get { return next; } }

        public void SetNext(Node<T>? _next)
        {
            next = _next;
        }
    }
}
