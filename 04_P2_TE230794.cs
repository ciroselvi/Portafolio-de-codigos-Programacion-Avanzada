Console.WriteLine("SISTEMA DE CARGA DE BATERIA");
Console.WriteLine();

// Crear un objeto de la clase Bateria
Bateria bateria1 = new Bateria();

// Capturar la información del objeto
Console.Write("INGRESE EL VOLTAJE INICIAL (V): ");
bateria1.VoltajeInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("INGRESE EL INCREMENTO DE VOLTAJE POR CICLO (V): ");
bateria1.IncrementoVoltaje = Convert.ToDouble(Console.ReadLine());

// Solicitar al objeto que cargue la bateria
bateria1.CargarBateria();

// Mostrar resultado final
Console.WriteLine();
Console.WriteLine($"Voltaje final: {bateria1.VoltajeInicial:F2} V");
Console.WriteLine("BATERIA CARGADA.");



// Definicion de la clase
class Bateria
{
    // Propiedades
    public double VoltajeInicial { get; set; }

    public double IncrementoVoltaje { get; set; }


    // Metodo para cargar la bateria
    public void CargarBateria()
    {
        int ciclo = 0;

        while (VoltajeInicial < 12.6)
        {
            ciclo++;

            VoltajeInicial = VoltajeInicial + IncrementoVoltaje;

            if (VoltajeInicial > 12.6)
            {
                VoltajeInicial = 12.6;
            }

            Console.WriteLine($"Ciclo {ciclo}: {VoltajeInicial:F2} V");
        }
    }
}