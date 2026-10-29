// Area y perimetro de un rectangulo
// variables
double b, h, a, a2, p;
//Ingreso de datos
Console.Write("Ingrese la base de su rectangulo por favor ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Ahora ingrese la altura ");
h = Convert.ToInt32(Console.ReadLine());
//Proceso
a = b * h;
p = 2 * (b + h);
Console.WriteLine($"El area de su rectangulo es: {a}");
Console.WriteLine($"El perimetro de su rectangulo es: {p}");
//Area con base duplicada y altura triplicada
Console.Write("Ahora se duplicara la base y se triplicara la altura. ");
a2 = (b * 2) * (h * 3);
Console.WriteLine($"El area con base duplicada y altura triplicada es: {a2}");