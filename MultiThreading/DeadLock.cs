using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
     class DeadLock
     {
         private int a;
         private readonly object lock1 = new object();
         private readonly object lock2 = new object();
         public void DeadlockExample()
         {
             Thread t = new Thread(Method);
             t.Start();
             Thread.CurrentThread.Name = "Main Thread";
             lock (lock1)
             {
                 Console.WriteLine("Lock1 acquired by:" + Thread.CurrentThread.Name);
                 Thread.Sleep(1000);

                 lock (lock2)
                 {
                     Console.WriteLine("Lock2 acquired by:" + Thread.CurrentThread.Name);
                     Thread.Sleep(1000);
                 }
             }

         }
         
         private void Method()
         {
             Thread.CurrentThread.Name = "Worker Thread";
             lock (lock2)
             {
                 Console.WriteLine("Lock2 acquired by:" + Thread.CurrentThread.Name);
                 Thread.Sleep(1000);

                 lock (lock1)
                 {
                     Console.WriteLine("Lock1 acquired by:" + Thread.CurrentThread.Name);
                     Thread.Sleep(1000);
                 }
             }

         }
     }
}
