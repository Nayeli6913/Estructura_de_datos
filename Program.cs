using System;

// La clase Circulo representa un círculo geométrico
public class Circulo
{
    // Atributo privado que almacena el radio del círculo
    private double radio;

    // Constructor que recibe el valor del radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método que calcula el área del círculo
    // Área = π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método que calcula el perímetro del círculo (también llamado circunferencia)
    // Perímetro = 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// La clase Rectangulo representa un rectángulo geométrico
public class Rectangulo
{
    // Atributos privados que almacenan la base y la altura del rectángulo
    private double baseRect;
    private double altura;

    // Constructor que recibe los valores de la base y la altura
    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    // Método que calcula el área del rectángulo
    // Área = base * altura
    public double CalcularArea()
    {
        return baseRect * altura;
    }

    // Método que calcula el perímetro del rectángulo
    // Perímetro = 2 * (base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }
}

// Clase principal para probar las figuras
class Programa
{
    static void Main(string[] args)
    {
        // Crear un objeto Circulo con radio 5
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        // Crear un objeto Rectangulo con base 4 y altura 3
        Rectangulo miRectangulo = new Rectangulo(4, 3);
        Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
    }
}