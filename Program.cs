Console.WriteLine("EJERCICIO_3");                                    //Numero de la practica
Console.WriteLine("Clasificacion de actitudes de alumnos");    //Nombre del ejercicio (Comprobar si un alumno es bueno estudiando o no)
Console.WriteLine();                                                 //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: ");
double calificacion1 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 1

Console.Write("Ingrese la segunda calificación: ");
double calificacion2 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 2

Console.Write("Ingrese la tercera calificación: ");
double calificacion3 = Convert.ToDouble(Console.ReadLine());         //Declaramos la variable 3 

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0;
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
else if(promedio <=79.99)
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