using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneThread5
{
    class Program
    {
        static void Main(string[] args)
        {
            var workThread = new Thread(() =>
            {
                Console.WriteLine("Inizio di un thread molto lungo");

                Thread.Sleep(5000);

                Console.WriteLine("Termine worker thread");
            });

            workThread.Start();
            workThread.Join(500);

            //se il worker thread è ancora in esecuzione lo si cancella
            if (workThread.ThreadState != ThreadState.Stopped)
            {
                workThread.Abort();
            }

            Console.WriteLine("Termine applicazione");

            Console.ReadLine();
        }
    }
}
