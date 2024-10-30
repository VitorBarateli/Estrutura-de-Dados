using ADO_Arvore;

bool binaria = true;
BuscaArvoreBinaria arvore = new BuscaArvoreBinaria();
List<int> listaNos = new List<int>();

while (true)
{
    Console.WriteLine("1 - Inserir Nó\n2 - Sair");
    int escolha = int.Parse(Console.ReadLine());

    if (escolha == 1)
    {
        Console.WriteLine("\nDigite o número a ser inserido: ");
        int numero = int.Parse(Console.ReadLine());

        if (arvore.raiz == null)
        {
            arvore.raiz = new Node { Data = numero };
            Console.WriteLine("\nNó inserido como raiz.");
        }
        else
        {
            Console.WriteLine("\nValores dos Nós da Árvore:");

            for (int i = 0; i < listaNos.Count; i++)
            {
                Console.Write(listaNos[i] + " ");
            }

            Console.WriteLine("\nDigite o valor do nó onde deseja inserir: ");

            int valorNo = int.Parse(Console.ReadLine());

            Node noInserir = arvore.ProcurarValor(arvore.raiz, valorNo);

            if (noInserir != null)
            {
                if (numero < noInserir.Data)
                {
                    noInserir.Esquerda = new Node { Data = numero };
                    Console.WriteLine("\nNó inserido à esquerda de " + valorNo);
                }
                else
                {
                    noInserir.Direita = new Node { Data = numero };
                    Console.WriteLine("\nNó inserido à direita de " + valorNo);
                }
            }
            else
            {
                Console.WriteLine("\nNó não encontrado. O nó raiz será escolhido.");
                arvore.Insert(numero);
            }
        }

        listaNos.Add(numero);

        if (arvore.VerificarBinario() == true)
        {
            Console.WriteLine("Árvore é binária\n");
            listaNos.Sort();
        }
        else
        {
            Console.WriteLine("Árvore não é binária");
            binaria = false;
            break;
        }
    }
    else
    {
        break;
    }
}

if(binaria == true)
{
    Console.WriteLine("\nBusca Inoder: ");
    arvore.InOrder(arvore.raiz);
    Console.WriteLine("\n");

    Console.WriteLine("Busca Preoder: ");
    arvore.PreOrder(arvore.raiz);
    Console.WriteLine("\n");

    Console.WriteLine("Busca Postorder: ");
    arvore.PostOrder(arvore.raiz);
    Console.WriteLine("\n");

    Console.WriteLine("\nFolhas da Árvore (InOrder): ");
    arvore.InOrderFolha(arvore.raiz);
    Console.WriteLine("\n");

    Console.WriteLine("Folhas da Árvore (PreOrder): ");
    arvore.PreOrderFolha(arvore.raiz);
    Console.WriteLine("\n");

    Console.WriteLine("Folhas da Árvore (PostOrder): ");
    arvore.PostOrderFolha(arvore.raiz);
    Console.WriteLine("\n");
}