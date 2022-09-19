using System;
using System.Diagnostics;
using System.IO;

public class ParentProcess
{

  public static void Main(string[] args)
  {
    if (args.Length < 2)
    {
      Console.WriteLine("Использование:");
      Console.WriteLine(string.Format(
          "\t{0} [имя переменной] [значение переменной]", 
          System.Reflection.Assembly.GetEntryAssembly().Location
        ));
      return;
    }

    Console.WriteLine("Parent process started");
    
    Process myProcess = new Process();
    try
    {
      // необходимо для возможности установки переменных окружения
      myProcess.StartInfo.UseShellExecute = false;

      // устанавливаем значение переменной окружения 
      // для создаваемого процесса
      myProcess.StartInfo.EnvironmentVariables[args[0]] = args[1];
      myProcess.StartInfo.EnvironmentVariables[args[2]] = args[3];
      myProcess.StartInfo.EnvironmentVariables[args[4]] = args[5];
      myProcess.StartInfo.EnvironmentVariables[args[6]] = args[7];

      // указываем имя выполняемого файла для нового процесса
      // и запускаем его
      myProcess.StartInfo.FileName = "../child/bin/Debug/net6.0/child.exe";
      myProcess.Start();    

      // Ждём завершения дочернего процесса
      myProcess.WaitForExit();    
    } catch (Exception e) {
      Console.WriteLine(e.Message);
    }    

  }
  
}
