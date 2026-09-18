Console.WriteLine("EJERCICIO_5");                                    //Numero de la practica
Console.WriteLine("Promedio de n calificaciones");    //Nombre del ejercicio (Comprobar si un alumno es bueno estudiando o no)
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

double suma = 0;
for(int numero=1;numero<=5;numero++)
    {
    Console.Write($"Ingrese la primera calificación:{numero} ");
    double calificacion1 = Convert.ToDouble(Console.ReadLine());
    suma = suma + calificacion1;
}
double promedio = (suma) / 5.0;
if (promedio <= 50.99)
{
    Console.WriteLine($"El promedio del alumno es: {promedio:F2}"); //$ es para conectar diferentes caracteres y F2 parala cantidad de decimales
    Console.WriteLine("El alumno tiene un desempeño defisiente.");
}
else if (promedio <= 69.99)
{
    Console.WriteLine($"El promedio del alumno es: {promedio:F2}"); //$ es para conectar diferentes caracteres y F2 parala cantidad de decimales
    Console.WriteLine("El alumno necesita apoyo.");
}
else if (promedio <= 79.99)
{
    Console.WriteLine($"El promedio del alumno es: {promedio:F2}"); //$ es para conectar diferentes caracteres y F2 parala cantidad de decimales
    Console.WriteLine("El alumno tiene un desempeño regular.");
}
else if (promedio <= 89.99)
{
    Console.WriteLine($"El promedio del alumno es: {promedio:F2}"); //$ es para conectar diferentes caracteres y F2 parala cantidad de decimales
    Console.WriteLine("El alumno tiene un desempeño decente.");
}
else if (promedio <= 100.0)
{
    Console.WriteLine($"El promedio del alumno es: {promedio:F2}"); //$ es para conectar diferentes caracteres y F2 parala cantidad de decimales
    Console.WriteLine("El alumno tiene un desempeño Excelente.");
}