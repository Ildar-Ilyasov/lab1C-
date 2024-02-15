class Program
{
    static void Main(string[] args)
    {
        double x = 0.5;
        double epsilon = 0.0001; 
        double result = 0;
        int n = 0;

        while (true)
        {
            double term = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (2 * n + 1);
            if (Math.Abs(term) < epsilon)
            {
                break;
            }
            result += term;
            n++;
        }


        double arctanX = Math.Atan(x);

        Console.WriteLine("Арктангенс x: " + arctanX);
        Console.WriteLine("Сумма ряда: " + result);
    }
}