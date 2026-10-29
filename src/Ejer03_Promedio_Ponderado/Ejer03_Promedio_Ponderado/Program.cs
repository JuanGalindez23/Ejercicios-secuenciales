//Progama para promedios ponderados
// variables
double nota1, nota2, nota3, promedio;

//Proceso
Console.Write("Ingrese la nota 1 ");
nota1 = Convert.ToInt32(Console.ReadLine());
Console.Write("ingrese la nota 2 ");
nota2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la nota 3 ");
nota3 = Convert.ToInt32(Console.ReadLine());
promedio = nota1 * 0.20 + nota2 * 0.30 + nota3 * 0.40;

//Salida
Console.WriteLine($"El promedio ponderado de las notas ingresadas es: {promedio}");