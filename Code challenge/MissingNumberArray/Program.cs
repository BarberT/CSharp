using System;

namespace MissingNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] searchArray = new int[] { 1, 2, 3, 4, 5, 7, 8, 9, 10 };

            int sizeOfArray = searchArray.Length;

            //Console.WriteLine(sizeOfArray);

            //Console.WriteLine("The missing number in the array is " + GetMissingNumber(searchArray, sizeOfArray));
            Console.WriteLine("The missing number in the array is " + GetMissingNumberXOR(searchArray, sizeOfArray));

        }


        public static int GetMissingNumber(int[] arr, int n)
        {
            // actual size is n+1 since a number is missing from the array
            int m = n + 1;

            // get sum of integers between 1 to n+1
            int total = m * (m + 1) / 2;

            // get actual sum of integers in the array
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            // the missing number is the difference between the expected sum
            // and the actual sum
            return total - sum;
        }

        public static int GetMissingNumberXOR(int[] arr, int n)
        {
            // C# XOR Operator (Bitwise)

            // Compute XOR of all the elements in array
            Console.WriteLine("Array");
            int xor = 0;
            for (int i = 0; i < n; i++)
            {
                xor = xor ^ arr[i];  // =^ arr[i]
                Console.WriteLine(xor);
            }

            // Compute XOR of all the elements from 1 to n+1
            Console.WriteLine("n+1");
            for (int i = 1; i <= n + 1; i++)
            {
                xor = xor ^ i; // =^ i
                Console.WriteLine(xor);
            }
                

            return xor;
        }
    }
}
