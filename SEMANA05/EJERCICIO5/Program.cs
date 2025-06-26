using System;

class Palindromo
{
    public bool EsPalindromo(string palabra)
    {
        string invertida = "";

        // Se invierte la palabra carácter por carácter
        for (int i = palabra.Length - 1; i >= 0; i--)
        {
            invertida += palabra[i];
        }

        // Se compara la palabra original con la invertida (ignorando mayúsculas)
        return palabra.Equals(invertida, StringComparison.OrdinalIgnoreCase);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        // Se crea un objeto de la clase Palindromo
        Palindromo verificador = new Palindromo();

        // Se verifica si la palabra es un palíndromo
        if (verificador.EsPalindromo(palabra))
        {
            Console.WriteLine("Es un palíndromo.");
        }
        else
        {
            Console.WriteLine("No es un palíndromo.");
        }
    }
}
