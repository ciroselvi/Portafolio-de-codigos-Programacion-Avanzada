using System;

string respuesta = "s";

// Ciclo while para registrar múltiples motores según el problemario
while (respuesta == "s" || respuesta == "S")
{
    Console.WriteLine("Ejercicio 10 del Problemario U2");
    Console.WriteLine();

    // Crear un objeto de la clase Motor
    Motor TMotor = new Motor();

    Console.Write("Ingrese el identificador del motor: ");
    TMotor.Identificador = Console.ReadLine() ?? "Sin ID";

    double s = 0;
    for (int n = 1; n <= 4; n++) // Ciclo for para solicitar las 4 mediciones de corriente
    {
        Console.Write($"Ingrese la corriente {n} (A): ");
        double t = Convert.ToDouble(Console.ReadLine());
        s = s + t; // Sumar las corrientes ingresadas
    }

    TMotor.SumaCorriente = s;

    // Mostrar resultados
    Console.WriteLine();
    Console.WriteLine($"Identificador del motor: {TMotor.Identificador}");
    Console.WriteLine($"{TMotor.ObtenerEstado1()}");
    Console.WriteLine();

    Console.Write("¿Desea registrar otro motor? (s/n): ");
    respuesta = Console.ReadLine() ?? "n";
    Console.WriteLine();
}

// Definición de la clase
class Motor
{
    // Propiedades
    public string Identificador { get; set; } = "";
    public double SumaCorriente { get; set; }

    // Método para calcular el promedio de corriente
    public double Calculos()
    {
        double promedio;
        promedio = SumaCorriente / 4.0;
        return promedio;
    }

    // Método para determinar el estado del motor
    public string ObtenerEstado1()
    {
        double promedio = Calculos();
        if (promedio <= 5.0)
        {
            return "El promedio de corriente es: " + promedio.ToString("F2") + " A (NORMAL)";
        }
        else
        {
            return "El promedio de corriente es: " + promedio.ToString("F2") + " A (REQUIERE MANTENIMIENTO)";
        }
    }
}