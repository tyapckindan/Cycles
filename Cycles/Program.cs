internal class Program
{
    private static void Main(string[] args)
    {
        double n = Convert.ToDouble(Console.ReadLine());
        double res = 0;

        for (int i = 0; i < n; i++)
        {
            res += (Math.Pow(-1, i) * Math.Pow(n, 2 * i)) / Factorial(2 * n - 1);
        }
        Console.WriteLine(res);
    }
    static double Factorial (double f)
    {
        double res = 1;
        for (double i = 1; i <= f; i++)
        {
            res *= i;
        }
        return res;
    }
}