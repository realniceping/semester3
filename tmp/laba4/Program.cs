using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace laba4;

class Program
{

    static void Main(string[] args)
    {
        System.Console.WriteLine(DllImporter.GetAnswerOfLife());
    }

}

public class DllImporter
{
    [DllImport("./Functions.dll", CharSet = CharSet.Ansi)]
    public static extern int GetAnswerOfLife();
}

