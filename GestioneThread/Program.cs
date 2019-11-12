using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(() =>
            {
                Console.WriteLine("My thread è iniziato");
                Thread.Sleep(1000);
                Console.WriteLine("My thread è terminato");
            });

            //esecuzione di Mythread
            myThread.Start();

            Thread.Sleep(500);
            Console.WriteLine("Main Thread");


            Console.ReadLine();
        }
    }
}
