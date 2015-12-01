using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiThreading;


namespace Multithreadin.Tests
{
    [TestClass]
    public class MultithreadingTests
    {
        [TestMethod]
        public void Multithreading_DeadLockExample_Should_Result_InDeadLock()
        {
            var m = new DeadLock();
            m.DeadlockExample();
        }

        [TestMethod]
        public void PoducerConsumerProblem_Should_Result_InDeadLock()
        {
            var producerConsumerProblem = new ProducerConsumerProblem();

            Thread.CurrentThread.Name = "Main Consumer Thread";
            var t1=new Thread(
              () => producerConsumerProblem.Produce(1));
            t1.Name = "Producer Thread";
            t1.Start();

            producerConsumerProblem.Consume();
          

            var t2 =new Thread(
                () =>
                {
                    for (int i = 0; i < 10; i++)
                    {
                        producerConsumerProblem.Produce(i);
                    }
                    
                }
                );

            t2.Name = "Producer Thread 2";
            t2.Start();

        }

    }
}
