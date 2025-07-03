using System;

namespace Ejercicio_BuscarDato
{
    // Clase Nodo: representa cada elemento de la lista enlazada
    public class Nodo
    {
        public int Dato;           // Valor que guarda el nodo
        public Nodo Siguiente;     // Referencia al siguiente nodo

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada: aquí está la lógica para agregar y buscar datos
    public class ListaEnlazada
    {
        private Nodo cabeza;

        // Este método agrega nodos al final de la lista
        public void Agregar(int dato)
        {
            Nodo nuevo = new Nodo(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        // Método que recorre la lista y cuenta cuántas veces aparece un valor dado
        public void Buscar(int valorBuscado)
        {
            Nodo actual = cabeza;
            int contador = 0;

            // Recorremos la lista desde el inicio hasta el final
            while (actual != null)
            {
                if (actual.Dato == valorBuscado)
                {
                    contador++; // Si lo encontramos, sumamos 1
                }
                actual = actual.Siguiente;
            }

            // Al final mostramos el resultado según el número de coincidencias
            if (contador > 0)
            {
                Console.WriteLine($"El valor {valorBuscado} se encontró {contador} veces en la lista.");
            }
            else
            {
                Console.WriteLine($"El valor {valorBuscado} no fue encontrado en la lista.");
            }
        }

        // Método opcional para imprimir la lista
        public void Imprimir()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " -> ");
                actual = actual.Siguiente;
            }
            Console.WriteLine("null");
        }
    }

    // Clase principal donde probé todo
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregué varios datos a la lista, algunos repetidos
            lista.Agregar(5);
            lista.Agregar(3);
            lista.Agregar(7);
            lista.Agregar(3);
            lista.Agregar(9);
            lista.Agregar(3);

            Console.WriteLine("Lista enlazada:");
            lista.Imprimir();

            // Probamos la búsqueda de un valor que sí está
            Console.WriteLine("\nBuscando el número 3:");
            lista.Buscar(3);

            // Ahora uno que no está
            Console.WriteLine("\nBuscando el número 10:");
            lista.Buscar(10);
        }
    }
}
