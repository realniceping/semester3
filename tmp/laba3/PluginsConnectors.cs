using System;
using System.Runtime.InteropServices;

namespace laba3;

class Dll1Connector : IImported
{

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib.dll", CharSet = CharSet.Ansi)]
    public static extern double TheFunc(double x);

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib.dll", CharSet = CharSet.Ansi)]
    public static extern IntPtr FuncName();

}

class Dll2Connector : IImported
{

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-1.dll", CharSet = CharSet.Ansi)]
    public static extern double TheFunc(double x);

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-1.dll", CharSet = CharSet.Ansi)]
    public static extern IntPtr FuncName();

}

class Dll3Connector : IImported
{

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-2.dll", CharSet = CharSet.Ansi)]
    public static extern double TheFunc(double x);

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-2.dll", CharSet = CharSet.Ansi)]
    public static extern IntPtr FuncName();

}

class Dll4Connector : IImported
{

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-3-1.dll", CharSet = CharSet.Ansi)]
    public static extern double TheFunc(double x);

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-3-1.dll", CharSet = CharSet.Ansi)]
    public static extern IntPtr FuncName();

}

class Dll5Connector : IImported
{

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-3-2.dll", CharSet = CharSet.Ansi)]
    public static extern double TheFunc(double x);

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-3-2.dll", CharSet = CharSet.Ansi)]
    public static extern IntPtr FuncName();
}

class Dll6Connector : IImported
{

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-3.dll", CharSet = CharSet.Ansi)]
    public static extern double TheFunc(double x);

    [DllImport(@"D:\semester3\semester3\tmp\laba3\PLUGINS\Lib2-2-3.dll", CharSet = CharSet.Ansi)]
    public static extern IntPtr FuncName();

}

// class DllTester<T> where T : IImported
// {
//     public static void TestDll(T dll)
//     {
//         try
//         {
//             double x = dll.TheFunc(10);
//             Console.WriteLine("TheFunc -- test");

//             for (int i = 0; i <= 10; i++)
//             {
//                 Console.WriteLine($"| {i} | {dll.TheFunc(i)}");
//             }

//         }
//         catch (EntryPointNotFoundException e)
//         {
//             Console.WriteLine("TheFunc not exist in this Dll");
//         }
//     }
// }