using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.threads
{
    internal class TPLEx1
    {
        public static void Main0(string[] args)
        {
            Compare_parallelFor_For();
            Console.WriteLine("--------------------------------------------------");
            Compare_parallelFor_For_with_lock();
        }

        private static void Compare_parallelFor_For_with_lock()
        {
            Console.WriteLine("Comparing Parallel.For with lock and For loop with shared data  ....");

            // This example demonstrates the difference between parallel for and for loop in case of shared data .
            int counter = 0;
            Object lockObj = new Object();


            Parallel.For(0, 1000, i =>
            {
                lock (lockObj)
                {
                    counter++; // safe! bec lockobj is an object used as a mutual-exclusion (mutex) lock.
                }
            });

            Console.WriteLine($"using parallel for the result is :{counter} ");  // Likely less than 1000 due to race conditions

            int counter1 = 0;
            for (int i = 0; i < 1000; i++)
            {

                counter1++;  // Unsafe! Multiple threads modifying at once

            }

            Console.WriteLine($"using normal for the result is  :{counter1} ");  // 1000.
            // The output of counter1 will always be 1000, as it is executed sequentially in a single thread.


        }


        public static void Compare_parallelFor_For()
        {
            Console.WriteLine("Comparing Parallel.For and For loop with shared data...");

            // This example demonstrates the difference between parrallel for and for loop in case of shared data .
            int counter = 0;
            Object lockObj = new Object();


            Parallel.For(0, 1000, i =>
            {
               
                    counter++;  // Unsafe! Multiple threads modifying at once
               
            });

            Console.WriteLine($"using parallel for the result is :{counter} ");  // Likely less than 1000 due to race conditions

            int counter1 = 0;
            for (int i = 0; i < 1000; i++)
            {

                counter1++;  // Unsafe! Multiple threads modifying at once

            }

            Console.WriteLine($"using normal for the result is  :{counter1} " );  // 1000.
            // The output of counter1 will always be 1000, as it is executed sequentially in a single thread.



        }
    }
}
