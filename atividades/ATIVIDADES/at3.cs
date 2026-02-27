using System;


class at3
{
    static void Main()
    {
        double n1, n2, n3, media;

        Console.Write("digite a primeira nota ");
        n1 = double.Parse(Console.ReadLine());

        Console.Write("digite a saegunda nota");
        n2 = double.Parse(Console.ReadLine());

        Console.Write("digite a terceira nota");
        n3 = double.Parse(Console.ReadLine());

        media = (n1 * 2 + n2 * 3 + n3 * 5) / 10;

        Console.WriteLine("a media final das notas e " + media);
    }
}


