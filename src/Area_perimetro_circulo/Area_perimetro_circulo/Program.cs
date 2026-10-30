//Programa para calcular area y perimetro de un circulo
// variables
double a, r, p, TT;
// Ingreso de datos
Console.Write("Mi estimado homo sapien ingrese el radio de su circulo ");
r = Convert.ToDouble(Console.ReadLine());
TT = 3.1416;
a = TT * r * Math.Pow(r, 2);
p = 2 * TT * r;
Console.WriteLine($"Pana mio el area de su circulo es: {a} y el perimetro es: {p} ");