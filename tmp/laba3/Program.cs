using System;
using System.Runtime.InteropServices;

namespace laba3;


class Program
{

    static void Main(string[] args)
    {
        int menu = 10;



        while (menu != 0)
        {
            Console.Write(">> ");
            menu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(menu);

            if (menu == 1)
            {
                try
                {
                    Console.WriteLine("TheFunc -- test");
                    for (int i = 0; i <= 10; i++)
                    {
                        double x = Dll1Connector.TheFunc(i);
                        Console.WriteLine($"| {i} | {x}");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }


                try
                {
                    Console.WriteLine("FuncName -- test");
                    IntPtr ptri = Dll1Connector.FuncName();
                    Console.WriteLine($"result = {ptri}");
                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("Func name not found");
                }
            }

            if (menu == 2)
            {
                try
                {
                    Console.WriteLine("TheFunc -- test");
                    for (int i = 0; i <= 10; i++)
                    {
                        double x = Dll2Connector.TheFunc(i);
                        Console.WriteLine($"| {i} | {x}");
                    }
                }
                catch (BadImageFormatException)
                {

                    Console.WriteLine("TheFunc not found!");
                }

                try
                {
                    Console.WriteLine("FuncName -- test");

                    IntPtr ptri = Dll2Connector.FuncName();
                    Console.WriteLine($"result = {ptri}");

                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("Func name not found");
                }
            }

            if (menu == 3)
            {
                try
                {
                    Console.WriteLine("TheFunc -- test");
                    for (int i = 0; i <= 10; i++)
                    {
                        double x = Dll3Connector.TheFunc(i);
                        Console.WriteLine($"| {i} | {x}");
                    }
                }
                catch (BadImageFormatException)
                {

                    Console.WriteLine("TheFunc not found!");
                }

                try
                {
                    Console.WriteLine("FuncName -- test");
                    IntPtr ptri = Dll3Connector.FuncName();
                    Console.WriteLine($"result = {ptri}");

                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("Func name not found");
                }
            }

            if (menu == 4)
            {
                try
                {
                    Console.WriteLine("TheFunc -- test");
                    for (int i = 0; i <= 10; i++)
                    {
                        double x = Dll4Connector.TheFunc(i);
                        Console.WriteLine($"| {i} | {x}");
                    }
                }
                catch (BadImageFormatException)
                {

                    Console.WriteLine("TheFunc not found!");
                }

                try
                {
                    Console.WriteLine("FuncName -- test");
                    IntPtr ptri = Dll4Connector.FuncName();
                    Console.WriteLine($"result = {ptri}");

                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("Func name not found");
                }
            }

            if (menu == 5)
            {
                try
                {
                    Console.WriteLine("TheFunc -- test");
                    for (int i = 0; i <= 10; i++)
                    {
                        double x = Dll5Connector.TheFunc(i);
                        Console.WriteLine($"| {i} | {x}");
                    }
                }
                catch (BadImageFormatException)
                {

                    Console.WriteLine("TheFunc not found!");
                }

                try
                {
                    Console.WriteLine("FuncName -- test");
                    IntPtr ptri = Dll5Connector.FuncName();
                    Console.WriteLine($"result = {ptri}");

                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("Func name not found");
                }
            }

            if (menu == 6)
            {
                try
                {
                    Console.WriteLine("TheFunc -- test");
                    for (int i = 0; i <= 10; i++)
                    {
                        double x = Dll6Connector.TheFunc(i);
                        Console.WriteLine($"| {i} | {x}");
                    }
                }
                catch (BadImageFormatException)
                {

                    Console.WriteLine("TheFunc not found!");
                }

                try
                {
                    Console.WriteLine("FuncName -- test");
                    IntPtr ptri = Dll6Connector.FuncName();
                    Console.WriteLine($"result = {ptri}");

                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("Func name not found");
                }
            }

        }



    }
}




