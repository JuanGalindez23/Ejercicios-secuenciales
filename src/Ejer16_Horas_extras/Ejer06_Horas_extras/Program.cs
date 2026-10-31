//Calcular el total a pagar con horas extras
//Juan Galindez
//Variables
double ValorHora, HorasTrabajadas, HorasExtras, SalBase, PagoExtra, Total;
//Ingreso de datos
Console.Write("Ingrese las horas mensuales trabajadas ");
HorasTrabajadas = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el valor por hora ");
ValorHora = Convert.ToDouble(Console.ReadLine());
//Proceso
SalBase = HorasTrabajadas * ValorHora;
Console.WriteLine($"El salario base es: {SalBase}");
HorasExtras = HorasTrabajadas - 160;
PagoExtra = (HorasExtras * ValorHora) * 1.25;
Console.WriteLine($"El pago por horas extras es: {PagoExtra}");
Total = SalBase +  PagoExtra;
Console.WriteLine($"El salario total es: {Total}");