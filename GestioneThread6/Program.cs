using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneThread6
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerThread = new Thread(() =>
            {
                try
                {
                    Console.WriteLine("Inizio di un thread molto lungo");

                    Thread.Sleep(5000);

                    Console.WriteLine("Termine worker thread");
                }
                catch (ThreadAbortException ex)
                {
                    Console.WriteLine("Il processo è stato ammazzato");
                }
            });

            workerThread.Start();
            workerThread.Join(500);

            if (workerThread.ThreadState != ThreadState.Stopped)
            {
                workerThread.Abort();
            }


            Console.ReadLine();
        }
    }
}
