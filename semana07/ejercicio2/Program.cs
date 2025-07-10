using System;
using System.Collections.Generic;

class TorreDeHanoi
{
    // Se crean tres pilas para representar las tres torres
    static Stack<int> origen = new Stack<int>();
    static Stack<int> auxiliar = new Stack<int>();
    static Stack<int> destino = new Stack<int>();

    /// <summary>
    /// Esta función resuelve el problema de las Torres de Hanoi de forma recursiva.
    /// </summary>
    /// <param name="n">Número de discos</param>
    /// <param name="desde">Torre de origen</param>
    /// <param name="hacia">Torre destino</param>
    /// <param name="intermedio">Torre auxiliar</param>
    /// <param name="nombreDesde">Nombre de la torre de origen</param>
    /// <param name="nombreHacia">Nombre de la torre destino</param>
    /// <param name="nombreIntermedio">Nombre de la torre auxiliar</param>
    static void ResolverHanoi(int n, Stack<int> desde, Stack<int> hacia, Stack<int> intermedio,
                               string nombreDesde, string nombreHacia, string nombreIntermedio)
    {
        // Caso base: si solo hay un disco, se mueve directamente
        if (n == 1)
        {
            int disco = desde.Pop(); // Quitamos el disco de la torre origen
            hacia.Push(disco);       // Lo colocamos en la torre destino
            Console.WriteLine($"Mover disco {disco} de {nombreDesde} a {nombreHacia}");
            return;
        }

        // Paso 1: mover n-1 discos al auxiliar
        ResolverHanoi(n - 1, desde, intermedio, hacia, nombreDesde, nombreIntermedio, nombreHacia);
        // Paso 2: mover el disco más grande al destino
        ResolverHanoi(1, desde, hacia, intermedio, nombreDesde, nombreHacia, nombreIntermedio);
        // Paso 3: mover los n-1 discos desde la torre auxiliar al destino
        ResolverHanoi(n - 1, intermedio, hacia, desde, nombreIntermedio, nombreHacia, nombreDesde);
    }

    static void Main()
    {
        // Pedimos al usuario la cantidad de discos
        Console.Write("Ingrese el número de discos: ");
        int n = int.Parse(Console.ReadLine());

        // Apilamos los discos en la torre de origen en orden descendente
        for (int i = n; i >= 1; i--)
        {
            origen.Push(i);
        }

        Console.WriteLine("\nMovimientos para resolver las Torres de Hanoi:\n");
        // Llamamos a la función principal para iniciar el proceso
        ResolverHanoi(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
    }
}
