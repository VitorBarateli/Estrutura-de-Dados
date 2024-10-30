using Ex_02;
using System;


Console.WriteLine("Tamanho da fila: ");
int tamanho = int.Parse(Console.ReadLine());
Fila fila = new Fila(tamanho);
Random random = new Random();

fila.Dequeue();

for (int i = 0; i < tamanho; i++)
{
    fila.Enqueue(random.Next(1, 100));
}

for (int i = 0; i <= tamanho; i++)
{
    fila.MostrarFila();
    fila.Dequeue();
    
}