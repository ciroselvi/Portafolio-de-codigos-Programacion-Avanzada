Console.WriteLine("SISTEMA DE CONTROL DE MOTORES");
Console.WriteLine("1. Motor CD");
Console.WriteLine("2. Motor AC");
Console.WriteLine("3. Servomotor");
Console.Write("Seleccione el tipo de motor (1-3): ");
int opcion = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
switch (opcion)
{
    case 1:
        MotorCD motorCD1 = new MotorCD();
        motorCD1.CapturarDatosBase(); // Heredado de Motor
        Console.Write("Ingrese el voltaje de operación (V): ");
        motorCD1.Voltaje = Convert.ToDouble(Console.ReadLine());

        motorCD1.MostrarDatosBase();  // Heredado de Motor
        Console.WriteLine($"Voltaje: {motorCD1.Voltaje} V");
        Console.WriteLine($"Revisión de voltaje: {motorCD1.RevisarVoltajeMotorCD()}");
        break;

    case 2:
        MotorAC motorAC1 = new MotorAC();
        motorAC1.CapturarDatosBase(); // Heredado de Motor
        Console.Write("Ingrese las fases de operación (1, 2 o 3): ");
        motorAC1.Fases = Convert.ToInt32(Console.ReadLine());

        motorAC1.MostrarDatosBase();  // Heredado de Motor
        Console.WriteLine($"Fases: {motorAC1.Fases}");
        Console.WriteLine($"Tipo de alimentación: {motorAC1.DeterminarFasesMotorAC()}");
        break;

    case 3:
        Servomotor servo1 = new Servomotor();
        servo1.CapturarDatosBase();   // Heredado de Motor
        Console.Write("Ingrese la posición angular (0 a 180°): ");
        servo1.Posicion = Convert.ToDouble(Console.ReadLine());

        servo1.MostrarDatosBase();    // Heredado de Motor
        Console.WriteLine($"Posición angular: {servo1.Posicion} °");
        Console.WriteLine($"Revisión de posición: {servo1.RevisarPosicionServomotor()}");
        break;

    default:
        Console.WriteLine("Opción no válida.");
        break;
}
// CLASE BASE
class Motor
{
    // Propiedades compartidas
    public string Identificador { get; set; } = "";
    public double Temperatura { get; set; }
    public double Corriente { get; set; }
    public double Velocidad { get; set; }

    // Método heredado para pedir los datos que todos comparten
    public void CapturarDatosBase()
    {
        Console.Write("Ingrese el identificador del motor: ");
        Identificador = Console.ReadLine() ?? "Sin identificador";

        Console.Write("Ingrese la temperatura del motor (°C): ");
        Temperatura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la corriente del motor (A): ");
        Corriente = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la velocidad del motor en rpm: ");
        Velocidad = Convert.ToDouble(Console.ReadLine());
    }

    // Método heredado para mostrar los datos que todos comparten
    public void MostrarDatosBase()
    {
        Console.WriteLine("\nDATOS DEL MOTOR");
        Console.WriteLine($"Motor: {Identificador}");
        Console.WriteLine($"Temperatura: {Temperatura} °C");
        Console.WriteLine($"Corriente: {Corriente} A");
        Console.WriteLine($"Velocidad: {Velocidad} rpm");
        Console.WriteLine($"Estado: {ObtenerEstado()}");
        Console.WriteLine($"Revisión de temperatura: {RevisarTemperatura()}");
    }

    public string ObtenerEstado()
    {
        if (Velocidad > 0)
            return "Motor en marcha";
        else
            return "Motor detenido";
    }

    public string RevisarTemperatura()
    {
        if (Temperatura > 70)
            return "ALERTA: Temperatura elevada";

        return "Temperatura normal";
    }
}
// CLASES DERIVADAS
class MotorCD : Motor
{
    public double Voltaje { get; set; }

    public string RevisarVoltajeMotorCD()
    {
        if (Voltaje < 12)
            return "ALERTA: Voltaje bajo";
        else if (Voltaje > 24)
            return "ALERTA: Voltaje alto";
        else
            return "Voltaje normal";
    }
}

class MotorAC : Motor
{
    public int Fases { get; set; }

    public string DeterminarFasesMotorAC()
    {
        if (Fases == 1)
            return "Motor Monofásico";
        else if (Fases == 2)
            return "Motor Bifásico";
        else if (Fases == 3)
            return "Motor Trifásico";
        else
            return "ALERTA: Número de fases no válido";
    }
}

class Servomotor : Motor
{
    public double Posicion { get; set; }

    public string RevisarPosicionServomotor()
    {
        if (Posicion < 0 || Posicion > 180)
            return "ALERTA: Posición fuera de rango";
        else
            return "Posición normal";
    }
}
