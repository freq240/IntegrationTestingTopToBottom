using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTesting
{
    // ManualArr.cs
    class ManualArr
    {
       
        public static int[] CreateArr(int low, int high, bool test = false)
        {
            if (low > high)
            {
                int temp = high;
                high = low;
                low = temp;
            }
            int N;
            if (test == false)
            {
                Console.Write("Input N value = ");
                N = Int32.Parse(Console.ReadLine());
            }
            else
            {
                N = 10;
            }
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(low, high);
            }

            return arr;
        }

        
        public static void PrintArr(int[] arr, bool test = false)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (test == false)
                {
                    Console.Write($"{arr[i]} ");
                }
                else
                {
                    arr[i] = 0;
                }
               
            }
            if (test == false)
            {
                Console.WriteLine();
            }
        }
    }
}
