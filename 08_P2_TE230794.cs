Console.WriteLine("U2-problemario-ejercicio 8");
Console.WriteLine();

// Crear un objeto de la clase Tanque
Tanque tanque1 = new Tanque();

// Capturar la información del objeto
Console.Write("Ingrese la capacidad máxima del tanque (L): ");
tanque1.Max_capacidad = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el volumen inicial del tanque (L): ");
tanque1.VolumenInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el volumen agregado por ciclo (L): ");
tanque1.VolumenAgregado = Convert.ToDouble(Console.ReadLine());

// Simulación del llenado
tanque1.SimularLlenado();
  
//deficion de la clase tanque
class Tanque
{
    //propiedades de la clase tanque
    public double Max_capacidad { get; set; }
    public double VolumenInicial { get; set; }
    public double VolumenAgregado { get; set; }

 
    // Método para simular el llenado del tanque
    public void SimularLlenado()
    {
        double volumenActual = VolumenInicial;

        Console.WriteLine("\n=== Simulación de llenado del tanque ===\n");

        while (volumenActual < Max_capacidad)
        {
            volumenActual += VolumenAgregado;

            if (volumenActual > Max_capacidad)
                volumenActual = Max_capacidad;

            double porcentaje = (volumenActual / Max_capacidad) * 100;

            Console.WriteLine($"Volumen actual: {volumenActual:F2} L");
            Console.WriteLine($"Porcentaje de llenado: {porcentaje:F2}%\n");
        }

        Console.WriteLine("Tanque lleno.");
    }
}