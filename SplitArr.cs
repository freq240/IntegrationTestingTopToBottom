using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationTesting
{
    // SplitArr.cs
    class SplitArr
    {
        // Functions
        public static int QuantityPositive(int[] arr)
        {
            int counter_positive = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    counter_positive++;
                }
            }

            return counter_positive;
        }
        public static int QuantityNegative(int[] arr)
        {
            int counter_negative = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    counter_negative++;
                }
            }

            return counter_negative;
        }
        public static int[] PositiveArr(int[] arr, int counter_pos)
        {
            int[] arr_pos = new int[counter_pos];
            int index_pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arr_pos[index_pos] = arr[i];
                    index_pos++;
                }
            }

            return arr_pos;
        }
        public static int[] NegativeArr(int[] arr, int counter_neg)
        {
            int[] arr_neg = new int[counter_neg];
            int index_neg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    arr_neg[index_neg] = arr[i];
                    index_neg++;
                }
            }

            return arr_neg;
        }
        public static int[] GetPosArr(int[] arr)
        {
            return PositiveArr(arr, QuantityPositive(arr));
        }
        public static int[] GetNegArr(int[] arr)
        {
            return NegativeArr(arr, QuantityNegative(arr));
        }
        public static void Split(int[] arr)
        {
            GetNegArr(arr);
            GetPosArr(arr);
        }
        

    }
}
