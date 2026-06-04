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
        double suma = 0;
        foreach (double numero in numeros)
        {
            suma += numero;
        }
        return numeros.Count > 0 ? suma / numeros.Count : 0;
    }
}
