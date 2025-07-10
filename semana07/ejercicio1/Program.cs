using System;
using System.Collections.Generic;

class BalanceChecker
{
    /// <summary>
    /// Función que se encarga de verificar si los paréntesis, llaves y corchetes están bien cerrados.
    /// </summary>
    /// <param name="expression">Cadena que contiene la fórmula matemática</param>
    /// <returns>Devuelve true si todo está correctamente balanceado, de lo contrario false</returns>
    static bool EstaBalanceada(string expression)
    {
        // Aquí se usa una pila para almacenar los símbolos de apertura
        Stack<char> pila = new Stack<char>();

        // Recorremos cada carácter de la expresión
        foreach (char c in expression)
        {
            // Si es un símbolo de apertura, lo apilamos
            if (c == '(' || c == '[' || c == '{')
            {
                pila.Push(c);
            }
            // Si encontramos un símbolo de cierre
            else if (c == ')' || c == ']' || c == '}')
            {
                // Si la pila está vacía, hay un error de balanceo
                if (pila.Count == 0)
                    return false;

                // Tomamos el elemento del tope
                char tope = pila.Pop();

                // Comprobamos si el par coincide, si no, retorna false
                if (!EsPar(tope, c))
                    return false;
            }
        }

        // Si al final la pila está vacía, está balanceado
        return pila.Count == 0;
    }

    // Función que compara si los símbolos son del mismo tipo (apertura/cierre)
    static bool EsPar(char abierto, char cerrado)
    {
        return (abierto == '(' && cerrado == ')') ||
               (abierto == '[' && cerrado == ']') ||
               (abierto == '{' && cerrado == '}');
    }

    static void Main()
    {
        // Pedimos al usuario que ingrese una fórmula
        Console.Write("Ingrese la expresión matemática: ");
        string input = Console.ReadLine();

        // Evaluamos si está balanceada o no, y mostramos el resultado
        if (EstaBalanceada(input))
            Console.WriteLine("Fórmula balanceada.");
        else
            Console.WriteLine("Fórmula NO balanceada.");
    }
}
