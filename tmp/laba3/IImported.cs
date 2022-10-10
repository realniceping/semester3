using System.Runtime.InteropServices;


namespace laba3;

interface IImported
{
    [DllImport("%path%")]
    public static extern double TheFunc(double x);

    [DllImport("%path%")]
    public static extern IntPtr FuncName();
}