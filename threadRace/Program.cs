using System;
using System.Threading;

namespace threadRace;

class Program
{
    static void Main(string[] args)
    {
        var threadX = new Thread(delegate () { printX(); });
        var threadY = new Thread(delegate () { printY(); });
        threadX.Start();
        threadY.Start();

    }

    static void printX()
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("X");

            }
            Console.WriteLine();
        }
    }

    static void printY()
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write("Y");

            }
            Console.WriteLine();
        }
    }
}