using System;
using System.Collections.Generic;

class ListaInversa
{
    public List<int> Numeros { get; set; }

    public ListaInversa()
    {
        // Se crea la lista con los números del 1 al 10
        Numeros = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            Numeros.Add(i);
        }
    }

    public void MostrarInverso()
    {
        // Se invierte el orden de la lista
        Numeros.Reverse();
        Console.WriteLine("Números en orden inverso:");
        Console.WriteLine(string.Join(", ", Numeros));
    }
}

class Program
{
    static void Main()
    {
        // Se crea un objeto de la clase ListaInversa
        ListaInversa lista = new ListaInversa();
        // Se muestra la lista invertida
        lista.MostrarInverso();
    }
}
