using System;
using System.Diagnostics;
using System.IO;
public class РодительскийПроцесс
{
    public static void ОтправитьФайл(String FileName, Process p)
    {
        // открываем файл с переданным нам именем
        using (StreamReader stm = File.OpenText(FileName))
        {
            string s = "";
            // считываем из файла строки до тех пор, 
            // пока считанное значение не будет равно null,
            // что говорит нам о том, что достигнут конец файла
            while ((s = stm.ReadLine()) != null)
            {
                // отправляем каждую считанную строку
                // на стандартный ввод дочернего процесса
                p.StandardInput.WriteLine(s);
            }
        }
    }

    public static string ПолучитьОтвет(Process p)
    {
        string Результат = "";
        string s;
        while ((s = p.StandardOutput.ReadLine()) != null)
        {
            Результат = Результат + s + "\r\n";
        }
        return Результат;
    }

    public static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Использование:");
            Console.WriteLine(string.Format("\t{0} [путь до текстового файла]",
                System.Reflection.Assembly.GetEntryAssembly().Location
              ));
            return;
        }
        Console.WriteLine("Началось выполнение родительского процесса");
        Process myProcess = new Process();
        try
        {
            // необходимо для использования перенаправления
            myProcess.StartInfo.UseShellExecute = false;

            // запрашиваем перенаправление стандартного воода и вывода
            myProcess.StartInfo.RedirectStandardInput = true;
            myProcess.StartInfo.RedirectStandardOutput = true;
            // указываем имя выполняемого файла для нового процесса
            myProcess.StartInfo.FileName = @"ChildProcess.exe";
            myProcess.Start();
            // отправляем файл на стандартный ввод дочернего процесса
            ОтправитьФайл(args[0], myProcess);
            myProcess.StandardInput.Close();
            // считываем ответ дочернего процесса и печатаем его
            string Response = ПолучитьОтвет(myProcess);
            Console.WriteLine(Response);
            // Ждём завершения дочернего процесса
            myProcess.WaitForExit();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
