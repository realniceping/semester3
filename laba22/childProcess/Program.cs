using System;
using System.Diagnostics;

public class ДочернийПроцесс
{
    public static void Main()
    {
        try
        {

            string s;
            double min = 0;
            double max = 0;
            double step = 0;
            int function = 0;
            // считываем текст со стандартного ввода
            // пока считанное значение не равно null
            // значение null означает конец потока
            int count = 0;
            while ((s = Console.ReadLine()) != "")
            {
                if (count == 0) { min = Convert.ToDouble(s); }
                if (count == 1) { max = Convert.ToDouble(s); }
                if (count == 2) { step = Convert.ToDouble(s); }
                if (count == 3) { function = Convert.ToInt32(s); }
                count++;
            }

            System.Console.WriteLine("---------------------------------");
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








            Console.WriteLine("-----------------------------------");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
