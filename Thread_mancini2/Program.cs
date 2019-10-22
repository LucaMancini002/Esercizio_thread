using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_mancini2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(() =>
            {
                  Console.WriteLine("My thread è iniziato");
                  Thread.Sleep(1000);//tempo di attesa (1 secondo)
                  Console.WriteLine("My thread è terminato");
            });
            //esecuzione di my thread
            mythread.Start();

            Thread.Sleep(500);// 1/2 secondo
            Console.WriteLine("Main thread");

            Console.ReadLine();

        }
    }
}
