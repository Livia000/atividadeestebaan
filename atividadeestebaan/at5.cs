using System;

class Program
{
    static void Main()
    {
        int a, b, c;
        int maior;
        int soma;

        Console.Write("digite um valor para A ");
        a = int.Parse(Console.ReadLine());

        Console.Write("digite um valor para B ");
        b = int.Parse(Console.ReadLine());

        Console.Write("digite um valor para C ");
        c = int.Parse(Console.ReadLine());

       
        if (a > b && a > c)
        {
            maior = a;
        }
        else if (b > a && b > c)
        {
            maior = b;
        }
        else
        {
            maior = c;
        }

        Console.WriteLine("o maior valor é: " + maior);

        soma = a + b + c;

        
        if (soma % 2 == 0)
        {
            Console.WriteLine("a soma e pa");
        }
        else
        {
            Console.WriteLine("a soma e impar ");
        }

        
    }
}