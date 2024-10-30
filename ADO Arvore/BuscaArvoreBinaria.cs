using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ADO_Arvore
{
    public class BuscaArvoreBinaria
    {
        public Node raiz;

        public BuscaArvoreBinaria()
        {
            raiz = null;
        }

        public void Insert(int i)
        {
            Node novoNode = new Node();
            novoNode.Data = i;

            if (raiz == null)
            {
                raiz = novoNode;
            }
            else
            {
                Node atual = raiz;
                Node pai;

                while (true)
                {
                    pai = atual;

                    if (i < atual.Data)
                    {
                        atual = atual.Esquerda;

                        if (atual == null)
                        {
                            pai.Esquerda = novoNode;
                            break;
                        }
                    }
                    else
                    {
                        atual = atual.Direita;

                        if (atual == null)
                        {
                            pai.Direita = novoNode;
                            break;
                        }
                    }
                }
            }
        }


        public Node ProcurarValor(Node raiz, int valor)
        {
            if (raiz == null || raiz.Data == valor)
            {
                return raiz;
            }

            if (valor < raiz.Data)
            {
                return ProcurarValor(raiz.Esquerda, valor);
            }
            else
            {
                return ProcurarValor(raiz.Direita, valor);
            }
        }


        public void InOrder(Node raiz)
        {
            if (raiz != null)
            {
                InOrder(raiz.Esquerda);
                Console.Write(raiz.Data + " ");
                InOrder(raiz.Direita);
            }
        }

        public void PreOrder(Node raiz)
        {
            if (raiz != null)
            {
                Console.Write(raiz.Data + " ");
                PreOrder(raiz.Esquerda);
                PreOrder(raiz.Direita);
            }
        }

        public void PostOrder(Node raiz)
        {
            if (raiz != null)
            {
                PostOrder(raiz.Esquerda);
                PostOrder(raiz.Direita);
                Console.Write(raiz.Data + " ");
            }
        }

        public void InOrderFolha(Node raiz)
        {
            if (raiz != null)
            {
                InOrderFolha(raiz.Esquerda);
                if (raiz.Esquerda == null && raiz.Direita == null)
                {
                    Console.Write(raiz.Data + " ");
                }
                InOrderFolha(raiz.Direita);
            }
        }

        public void PreOrderFolha(Node raiz)
        {
            if (raiz != null)
            {
                if (raiz.Esquerda == null && raiz.Direita == null)
                {
                    Console.Write(raiz.Data + " ");
                }
                PreOrderFolha(raiz.Esquerda);
                PreOrderFolha(raiz.Direita);
            }
        }

        public void PostOrderFolha(Node raiz)
        {
            if (raiz != null)
            {
                PostOrderFolha(raiz.Esquerda);
                PostOrderFolha(raiz.Direita);
                if (raiz.Esquerda == null && raiz.Direita == null)
                {
                    Console.Write(raiz.Data + " ");
                }
            }
        }


        public bool VerificarBinario()
        {
            return BinarioUtil(raiz, int.MinValue, int.MaxValue);
        }

        private bool BinarioUtil(Node node, int minValor, int maxValor)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Data < minValor || node.Data > maxValor)
            {
                return false;
            }

            return BinarioUtil(node.Esquerda, minValor, node.Data - 1) && BinarioUtil(node.Direita, node.Data + 1, maxValor);
        }

    }
}
