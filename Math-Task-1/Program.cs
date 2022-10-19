internal class Program
{
    private static void Main(string[] args)
    {
        double x = 1825;
        double y = 18;
        double z = 3298;

        Console.WriteLine($@"Данные :
x={x} 
y={y}
z={z}");

        double w = y / x;
        double s = Math.Abs(Math.Pow(x, w) - Math.Sqrt(w));
        double i = y - x;
        double j = i * ((y + z / i) / (1 + (i * i)));
        Console.WriteLine($@"Первый ответ равен :
{s}");
        Console.WriteLine($@"Второй ответ равен :
{j}");
    }
}