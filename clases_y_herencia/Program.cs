/* clases */

// var rect = new Rectangulo();
// rect.Base = 20;
// rect.Altura = 40;
// Console.WriteLine($"El area es: {rect.Area()}");
// Console.WriteLine($"El perimetro es: {rect.Perimetro()}");

/* End clases */

// var cuadr = new Cuadrado();
// cuadr.Base = 20;
// cuadr.Altura = 40;
// Console.WriteLine($"El area es: {cuadr.Area()}");
// Console.WriteLine($"El perimetro es: {cuadr.Perimetro()}");
// Console.WriteLine($"El lado es: {cuadr.Lado}");

var rect = new Rectangulo();
Console.Write("Ingrese la base del rectángulo: ");
rect.Base = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura del rectángulo: ");
rect.Altura = double.Parse(Console.ReadLine());
if (rect.Base <= 0 || rect.Altura <= 0)
{
    Console.WriteLine("La base y la altura deben ser números positivos.");
}
else
{
    Console.WriteLine($"El área del rectángulo es: {rect.Area()}");
    Console.WriteLine($"El perímetro del rectángulo es: {rect.Perimetro()}");
}

class Rectangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double Area()
    {
        return Base * Altura;
    }

    public double Perimetro()
    {
        return 2 * (Base + Altura);
    }
}


class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }
}

