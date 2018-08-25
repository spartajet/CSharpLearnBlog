using System;
using System.Threading;
namespace CSharpAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var workThread=new Thread(NumberCountCoudDelay);
            Console.WriteLine($"work thread state: {workThread.ThreadState}");
            workThread.Abort();
            workThread.Start();
            workThread.Join();
            Console.WriteLine($"work thread state: {workThread.ThreadState}");
            Console.WriteLine("Work thread is stopped!!!");
        }

        /// <summary>
        /// 数数方法
        /// </summary>
        static void NumberCountCoudDelay(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Delay thread number is {i}");
                Console.WriteLine($"work thread state: {Thread.CurrentThread.ThreadState}");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
        
        /// <summary>
        /// 数数方法
        /// </summary>
        static void NumberCount(){
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main thread number is {i}");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}