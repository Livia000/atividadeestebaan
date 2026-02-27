using System;


class at4
{
    static void Main()
    {
        int num = 10;

        Console.Write("digite um numero ");
        num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("o numero é par");
        }
        else
        {
            Console.WriteLine("o numero é impar");
        }


    }
}