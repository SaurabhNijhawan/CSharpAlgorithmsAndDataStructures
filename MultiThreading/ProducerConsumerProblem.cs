using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class ProducerConsumerProblem
    {
        private readonly object mutex = new object();
        private Queue<int> Queue = new Queue<int>();
        private int index =0;
     
        
        public void Produce(int input)
        {
            lock (mutex)
            {
                Queue.Enqueue(input);
                Monitor.Pulse(mutex);
            }
        }

        public int Consume()
        {
            lock (mutex)
            {

                while (!Queue.Any())
                {
                    Monitor.Wait(mutex);
                }

                return Queue.Dequeue();

            }
        }
    }

}
