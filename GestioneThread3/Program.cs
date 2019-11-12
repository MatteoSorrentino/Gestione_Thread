using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneThread3
{
    class Program
    {
        static void Main(string[] args)
        {
            string someVariable = "Matteo Tumiati";

            Thread workedThread = new Thread(() =>
            {
                Thread.Sleep(500);
                Console.WriteLine("Saluti da: {0}", someVariable);
            });

            workedThread.Start();

            someVariable = "Daniele Bochicchio";

            Console.ReadLine();
        }
    }
}
