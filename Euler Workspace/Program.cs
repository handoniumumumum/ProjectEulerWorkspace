using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            //Use modulus to check what's a multiple and add it if it is. 

            //int Sum = 0;

            //for (int i = 0; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //        Sum += i;

            //}
            //Console.WriteLine(Sum);
            //Console.ReadLine();

            // Problem 2
            // Use while to iterate the sequence.
            // Check that the second number is even. Add it to the sum if it is. Then keep the second number in a placeholder, add the first to the second and set the first equal to the original second.
            // End the loop when the second number goes over 4 million.

            //int next = 2;
            //int last = 1;
            //int placeholder = 0;
            //int sum = 0;

            //while (next < 4000000)
            //{
            //    if (next % 2 == 0)
            //        sum += next;
            //    placeholder = next;
            //    next += last;
            //    last = placeholder;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            // Problem 3
            // 

            int f = 3;
            int answer=0;

            double factorable = 600851475143;
            while(answer == 0)
            {

                if (factorable % f == 0)
                {
                    factorable /= f;
                    int test = (int)System.Math.Sqrt(factorable);

                    answer = test;
                    f = 3;
                }
                else
                    f += 2;   
            }
                        

            Console.WriteLine(answer);
            Console.ReadLine();





        }
    }
}
