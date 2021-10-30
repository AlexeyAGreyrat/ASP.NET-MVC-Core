using System;
using System.Threading;

namespace Lesson2
{
    internal class Program
    {
       
        private static void Main()
        {
            int maxPull = 8;
            using (var threadPool = new MyThreadPool(maxPull))
            {
                Console.WriteLine($"Количество Thread Pool: {threadPool.Count}");
                Random rnd = new Random();
                for (var i = 0; i < maxPull; i++)
                {
                    threadPool.QueueTask(() =>
                    {
                        var sleep = rnd.Next(1, 40) * 100;
                        Thread.Sleep(sleep);
                        Console.WriteLine($"Работа Thread {Thread.CurrentThread.ManagedThreadId} с названием {Thread.CurrentThread.Name} закончина {sleep} ms");
                    });
                }                
            }
        }
        
    }




    
}
