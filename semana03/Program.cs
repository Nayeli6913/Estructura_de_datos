using System;

namespace RegistroEstudiante
{
    class Estudiante
    {
        // Propiedades del estudiante
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }

        // Constructor
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("\n--- INFORMACIÓN DEL ESTUDIANTE ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese los datos del estudiante:");

            // Solicitar ID
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            // Solicitar nombres
            Console.Write("Nombres: ");
            string nombres = Console.ReadLine();

            // Solicitar apellidos
            Console.Write("Apellidos: ");
            string apellidos = Console.ReadLine();

            // Solicitar dirección
            Console.Write("Dirección: ");
            string direccion = Console.ReadLine();

            // Solicitar los 3 teléfonos
            string[] telefonos = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Teléfono {i + 1}: ");
                telefonos[i] = Console.ReadLine();
            }

            // Crear objeto del estudiante
            Estudiante estudiante = new Estudiante(id, nombres, apellidos, direccion, telefonos);

            // Mostrar la información
            estudiante.MostrarInformacion();
        }
    }
}
