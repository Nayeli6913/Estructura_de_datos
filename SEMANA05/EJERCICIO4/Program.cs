using System;
using System.Collections.Generic;

class ContadorVocales
{
    public void Contar(string palabra)
    {
        palabra = palabra.ToLower(); // Convertir a minúsculas para facilitar la comparación

        // Diccionario para contar cada vocal
        Dictionary<char, int> vocales = new Dictionary<char, int> 
        { 
            {'a', 0}, {'e', 0}, {'i', 0}, {'o', 0}, {'u', 0}
        };

        // Se recorre cada letra de la palabra
        foreach (char letra in palabra)
        {
            // Si la letra es una vocal, se incrementa el contador
            if (vocales.ContainsKey(letra))
            {
                vocales[letra]++;
            }
        }

        // Se muestran los resultados
        Console.WriteLine("Cantidad de vocales:");
        foreach (var v in vocales)
        {
            Console.WriteLine($"{v.Key}: {v.Value}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        // Se crea un objeto de la clase ContadorVocales
        ContadorVocales contador = new ContadorVocales();
        // Se llama al método para contar las vocales
        contador.Contar(palabra);
    }
}
