using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTesting
{
    class Stubs
    {
        // Stubs
        public static int[] FixArr()
        {
            int[] arr = { -5, -4, 0, -1, 5, 4, -20, 51, 25, 50 };

            return arr;
        }
        public static int[] RandomArr()
        {
            int N = 10;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-20, 20);
            }

            return arr;
        }
        public static int[] NegativeArr()
        {
            int[] arr = { -5, -4, -2, -1, -50, -42, -20, -51, -25, -50 };

            return arr;
        }
        public static int[] PositiveArr()
        {
            int[] arr = { 5, 4, 0, 1, 5, 4, 20, 51, 25, 50 };

            return arr;
        }
        public static int[] ZerosArr()
        {
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            return arr;
        }
        public static int[] EmptyArr()
        {
            int[] arr = { };

            return arr;
        }
        public static int[] SortOddArr()
        {
            int N = 10;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-50, 50);
            }

            //temp variable for holding larger value for switching
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //If the value is 'even' continue with outer loop
                if (arr[i] % 2 == 0)
                    continue;

                //Inner loop to compare arr values
                for (int j = (i + 1); j < arr.Length; j++)
                {
                    //If this value is not even do comparison
                    if (arr[j] % 2 != 0)
                    {
                        //If the left value is greater than the right value
                        //swap them
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            return arr;
        }
        public static int[] SortEvenArr()
        {
            int N = 10;
            int[] arr = new int[N];
            Random random = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(-50, 50);
            }

            //temp variable for holding larger value for switching
            int temp = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                //If the value is 'even' continue with outer loop
                if (arr[i] % 2 != 0)
                    continue;

                //Inner loop to compare arr values
                for (int j = (i + 1); j < arr.Length; j++)
                {
                    //If this value is not even do comparison
                    if (arr[j] % 2 == 0)
                    {
                        //If the left value is greater than the right value
                        //swap them
                        if (arr[i] > arr[j])
                        {
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            return arr;
        }
    }
}
