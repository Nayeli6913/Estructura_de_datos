using System;
using System.Collections.Generic;

namespace CatalogoRevistas
{
    class Program
    {
        // Método principal del programa
        static void Main(string[] args)
        {
            // Catálogo de revistas inicializado con al menos 10 títulos
            List<string> catalogo = new List<string>()
            {
                "National Geographic",
                "Scientific American",
                "Time",
                "Nature",
                "Forbes",
                "People",
                "The Economist",
                "PC World",
                "Sports Illustrated",
                "Reader's Digest"
            };

            int opcion;

            // Menú interactivo
            do
            {
                Console.WriteLine("\n===== CATÁLOGO DE REVISTAS =====");
                Console.WriteLine("1. Mostrar catálogo completo");
                Console.WriteLine("2. Buscar una revista por título");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                // Validación de la entrada
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        MostrarCatalogo(catalogo);
                        break;

                    case 2:
                        Console.Write("\nIngrese el título de la revista a buscar: ");
                        string titulo = Console.ReadLine();

                        // Realizamos la búsqueda
                        bool encontrado = BuscarRevista(catalogo, titulo);

                        if (encontrado)
                            Console.WriteLine($"La revista \"{titulo}\" fue Encontrada.");
                        else
                            Console.WriteLine($"La revista \"{titulo}\" No fue encontrada.");
                        break;

                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }

            } while (opcion != 3);
        }

        /// <summary>
        /// Método para mostrar todas las revistas del catálogo
        /// </summary>
        /// <param name="catalogo">Lista de revistas</param>
        static void MostrarCatalogo(List<string> catalogo)
        {
            Console.WriteLine("\n--- LISTA DE REVISTAS DISPONIBLES ---");
            foreach (var revista in catalogo)
            {
                Console.WriteLine($"- {revista}");
            }
        }

        /// <summary>
        /// Método que busca un título en el catálogo de manera iterativa
        /// </summary>
        /// <param name="catalogo">Lista de revistas</param>
        /// <param name="titulo">Título a buscar</param>
        /// <returns>true si encuentra el título, false en caso contrario</returns>
        static bool BuscarRevista(List<string> catalogo, string titulo)
        {
            foreach (var revista in catalogo)
            {
                // Comparación sin distinguir mayúsculas/minúsculas
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
