/* conditionals */

// Console.WriteLine("Ingrese un número:");
// int num  = int.Parse(Console.ReadLine());
// if (num > 0)
// {
//     Console.WriteLine("El número es positivo");
// }
// else if (num < 0)
// {
//     Console.WriteLine("El número es negativo");
// }
// else
// {
//     Console.WriteLine("El número es cero");

/* end conditionals */

/* operators */

Console.WriteLine("Ingrese el primer número:");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número:");
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"Suma: {a + b}");
Console.WriteLine($"Resta: {a - b}");
Console.WriteLine($"Multiplicación: {a * b}");
Console.WriteLine($"División: {(b != 0 ? a / b : "No se puede dividir por cero")}");

/* end operators */