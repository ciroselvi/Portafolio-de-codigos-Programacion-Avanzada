Console.WriteLine("EJERCICIO 4 DE PROBLEMARIO"); //nombre del ejercicio
Console.WriteLine("Durante una prueba se realizan ocho mediciones de corriente de un actuador eléctrico. Diseñe un programa que utilice un ciclo para introducir las ocho mediciones. Cada medición deberá clasificarse de la siguiente manera: "); //descripción del ejercicio

Console.WriteLine("Prueba de corriente del actuador eléctrico"); //descripcion del programa
double suma = 0; //variable para almacenar la suma de las mediciones
int normales = 0; //variable para contar las mediciones normales
int sobrecorrientes = 0; //variable para contar las mediciones de sobrecorriente

for (int i = 1; i <= 8; i++) //ciclo para introducir las ocho mediciones
{
    Console.Write($"Ingrese la corriente medida #{i} (A): "); //solicita al usuario que ingrese la medición
    double corriente = Convert.ToDouble(Console.ReadLine()); //convierte la entrada del usuario a un número decimal
    suma += corriente; //suma la medición a la variable suma

    if (corriente <= 5) //si la medición es menor o igual a 5, se considera normal
    {
        Console.WriteLine("MEDICIÓN NORMAL"); //incrementa el contador de mediciones normales
        normales++;
    }
    else
    {
        Console.WriteLine("SOBRECORRIENTE DETECTADA"); //incrementa el contador de mediciones de sobrecorriente
        sobrecorrientes++;
    }
}

double promedio = suma / 8; //calcula el promedio de las mediciones
Console.WriteLine($"\nCorriente promedio: {promedio:F2} A"); //muestra el promedio de las mediciones
Console.WriteLine($"Mediciones normales: {normales}"); //muestra el número de mediciones normales
Console.WriteLine($"Sobrecorrientes: {sobrecorrientes}"); //muestra el número de mediciones de sobrecorriente

if (sobrecorrientes == 0) //si no hay mediciones de sobrecorriente, el actuador está aprobado
{
    Console.WriteLine("RESULTADO: ACTUADOR APROBADO"); //muestra el resultado
}
else //si hay mediciones de sobrecorriente, el actuador requiere revisión
{
    Console.WriteLine("RESULTADO: EL ACTUADOR REQUIERE REVISIÓN"); //si hay mediciones de sobrecorriente, el actuador requiere revisión
}
