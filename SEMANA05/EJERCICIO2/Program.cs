using System;
using System.Collections.Generic;

class Loteria
{
    public List<int> Numeros { get; set; } = new List<int>();

    public void PedirNumeros()
    {
        Console.WriteLine("Ingrese los números ganadores (6 números):");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            // Se agregan los números ingresados a la lista
            Numeros.Add(int.Parse(Console.ReadLine()));
        }
    }

    public void MostrarOrdenados()
    {
        // Se ordenan los números de menor a mayor
        Numeros.Sort();
        Console.WriteLine("Números ordenados:");
        Console.WriteLine(string.Join(", ", Numeros));
    }
}

class Program
{
    static void Main()
    {
        // Se crea un objeto de la clase Loteria
        Loteria loteria = new Loteria();
        // Se piden los números al usuario
        loteria.PedirNumeros();
        // Se muestran los números ordenados
        loteria.MostrarOrdenados();
    }
}
