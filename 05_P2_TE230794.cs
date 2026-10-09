
Console.WriteLine("SISTEMA DE POSICIONAMIENTO PARA SERVOMOTOR");
Console.WriteLine();

// Crear un objeto de la clase. En este caso Servomotor
Servomotor motor1 = new Servomotor();

// Se le solicita al usuario que ingrese la posicion actual y la posicion objetivo del servomotor
Console.Write("Ingrese la posicion actual (0 a 180 grados): ");
motor1.PosicionActual = Convert.ToDouble(Console.ReadLine());

// Se valida la posicion actual ingresada por el usuario para asegurarse de que esté dentro del rango permitido (0 a 180 grados)
while (motor1.PosicionActual < 0 || motor1.PosicionActual > 180)
{
    Console.WriteLine("Error: la posicion debe estar entre 0 y 180 grados.");
    Console.Write("Ingrese nuevamente la posicion actual: ");
    motor1.PosicionActual = Convert.ToDouble(Console.ReadLine());
}

// Ingresar la posicion deseada del servomotor
Console.Write("Ingrese la posicion deseada (0 a 180 grados): "); 
motor1.PosicionObjetivo = Convert.ToDouble(Console.ReadLine());

// Validar la posicion objetivo
while (motor1.PosicionObjetivo < 0 || motor1.PosicionObjetivo > 180)
{
    Console.WriteLine("Error: la posicion debe estar entre 0 y 180 grados.");
    Console.Write("Ingrese nuevamente la posicion objetivo: ");
    motor1.PosicionObjetivo = Convert.ToDouble(Console.ReadLine());
}

// Calcular el desplazamiento
double desplazamiento = motor1.CalcularDesplazamiento();

// Mostrar resultados
Console.WriteLine();
Console.WriteLine($"Posicion actual: {motor1.PosicionActual} grados");
Console.WriteLine($"Posicion objetivo: {motor1.PosicionObjetivo} grados");
Console.WriteLine($"Desplazamiento absoluto: {desplazamiento} grados");
Console.WriteLine($"Movimiento: {motor1.ObtenerMovimiento()}");


// Definicion de la clase
class Servomotor
{
    // Propiedades
    public double PosicionActual { get; set; }

    public double PosicionObjetivo { get; set; }


    // Metodo para calcular el desplazamiento absoluto
    public double CalcularDesplazamiento()
    {
        double desplazamiento;

        if (PosicionObjetivo >= PosicionActual)
        {
            desplazamiento = PosicionObjetivo - PosicionActual;
        }
        else
        {
            desplazamiento = PosicionActual - PosicionObjetivo;
        }

        return desplazamiento;
    }


    // Metodo para determinar el tipo de movimiento
    public string ObtenerMovimiento()
    {
        if (PosicionObjetivo > PosicionActual)
        {
            return "Hacia una posicion mayor";
        }
        else if (PosicionObjetivo < PosicionActual)
        {
            return "Hacia una posicion menor";
        }
        else
        {
            return "No hay movimiento";
        }
    }
}
