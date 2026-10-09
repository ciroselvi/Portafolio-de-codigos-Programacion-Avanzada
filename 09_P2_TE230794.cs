Console.WriteLine("U2_Problemario_Ejercicio_9");
Console.WriteLine();

//crear objeto para la clase bombas electricas (1 y 2)
BombaElectrica bomba1 = new BombaElectrica();
BombaElectrica bomba2 = new BombaElectrica();

// Entrada de datos para bomba 1
Console.WriteLine("=== Evaluación de Bombas Eléctricas ===\n");
Console.Write("Identificador bomba 1: ");
bomba1.Identificador = Console.ReadLine();
Console.Write("Voltaje (V): ");
bomba1.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Corriente (A): ");
bomba1.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Caudal (L/min): ");
bomba1.Caudal = Convert.ToDouble(Console.ReadLine());

// Entrada de datos para bomba 2
Console.Write("\nIdentificador bomba 2: ");
bomba2.Identificador = Console.ReadLine();
Console.Write("Voltaje (V): ");
bomba2.Voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Corriente (A): ");
bomba2.Corriente = Convert.ToDouble(Console.ReadLine());
Console.Write("Caudal (L/min): ");
bomba2.Caudal = Convert.ToDouble(Console.ReadLine());

// Llamadas a métodos y salida — deben estar fuera de la clase
bomba1.CalcularPotencia();
bomba1.CalcularDesempeno();
bomba2.CalcularPotencia();
bomba2.CalcularDesempeno();

// Mostrar resultados con unidades
Console.WriteLine("\n--- Resultados ---");
Console.WriteLine($"{bomba1.Identificador}: Potencia = {bomba1.Potencia:F2} W, Desempeño = {bomba1.Desempeno:F4} L/min·W⁻¹");
Console.WriteLine($"{bomba2.Identificador}: Potencia = {bomba2.Potencia:F2} W, Desempeño = {bomba2.Desempeno:F4} L/min·W⁻¹");

// Comparación
Console.WriteLine("\n--- Comparación ---");
if (bomba1.Desempeno > bomba2.Desempeno)
    Console.WriteLine($"La bomba {bomba1.Identificador} tiene mejor desempeño.");
else if (bomba2.Desempeno > bomba1.Desempeno)
    Console.WriteLine($"La bomba {bomba2.Identificador} tiene mejor desempeño.");
else
    Console.WriteLine("Ambas bombas tienen el mismo desempeño.");

Console.WriteLine("\nFin del programa.");

class BombaElectrica
{
    // Propiedades
    public string Identificador { get; set; }      // Texto
    public double Voltaje { get; set; }            // Voltios (V)
    public double Corriente { get; set; }          // Amperios (A)
    public double Caudal { get; set; }             // Litros/minuto (L/min)
    public double Potencia { get; private set; }   // Vatios (W)
    public double Desempeno { get; private set; }  // L/min por W

    // Método para calcular potencia
    public void CalcularPotencia()
    {
        Potencia = Voltaje * Corriente;
    }

    // Método para calcular desempeño
    public void CalcularDesempeno()
    {
        if (Potencia != 0)
            Desempeno = Caudal / Potencia;
        else
            Desempeno = 0;
    }
}