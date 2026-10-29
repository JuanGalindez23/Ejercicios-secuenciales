// Intercambio con variable auxiliar

// Variables
double A, B, C;

//Proceso
Console.Write("Ingrese la variable A ");
A = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese la variable B ");
B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Los datos originales son: {A} y {B}");
C = A;
A = B;
B = C;

//Salida
Console.WriteLine($"Los datos de A y B intercambiados son respectivamente: {A} y {B} ");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadKey();