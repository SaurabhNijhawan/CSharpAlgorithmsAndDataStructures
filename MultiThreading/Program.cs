using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thread ID: {0} Main thread was called ", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Processor / Core count on this Machine: {0}", Environment.ProcessorCount);

            var doSomeWorkThreadStartDelegate = new ParameterizedThreadStart(DoSomeWorkWithParameter);

            var thread = new Thread(() =>
            {
                int x = 2;
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(i);
                }
            });

            thread.Start();
            var doSomeWorkThread = new Thread(doSomeWorkThreadStartDelegate)
            {
                Name = "DoSomeWork Thread",
                Priority = ThreadPriority.Normal
            };

            doSomeWorkThread.Start();

            //doSomeWorkThread.Join();

            Console.WriteLine("Main thread ended with ThreadId: {0}", Thread.CurrentThread.ManagedThreadId);

        }
        public static void WaysToStartThreads()
        {
            // 1
            // Passing the name of the method name to be executed in the ctor directly without using ThreadStart
            var thread1 = new Thread(DoSomeWork);
            thread1.Start();

            // 2
            // Passing the ThreadStart delegate  which points to a method name to be executed
            var threadStart = new ThreadStart(DoSomeWork);
            var thread2 = new Thread(threadStart);
            thread2.Start();

            // 3
            // Passing the ParametrizedThreadStart delegate  which points to a method to be executed
            var parametrizedThreadStart = new ParameterizedThreadStart(DoSomeWorkWithParameter);
            var thread3 = new Thread(parametrizedThreadStart);
            thread3.Start(2);

            // 4
            // Passing a Lambda expression in the Thread class constructor and subsequently calling the Start method
            var thread4 = new Thread(() =>
            {
                int x = 5;
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine(i);
                }
            });

            thread4.Start();

            // 5
            // Leveraging ThreadPools, call ThreadPool.QueueUserWorkItem passing in the method name to be executed
            ThreadPool.QueueUserWorkItem(DoSomeWorkWithParameter);
            ThreadPool.QueueUserWorkItem(DoSomeWorkWithParameter, 4);

            // 6
            // Using TPL (Task Parallel Library). Create a Task<T>, where T is the return type of the method to be executed.
            Task<string> task = Task.Factory.StartNew<string>(DoSomeStringWork);
            var result = task.Result;

            // 7
            // Using Asynchronous Delegates 
            Func<string, string> work = DoSomeStringWork;
            IAsyncResult res = work.BeginInvoke("Hello", null, null);
            string result1 = work.EndInvoke(res);

            ////TODO: Explicit use of Thread class

//Threadpool

//Task Parallel Library

//Action class with lambda functions

//BeginInvoke

//BackgroundWorker

        }

        static void DoSomeWorkWithParameter(object a)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Do some work invoked, Thread Id:{0}", i);
            }

        }

        static void DoSomeWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Do some work invoked, Thread Id:{0}", i);
            }

        }

        static string DoSomeStringWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Do some work invoked, Thread Id:{0}", i);
            }
            return "a";
        }

        static string DoSomeStringWork(string a)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Do some work invoked, Thread Id:{0}", i);
            }
            return "a";
        }
    }
}
