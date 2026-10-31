//¿ Negocio o perdida ? Juan Galindez
//Variables
double Costo, Precio, UnidadesVendidas, GananciaTotal, PdeRend;
//Ingreso de datos
Console.Write("Ingrese el costo de produccion: ");
Costo = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el precio por unidad: ");
Precio = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese las unidades vendidas: ");
UnidadesVendidas = Convert.ToDouble(Console.ReadLine());
//Proceso y salida
GananciaTotal = Precio * UnidadesVendidas;
Console.WriteLine($"La ganancia total es: {GananciaTotal}");
PdeRend = (GananciaTotal - Costo) / Costo;
Console.WriteLine($"El porcentaje de rendimiento es {PdeRend}% ");