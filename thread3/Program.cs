using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread3
{
    class Program
    {
        static void Main(string[] args)
        {
            string someVariabile = "Matteo Fumanti";

            var workerThread = new Thread((o) =>
            {
                Thread.Sleep(500);
                Console.WriteLine("saluti da: {0}", someVariabile);
            });

            workerThread.Start();
            someVariabile = "Daniele Battaglia";

            Console.ReadLine();
        }
    }
}
