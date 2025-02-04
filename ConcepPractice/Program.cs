using ConcepPractice.calculator;

namespace ConcepPractice;

class Program
{
    public static void Main(string[] args)
    {
        Fraccion fraccio1 = new Fraccion(2, 3);
        Fraccion fraccio2 = new Fraccion(4, 5);

        Fraccion suma = fraccio1.SumFraction(fraccio2);

        Console.WriteLine(suma);
    }
}

