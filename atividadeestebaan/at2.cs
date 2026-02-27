using System;

class Program
{
    static void Main()
    {
        double a, b, c, r, s, d;

        Console.WriteLine("digite o primeiro numero");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o segundo numero");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("digite o terceiro numero");
        c = double.Parse(Console.ReadLine());

        r = math.pow(a + b, 2);
        s = math.pow(b + c, 2);
        d = math.pow(r + s, 2) / 2;

        console.WriteLine(" o valor de d e: " + d);





    }
}