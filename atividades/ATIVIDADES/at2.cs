using System;using System;

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

        r = math.pow(a + b);
        s = math.pow(b + c);
        d = math.pow(r + s) / 2;

        console.WriteLine(" o valor de d e: " + d);





    }
}