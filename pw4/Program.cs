internal class Program
{
    private static void Main(string[] args)
    {
        double x = Input("X");
        double a = Input("A");
        double b = Input("B");

        double y = (Math.Pow(Math.Cos(x), 2) + 2) / 3;
        double p = (Math.Pow(y, 5) * Math.Sqrt(a));
        double z = (p + 1) / (Math.Sin(b) + p);

        Console.WriteLine("Результат");
        Console.WriteLine($"Y = {Math.Round(y, 2)}");
        Console.WriteLine($"Z = {Math.Round(z, 2)}");

        Console.ReadKey();
    }

    private static double Input(string value)
    {
        Console.WriteLine($"Введіть {value}:");
        double result = Convert.ToDouble(Console.ReadLine());
        return result;
    }
}