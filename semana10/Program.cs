using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Crear los 500 ciudadanos ficticios
        List<string> ciudadanos = new List<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 2. Crear los 75 ciudadanos vacunados con Pfizer (aleatorio)
        HashSet<string> pfizer = new HashSet<string>();
        Random rnd = new Random();
        while (pfizer.Count < 75)
        {
            int index = rnd.Next(0, 500);
            pfizer.Add(ciudadanos[index]);
        }

        // 3. Crear los 75 ciudadanos vacunados con AstraZeneca (aleatorio)
        HashSet<string> astraZeneca = new HashSet<string>();
        while (astraZeneca.Count < 75)
        {
            int index = rnd.Next(0, 500);
            astraZeneca.Add(ciudadanos[index]);
        }

        // 4. Operaciones de teoría de conjuntos

        // Ciudadanos no vacunados = todos - (Pfizer ∪ AstraZeneca)
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(pfizer.Union(astraZeneca));

        // Ciudadanos que han recibido ambas dosis = Pfizer ∩ AstraZeneca
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Ciudadanos que solo recibieron Pfizer = Pfizer - AstraZeneca
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Ciudadanos que solo recibieron AstraZeneca = AstraZeneca - Pfizer
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // 5. Mostrar resultados
        Console.WriteLine("Ciudadanos que NO se han vacunado: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos que recibieron AMBAS dosis: " + ambasDosis.Count);
        Console.WriteLine("Ciudadanos que solo recibieron PFIZER: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos que solo recibieron ASTRAZENECA: " + soloAstra.Count);

        // Opcional: mostrar listas
        // Console.WriteLine(string.Join(", ", noVacunados));
        // Console.WriteLine(string.Join(", ", ambasDosis));
        // Console.WriteLine(string.Join(", ", soloPfizer));
        // Console.WriteLine(string.Join(", ", soloAstra));
    }
}

