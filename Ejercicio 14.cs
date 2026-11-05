using System;

namespace SistemaSensoresIndustriales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE MONITOREO DE SENSORES INDUSTRIALES");
            Console.WriteLine("1. Sensor de Temperatura");
            Console.WriteLine("2. Sensor de Presión");
            Console.WriteLine("3. Sensor de Distancia");
            Console.Write("Seleccione el tipo de sensor (1-3): ");

            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    SensorTemperatura sensorTemp = new SensorTemperatura();
                    sensorTemp.CapturarDatosBase(); // Heredado de Sensor
                    sensorTemp.MostrarDatosBase();  // Heredado de Sensor
                    Console.WriteLine($"Evaluación: {sensorTemp.EvaluarTemperatura()}");
                    break;

                case 2:
                    SensorPresion sensorPres = new SensorPresion();
                    sensorPres.CapturarDatosBase(); // Heredado de Sensor
                    sensorPres.MostrarDatosBase();  // Heredado de Sensor
                    Console.WriteLine($"Evaluación: {sensorPres.EvaluarPresion()}");
                    break;

                case 3:
                    SensorDistancia sensorDist = new SensorDistancia();
                    sensorDist.CapturarDatosBase(); // Heredado de Sensor
                    sensorDist.MostrarDatosBase();  // Heredado de Sensor
                    Console.WriteLine($"Evaluación: {sensorDist.EvaluarDistancia()}");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }

    // CLASE BASE
    class Sensor
    {
        // Propiedades solicitadas 
        public string Identificador { get; set; } = "";
        public double Valormedio { get; set; }
        public bool Activo { get; set; }

        // Método para capturar los datos compartidos
        public void CapturarDatosBase()
        {
            Console.Write("Ingrese el identificador del sensor: ");
            Identificador = Console.ReadLine() ?? "Sin identificador";

            Console.Write("Ingrese el valor medio de medición: ");
            Valormedio = Convert.ToDouble(Console.ReadLine());

            Console.Write("¿El sensor está activo? (true/false): ");
            Activo = Convert.ToBoolean(Console.ReadLine());
        }

        // Método para mostrar los datos compartidos
        public void MostrarDatosBase()
        {
            Console.WriteLine("\nDATOS DEL SENSOR");
            Console.WriteLine($"Identificador: {Identificador}");
            Console.WriteLine($"Valor medio: {Valormedio}");
            Console.WriteLine($"Estado: {ObtenerEstado()}");
        }

        // Método requerido 
        public string ObtenerEstado()
        {
            return Activo ? "Activo" : "Inactivo";
        }
    }

    // CLASES DERIVADAS
    class SensorTemperatura : Sensor
    {
        public string EvaluarTemperatura()
        {
            if (Valormedio > 80.0)
                return "ALERTA: La temperatura supera el límite de 80 °C. ¡Requiere atención!";
            else
                return "La temperatura se encuentra dentro del criterio establecido.";
        }
    }

    class SensorPresion : Sensor
    {
        public string EvaluarPresion()
        {
            if (Valormedio > 10.0)
                return "ALERTA: La presión supera el límite de 10 bar. ¡Requiere atención!";
            else
                return "La presión se encuentra dentro del criterio establecido.";
        }
    }

    class SensorDistancia : Sensor
    {
        public string EvaluarDistancia()
        {
            if (Valormedio < 20.0)
                return "ALERTA: El objeto detectado está a menos de 20 cm. ¡Requiere atención!";
            else
                return "La distancia se encuentra dentro del criterio establecido.";
        }
    }
}