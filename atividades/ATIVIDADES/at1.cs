using System;
class Program
{
    static void Main()
    {
        double x1, x2, y1, y2, d;

        Console.WriteLine("digite um numero para x1");
        x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("digite um numero para x2");
        x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("digite um numero para y1");
        y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("digite um numero para y2");
        y2 = double.Parse(Console.ReadLine());

        d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine(" a distancia entre esses pontos e: " + d);
    }
}