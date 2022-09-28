using System;
using System.Diagnostics;
using System.Collections.Specialized;

public class ChildProcess
{
    public static void Main()
    {
        try
        {
            string s;

            // Получаем текущий процесс
            System.Console.WriteLine("child process started");
            Process p = Process.GetCurrentProcess();
            System.Console.WriteLine("1");
            // Получаем блок окружения текущего процесса
            StringDictionary env = p.StartInfo.EnvironmentVariables;
            System.Console.WriteLine("2");
            // Для каждого ключа в блоке окружения 
            // выводим его значение

            int function = -1;
            double min = 0;
            double max = 100;
            double step = 0.5;

            foreach (string key in env.Keys)
            {
                Console.WriteLine(string.Format("{0} = {1}", key, env[key]));
            }

            foreach (string key in env.Keys)
            {

                if (key == "function")
                {

                    function = Convert.ToInt32(env[key]);

                }
                if (key == "min")
                {
                    min = Convert.ToDouble(env[key]);
                }
                if (key == "max")
                {
                    max = Convert.ToDouble(env[key]);
                }
                if (key == "step")
                {
                    step = Convert.ToDouble(env[key]);
                }

            }

            if (function == 1)
            {
                while (min < max)
                {
                    Console.WriteLine("|" + min + "|" + Math.Sin(min) + "|");
                    min = min + step;
                }
            }

            if (function == 2)
            {
                while (min < max)
                {
                    Console.WriteLine("|" + min + "|" + Math.Cos(min) + "|");
                    min = min + step;
                }
            }

            if (function == 3)
            {
                while (min < max)
                {
                    Console.WriteLine("|" + min + "|" + min * min + "|");
                    min = min + step;
                }
            }

            if (function == 4)
            {
                while (min < max)
                {
                    Console.WriteLine("|" + min + "|" + Math.Pow(2.71, min) + "|");
                    min = min + step;
                }
            }

            if (function == 5)
            {
                while (min < max)
                {
                    Console.WriteLine("|" + min + "|" + Math.Log(min) + "|");
                    min = min + step;
                }
            }

            if (function == 6)
            {
                while (min < max)
                {
                    System.Console.WriteLine("|" + min + "|" + Math.Atan(min) + "|");

                }
            }

            if (function == -1)
            {
                System.Console.WriteLine("please select function as console argument");
                System.Console.WriteLine("like function n");
            }

        }
        catch (Exception e)
        {
            System.Console.WriteLine(e);
        }

    }

}

