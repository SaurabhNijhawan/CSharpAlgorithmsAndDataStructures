using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());

            while (testCases > 0)
            {
                int[] inputs = Console.ReadLine().Split(' ').Select(s => Convert.ToInt32(s)).ToArray();

                for (int i = inputs[0]; i <= inputs[1]; i++)
                {
                    bool isPrime = true;

                    if (i == 1)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (int j = 2; j <= Math.Sqrt(i); j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    
                    if (isPrime)
                    {
                        Console.WriteLine(i);        
                    }
                
                }

                testCases--;
            }

        }

        class MyClass
        {
            protected int x = 0;

            private static void Funny(MyClass c, MyClass2 d)
            {
                d.x = 9;
                c.x = 0;
            }

            public void Add(int a)
            {
                return;
            }

            public void Add(float a)
            {
                return;
            }
            public void Add(double a)
            {
                return;
            }

            public void Add(object a)
            {
                return;
            }
        }

        class MyClass2: MyClass
        {
            public void MyFunc()
            {
                x = 0;
            }

            private static void Funny(MyClass c, MyClass2 d)
            {
                d.x = 9;
              
               
            }
        }
    }
}
