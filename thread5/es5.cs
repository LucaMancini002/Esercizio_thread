using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread5
{
    class es5
    {
        static void Main(string[] args)
        {
            var workerThread = new Thread(() =>
            {
                try
                {
                    Console.WriteLine("Inizio di un thread molto lungo");
                    Thread.Sleep(5000);
                    Console.WriteLine("Terminate worked thread");
                }
                catch(ThreadAbortException ex)
                {
                    Console.WriteLine("Il thread è stato abortito");
                }
          
            });

            workerThread.Start();
            workerThread.Join(500);
            //se il workerThread è ancora in esecuzione, il programma lo cancella
            if(workerThread.ThreadState != ThreadState.Stopped)
            {
                workerThread.Abort();
                Console.WriteLine("Il thread è stato abortito");
            }

            Console.WriteLine("Terimine applicazione");
            Console.ReadLine();
        }
    }
}
