using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
     class Program
    {
        //private int count=0;



        static void Main(string[] args)
        {
            Counter count = Counter.Getinstance;
            count.Increment();
            count.Decrement();
            count.Display();
            // Counter s1 = Counter.Getinstance.Increment();
            // Increment();
           //Console.WriteLine("Counter Value", count);
            Console.Read();
        }

        public class Counter
        {
            private int count = 0;
            private static Counter instance = null;
            private Counter() { }

            public static Counter Getinstance 
            {
                get { 
                    if (instance == null)
                    {
                        instance = new Counter();
                    }
                    return instance; 
                } 
            
            }

            public int Increment()
            {
                //int count = 0;
                return count++;
                // Console.WriteLine(count.ToString());
            }

            public int Decrement()
            {
                //int count = 0;
                return count--;
                // Console.Write("Counter Value" +count.ToString());
            }

            public void Display()
            {
                Console.WriteLine(count);
            }
            // Console.WriteLine("Counter Value", count);

        }

      
    }
}
