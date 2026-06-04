
var promedio = new Promedio();

Console.WriteLine("Ingrese números para calcular el promedio (ingrese 0 o menos para finalizar):");
while (true){
    Console.Write("Número: ");
    var input = Console.ReadLine();
    if (double.TryParse(input, out double numero))    {
        if (numero <= 0) break;
        promedio.AddNumero(numero);
    } else {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
    }
}
Console.WriteLine("------------------------------");
Console.WriteLine($"El promedio es: {promedio.CalcularPromedio()}");
