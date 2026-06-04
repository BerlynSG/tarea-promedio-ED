public class Promedio
{
    List<double> numeros = new List<double>();

    public void AddNumero(double numero)
    {
        if (numero <= 0) return;
        numeros.Add(numero);
    }

    public double CalcularPromedio()
    {
        if (numeros.Count == 0) return 0;
        double suma = 0;
        foreach (double numero in numeros)
        {
            suma += numero;
        }
        return suma / numeros.Count;
    }
}
