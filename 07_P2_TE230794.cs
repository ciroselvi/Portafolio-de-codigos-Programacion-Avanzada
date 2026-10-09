Console.WriteLine("U2_Ejercicio 7_ brazo robotco");
Console.WriteLine();

// Crear un objeto de la clase brazo robotico
BrazoRobotico brazo1 = new BrazoRobotico();

// Capturar la información del objeto
Console.Write("Ingrese el número de ciclos: ");
brazo1.Num_ciclos = Console.ReadLine() ?? "";

Console.Write("Ingrese el tiempo de tomar objeto: ");
brazo1.Tiempo_tomar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo de trasladar objeto: ");
brazo1.Tiempo_trasladar = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el tiempo de soltar objeto: ");
brazo1.Tiempo_soltar = Convert.ToDouble(Console.ReadLine());

// Definición de la clase para el brazo robotico
class BrazoRobotico
{
    // Propiedades
    public string Num_ciclos { get; set; } = "";

    public double Tiempo_tomar { get; set; }

    public double Tiempo_trasladar { get; set; }

    public double Tiempo_soltar { get; set; }

    // Método para calcular el tiempo total de operación del brazo robotico
    public double tiempototal()
    {
        double tiempototal;

        tiempototal = (Tiempo_tomar + Tiempo_trasladar + Tiempo_soltar);

        return tiempototal;
    }

    // Método para calcular el tiempo total de operación del brazo robótico
    public double TiempoTotalCiclo()
    {
        double tiempoTotal = Tiempo_tomar + Tiempo_trasladar + Tiempo_soltar;
        return tiempoTotal;
    }

    // Método para simular la producción y mostrar resultados
    public void SimularProduccion()
    {
        double tiempoCiclo = TiempoTotalCiclo();
        double tiempoTotal = 0;

        Console.WriteLine($"\nTiempo de un ciclo: {tiempoCiclo:F2} s\n");

        for (int i = 1; i <= Num_ciclos; i++)
        {
            tiempoTotal += tiempoCiclo;
            Console.WriteLine($"Después del ciclo {i}: {tiempoTotal:F2} s acumulados");
        }

        Console.WriteLine($"\nTiempo total de producción: {tiempoTotal:F2} s");
    }

}


