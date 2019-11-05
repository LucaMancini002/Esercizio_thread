using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread4
{
    class es4
    {
        static void Main(string[] args)
        {
            var list = new List<Thread>();

            for (int index = 0; index < 5; index++)
            {
                var myThread = new Thread((currentIndex) =>
                {
                    Console.WriteLine("Thread {0} è iniziato",currentIndex);
                    Thread.Sleep(500);
                    Console.WriteLine("Thread {0} è terminato", currentIndex);
                });
                myThread.Start(index);
                list.Add(myThread);
            }

            //attende il termine di tutti i thred prima di stampare
            foreach(Thread thread in list)
            {
                thread.Join(10000);//tempo di attesa
            }

            Console.WriteLine("Esecuzione di tutti i thread terminata");

            Console.ReadLine();
        }
    }
}
