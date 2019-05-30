using System;
using System.Collections.Generic;
using System.IO;
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
            // Check if our lucky number is divisible by three. If it's not, try 5, 7, etc since it's odd.
            // If it is, we take the square root and check if the new number is prime by seeing if it's divisible by any smaller number. If it is, that's our answer.
            // If not, we try to divide it again.

            //int f = 3;
            //double factorable = 600851475143;
            //while (true)
            //{
            //    if (factorable % f == 0)
            //    {
            //        factorable /= f;
            //        int test = (int)System.Math.Sqrt(factorable) + 1;
            //        for (int i = test; i > 1; i--)
            //        {
            //            if (factorable % i == 0)
            //            {
            //                test = 0;
            //                break;
            //            }
            //        }
            //        if (test != 0)
            //            break;
            //        f = 3;
            //    }
            //    else
            //        f += 2;
            //}
            //Console.WriteLine(factorable);
            //Console.ReadLine();

            // Problem 4
            // 999*999 is 99801, so that's our highest possible number. We'll count down from there.
            // For each number, check if it's a palindrome. If it is, figure out if it's divisible by a number under 1000
            // and then see if the answer to the division problem is under 1000, in which case the number is the largest palindrome 
            //that can be obtained by multiplying two numbers under 1000, making it the answer.
            // edit: all palindromics are divisible by 11, according to solutions so I added a check to increase speed.
            //char[] reverseArray;
            //for (int i = 998001; i > 0; i--)
            //{
            //    if (i % 11 == 0)
            //    {
            //        reverseArray = i.ToString().ToCharArray();
            //        Array.Reverse(reverseArray);
            //        if (i.ToString().Equals(new string(reverseArray)))
            //        {
            //            for (int j = 999; j > 99; j--)
            //            {
            //                if (i % j == 0)
            //                {
            //                    if (i / j < 1000)
            //                    {
            //                        Console.WriteLine("The answer is " + i);
            //                        Console.ReadLine();
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

            // Problem 5
            // Our number has to end in 0 if it's even and divisible by 10, and it is greater than or equal to 20*19 (380), since that's the smallest possible number we can get that the largest common factors work for.
            // So, we'll increment by 380 since that ends in 0.

            //for (int i = 380; i > 0; i += 380)
            //{
            //    if (i % 11 == 0 && i % 12 == 0 && i % 13 == 0
            //        && i % 14 == 0 && i % 15 == 0 && i % 16 == 0
            //        && i % 17 == 0 && i % 18 == 0)
            //    {
            //        Console.WriteLine(i);
            //        Console.ReadLine();
            //    }
            //}

            //Problem 6
            // We can take care of the duties of using all 100 numbers in the same loop.
            // We'll square each number for the sum of squares inside the loop and square the sum of the 100 after.

            //int squareOfSums = 0;
            //int sumOfSquares = 0;
            //for (int i = 1; i < 101; i++)
            //{
            //    squareOfSums += i;
            //    sumOfSquares += i * i;
            //}
            //Console.WriteLine((squareOfSums * squareOfSums) - sumOfSquares);
            //Console.ReadLine();

            // Problem 7
            // I'll re-use the prime-identifying code from before: square the number and see if we can divide it.
            // and just go up from there to count 10001 primes. Oh boy! I'll need to refigure this after.

            //int count = 6;
            //for (int i = 15; i > 0; i += 2)
            //{
            //    if (i % 3 != 0)
            //    {
            //        int test = (int)System.Math.Sqrt(i);
            //        for (int j = 2; j <= test; j++)
            //        {
            //            if (i % j == 0)
            //                break;
            //            if (j == test)
            //                count++;
            //        }
            //        if (count == 10001)
            //        {
            //            count = i;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("The answer is " + count);
            //Console.ReadLine();

            // Problem 9
            // loop through all possibilities and eliminate the faulty ones with properties of triples to save time.

            //double c = 1;
            //for (int i = 3; i < 1000; i++)
            //{
            //    for (int j = i + 1; j < 1000; j++)
            //    {
            //        if ((i % 3 == 0 || j % 3 == 0) && (i % 4 == 0 || j % 4 == 0))
            //        {
            //            c = Math.Sqrt(i * i + j * j);
            //            if (c % 1 == 0 && c % 2 != 0 && (i * j * c) % 60 == 0 && i + j + c == 1000)
            //            {
            //                Console.WriteLine("The answer is " + (i * j * c));
            //                Console.ReadLine();
            //            }
            //        }
            //    }
            //}  

            // Problem 10
            // sllooooow....


            //double sum = 17;

            //for (int i = 11; i < 2000000; i += 2)
            //{
            //    if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
            //    {
            //        for (int j = 3; j <= Math.Sqrt(i); j += 2)
            //        {
            //            if (i % j == 0)
            //                break;
            //            if (j + 2 > Math.Sqrt(i))
            //                sum += i;
            //        }
            //    }
            //}

            //Console.WriteLine(sum);
            //Console.ReadLine();

            //Problem 11
            // Read in the array, then we'll check every combo to see what's biggest

            //double biggest = 0;
            //double product = 0;
            //int[,] digits = new int[20,20];

            //using (TextReader reader = File.OpenText("11.txt"))
            //{
            //    for (int i = 0; i < 20; i++)
            //    {
            //        string text = reader.ReadLine();
            //        string[] bits = text.Split(' ');
            //        for (int j = 0; j < 20; j++)
            //        {
            //            digits[i, j] = int.Parse(bits[j]);
            //        }
            //    }
            //}
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 17; j++)
            //    {
            //        //horizontal
            //        product = digits[i, j] * digits[i, j + 1] * digits[i, j + 2] * digits[i, j + 3];
            //        if (product > biggest)
            //            biggest = product;
            //        //vertical
            //        product = digits[j, i] * digits[j + 1, i] * digits[j + 2,i] * digits[j + 3, i];
            //        if (product > biggest)
            //            biggest = product;
            //        //diagonal
            //        if (i < 17)
            //        {
            //            product = digits[i, j] * digits[i + 1, j + 1] * digits[i + 2, j + 2] * digits[i + 3, j + 3];
            //            if (product > biggest)
            //                biggest = product;
            //            product = digits[19-i, j] * digits[18-i, j + 1] * digits[17-i, j + 2] * digits[16-i, j + 3];
            //            if (product > biggest)
            //                biggest = product;
            //        }
            //    }
            //}
            //Console.WriteLine(biggest);
            //Console.ReadLine();

            //Problem 12

            int count = 0;
            int firstNumber = 0;
            int placer = 0;
            for (int i = 1; i >0; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {
                    placer += j;
                }
                for (int k = 1; k <= placer; k++)
                {
                    if(placer % k == 0)
                        count++;
                }
                if (count > 500)
                {
                    firstNumber = placer;
                    break;
                }
                count = 0;
                placer = 0;
            }
            Console.WriteLine(firstNumber);
            Console.ReadLine();
        }

    }
}
