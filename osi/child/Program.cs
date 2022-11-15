using System;
using System.Diagnostics;
using System.Collections.Specialized;

public class ChildProcess
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Child process started");

            // Получаем текущий процесс
            Process p = Process.GetCurrentProcess();
            Console.WriteLine(p);
            Console.WriteLine("Current process geted");

            List<string> value = new List<string>();
            value.Add(Environment.GetEnvironmentVariable("function"));

            value.Add(Environment.GetEnvironmentVariable("min"));

            value.Add(Environment.GetEnvironmentVariable("max"));

            value.Add(Environment.GetEnvironmentVariable("step"));


            System.Console.WriteLine(value.Count);
            foreach (string v in value)
            {
                System.Console.WriteLine(v);
            }

            int function = -1;
            double min = 0;
            double max = 10;
            double step = 0.5;

            if (value[0] != null && value[1] != null && value[2] != null && value[3] != null)
            {
                function = Convert.ToInt32(value[0]);
                min = Convert.ToDouble(value[1]);
                max = Convert.ToDouble(value[2]);
                step = Convert.ToDouble(value[3]);
            }

            Console.WriteLine("_______________");

            if (function == 1)
            {
                for (double i = min; i < max; i = i + step)
                {
                    Console.WriteLine("| " + i + " | " + Math.Sin(i) + " |");
                }
            }

            if (function == 2)
            {
                for (double i = min; i < max; i = i + step)
                {
                    Console.WriteLine("| " + i + " | " + Math.Cos(i) + " |");
                }
            }

            if (function == 3)
            {
                for (double i = min; i < max; i = i + step)
                {
                    Console.WriteLine("| " + i + " | " + i * i + " |");
                }
            }

            if (function == 4)
            {
                for (double i = min; i < max; i = i + step)
                {
                    Console.WriteLine("| " + i + " | " + Math.Pow(2.71, i) + " |");
                }
            }

            if (function == 5)
            {
                for (double i = min; i < max; i = i + step)
                {
                    Console.WriteLine("| " + i + " | " + Math.Log(i) + " |");
                }
            }

            Console.WriteLine("_______________");

            // Для каждого ключа в блоке окружения 
            // выводим его значение


        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

}
