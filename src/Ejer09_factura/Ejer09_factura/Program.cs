// Factura con descuento e IVA Juan Galindez
//Variables
double subtotal, total, descuento, iva;
//Ingreso de datos
Console.Write("Ingrese el subtotal del producto ");
subtotal = Convert.ToDouble(Console.ReadLine());
//Proceso
descuento = subtotal * 0.10;
iva = descuento * 0.19;
total = subtotal + iva - descuento;
//Salida
Console.WriteLine($"El iva es: {iva}, el descuento es de: {descuento} y el valor total del producto es de: {total}");