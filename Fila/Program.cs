using Fila2;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor = { 1, 2, 3, 4, 5 };
        Fila fila = new Fila(vetor);

        Console.WriteLine("Fila inicial de Pedidos:");
        fila.Print();

        for (int i = 0; i < 5; i++)
        {
            fila.RemoverElemento();
            fila.AdicionarNovoElemento();
            Console.WriteLine("\nFila atual de Pedidos:");
            fila.Print();
        }
    }
}
