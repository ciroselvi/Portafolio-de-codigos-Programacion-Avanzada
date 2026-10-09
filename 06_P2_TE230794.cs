
using System;

Console.WriteLine("SISTEMA DE INSPECCION DE PIEZAS");
Console.WriteLine();

// Crear un objeto de la clase InspeccionLote
InspeccionLote lote1 = new InspeccionLote();

lote1.TotalPiezas = 10;
lote1.PiezasCorrectas = 0;
lote1.PiezasDefectuosas = 0;

// Recorrer las diez piezas del lote
for (int i = 1; i <= lote1.TotalPiezas; i++)
{
    int estado;

    Console.WriteLine($"PIEZA {i} DE {lote1.TotalPiezas}");

    // Validar que el estado sea 0 o 1
    do
    {
        Console.Write("Ingrese 1 si es correcta o 0 si es defectuosa: ");

        bool valido = int.TryParse(Console.ReadLine(), out estado);

        if (!valido)
        {
            estado = -1;
        }

        if (estado != 0 && estado != 1)
        {
            Console.WriteLine("Valor invalido. Ingrese solamente 1 o 0.");
        }

    } while (estado != 0 && estado != 1);

    // Registrar el estado de la pieza
    lote1.RegistrarPieza(estado);

    Console.WriteLine();
}

// Calcular el porcentaje de piezas correctas
double porcentaje = lote1.CalcularPorcentaje();

// Mostrar los resultados
Console.WriteLine("RESULTADOS DE LA INSPECCION");
Console.WriteLine($"Piezas correctas: {lote1.PiezasCorrectas}");
Console.WriteLine($"Piezas defectuosas: {lote1.PiezasDefectuosas}");
Console.WriteLine($"Porcentaje de piezas correctas: {porcentaje:F2}%");
Console.WriteLine($"Estado del lote: {lote1.ObtenerEstadoLote()}");

// Definicion de la clase
class InspeccionLote
{
    // Propiedades
    public int PiezasCorrectas { get; set; }

    public int PiezasDefectuosas { get; set; }

    public int TotalPiezas { get; set; }

    public double PorcentajeCorrectas { get; set; }

    public string EstadoLote { get; set; } = "";

    // Metodo para registrar una pieza
    public void RegistrarPieza(int estado)
    {
        if (estado == 1)
        {
            PiezasCorrectas++;
        }
        else if (estado == 0)
        {
            PiezasDefectuosas++;
        }
    }

    // Metodo para calcular el porcentaje de piezas correctas
    public double CalcularPorcentaje()
    {
        PorcentajeCorrectas =
            (double)PiezasCorrectas / TotalPiezas * 100;

        return PorcentajeCorrectas;
    }

    // Metodo para determinar el estado del lote
    public string ObtenerEstadoLote()
    {
        if (CalcularPorcentaje() >= 90)
        {
            EstadoLote = "ACEPTADO";
        }
        else
        {
            EstadoLote = "RECHAZADO";
        }

        return EstadoLote;
    }
}