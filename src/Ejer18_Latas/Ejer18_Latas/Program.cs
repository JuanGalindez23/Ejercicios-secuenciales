//Pintura y latas Juan Galindez
//Variables
double MetrosCuadrados, Rendimiento, Litros, Latas, LitrosTotales, LitrosSueltos;
//Ingreso de datos
Console.Write("Ingresar los metros cuadrados a pintar ");
MetrosCuadrados = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresar el rendimiento por metro cuadrado ");
Rendimiento = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresar los litros por lata ");
Litros = Convert.ToDouble(Console.ReadLine());
//Procesos y Salida
Latas = Math.Ceiling((MetrosCuadrados/Rendimiento) /  Litros);
Console.WriteLine($"La cantidad de latas que se usaran son: {Latas}");
LitrosTotales = MetrosCuadrados / Rendimiento;
LitrosSueltos = (Litros * Latas) - LitrosTotales;
Console.WriteLine($"Los litros suletos son: {LitrosSueltos}");