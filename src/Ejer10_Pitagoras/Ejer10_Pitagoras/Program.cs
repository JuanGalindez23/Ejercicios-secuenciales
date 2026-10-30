//Teorema de Pitagoras Juan Galindez
//Variables
double cat1, cat2, hip;
//Ingreso de datos
Console.Write("Ingrese el cateto 1 de su triangulo ");
cat1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el cateto 2 ");
cat2 = Convert.ToDouble(Console.ReadLine());
//Proceso
hip = Math.Sqrt(Math.Pow(cat1, 2) + Math.Pow(cat2, 2));
//Salida
Console.WriteLine($"La hipotenusa de su triangulo es: {hip} ");