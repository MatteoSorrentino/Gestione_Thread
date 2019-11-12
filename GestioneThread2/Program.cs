using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneThread2
{
    class Program
    {
        static void Main(string[] args)
        {
            string someVariable = "Matteo Tumiati";

            Thread workedThread = new Thread((o) =>
            {
                Console.WriteLine("Saluti da: {0}", o);
            });

            workedThread.Start(someVariable);

            Console.ReadLine();
        }
    }
}
