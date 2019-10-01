using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App_process
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione sulla gestione dei processi");
            Process.Start(@"C:\Users\studenti\Desktop\Gestione_progressi\App_process\HelloWorld.txt");
            Process.Start("Chrome.exe", @"https://www.google.com/search?q=lukaku&rlz=1C1GCEU_itIT821IT821&source=lnms&tbm=isch&sa=X&ved=0ahUKEwin-K3Rw_rkAhUCzKQKHQGbCf8Q_AUIEigB&biw=1920&bih=937#imgrc=XCSvVB3JVvC5SM:");
            var app = new Process();
            app.StartInfo.FileName=@"Notepad.exe";
            app.StartInfo.Arguments = @"C:\Users\studenti\Desktop\Gestione_progressi\App_process\HelloWorld.txt";
            app.Start();
            app.PriorityClass = ProcessPriorityClass.RealTime;
            //app.WaitForExit();
            Console.WriteLine("programma terminato");
            var processes = Process.GetCurrentProcess();
            foreach(var p in processes)
            {

            }
            Console.ReadLine();
        }
    }
}
