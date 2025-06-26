using System;
using System.Collections.Generic;

class Curso
{
    public List<string> Asignaturas { get; set; }

    public Curso()
    {
        // Se inicializa la lista con las asignaturas del curso
        Asignaturas = new List<string> { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
    }

    public void MostrarAsignaturas()
    {
        Console.WriteLine("Asignaturas del curso:");
        // Recorre la lista e imprime cada asignatura
        foreach (var asignatura in Asignaturas)
        {
            Console.WriteLine("- " + asignatura);
        }
    }
}

class Program
{
    static void Main()
    {
        // Se crea un objeto de la clase Curso
        Curso curso = new Curso();
        // Se llama al método para mostrar las asignaturas
        curso.MostrarAsignaturas();
    }
}
