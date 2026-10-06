Console.WriteLine("Ejercicio 9 Clases y objetos (POO)");
Console.WriteLine();

// Crear un objeto de la clase Estudiante
Motores motor = new Motores();

// Capturar la información del objeto 
Console.Write("Ingrese el numero del motor: ");
motor.Numero = Console.ReadLine() ?? "Sin numero";

Console.Write("Ingrese la Temperatura del motor: ");
motor.Temperatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la Corriente del motor: ");
motor.Corriente = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese la Velocidad del motor: ");
motor.Velocidad = Convert.ToDouble(Console.ReadLine());

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Motor: {motor.Numero}");
Console.WriteLine($"Temperatura: {motor.ObtenerEstado1()}");
Console.WriteLine($"Corriente: {motor.Corriente:F2}");
Console.WriteLine($"Velocidad: {motor.ObtenerEstado2()}");


// Definición de la clase
class Motores
{
    // Propiedades
    public string Numero { get; set; } = "";

    public double Temperatura { get; set; }

    public double Corriente { get; set; }

    public double Velocidad { get; set; }

    // Método para determinar el estado

    public string ObtenerEstado1()
    {

        if (Temperatura > 70)
        {
            return "La temperatura del motor es: " + Temperatura.ToString("F2") + " grados Celsius (La temperatura del motor esta elevada)";
        }
        else
        {
            return "La temperatura del motor es: " + Temperatura.ToString("F2") + " grados Celsius (La temperatura del motor es normal)";
        }

    }
    public string ObtenerEstado2()
    {

        if (Velocidad > 0)
        {
            return "La velocidad del motor es de " + Velocidad.ToString("F2") + " rpm (el motor esta en marcha)";
        }
        else
        {
            return "La velocidad del motor es de " + Velocidad.ToString("F2") + " rpm (el motor esta detenido)";
        }
    }
}