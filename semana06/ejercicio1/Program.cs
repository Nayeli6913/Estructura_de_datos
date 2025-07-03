using System;

namespace Ejercicio_InvertirLista
{
    // Clase Nodo que representa cada elemento de la lista
    public class Nodo
    {
        public int Dato;           // Valor almacenado en el nodo
        public Nodo Siguiente;     // Referencia al siguiente nodo

        public Nodo(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase ListaEnlazada que contiene los métodos principales
    public class ListaEnlazada
    {
        private Nodo cabeza;

        // Agrega un nuevo nodo al final de la lista
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

        // Muestra todos los elementos de la lista
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

        // Método que invierte el orden de los elementos en la lista enlazada
        public void Invertir()
        {
            Nodo anterior = null;
            Nodo actual = cabeza;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;   // Guardar referencia al siguiente nodo
                actual.Siguiente = anterior;    // Invertir el enlace
                anterior = actual;              // Mover el puntero 'anterior'
                actual = siguiente;             // Avanzar al siguiente nodo
            }

            cabeza = anterior; // Actualizar la cabeza al nuevo inicio
        }
    }

    // Clase principal para probar la inversión de la lista
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();

            // Agregar elementos a la lista
            lista.Agregar(1);
            lista.Agregar(2);
            lista.Agregar(3);
            lista.Agregar(4);
            lista.Agregar(5);

            Console.WriteLine("Lista original:");
            lista.Imprimir();

            // Invertir la lista
            lista.Invertir();

            Console.WriteLine("Lista invertida:");
            lista.Imprimir();
        }
    }
}
