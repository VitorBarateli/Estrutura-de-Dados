using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    public class Node<T>
    {
        public T item;
        Node<T>? prev = null;

        public Node(T _item)
        {
            item = _item;
        }

        public Node<T> Prev { get { return prev; } }

        public void SetNext(Node<T>? _prev)
        {
            prev = _prev;
        }
    }
}
