using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationTesting;

namespace IntegrationTesting
{
    class IntergrationTesting
    {
        // Testing SplitArr.cs
        public static void SplitArrTests()
        {
            int counter = 1;
            try
            {
                SplitArr.Split(Stubs.FixArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.RandomArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.NegativeArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.PositiveArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.ZerosArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.EmptyArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.SortEvenArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SplitArr.Split(Stubs.SortOddArr());
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] PASSED!");
                counter = 1;
            }
            catch
            {
                Console.WriteLine($"[<SplitArr.cs> TEST CASE {counter}] FAILED!");
            }
        }
        // Testing SortArr.cs
        public static void SortArrTests()
        {
            int counter = 1;
            try
            {
                SortArr.SortArray(Stubs.FixArr());
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SortArr.SortArray(Stubs.RandomArr());
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SortArr.SortArray(Stubs.NegativeArr());
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SortArr.SortArray(Stubs.PositiveArr());
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SortArr.SortArray(Stubs.ZerosArr());
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                SortArr.SortArray(Stubs.EmptyArr());
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] PASSED!");
                counter = 1;
            }
            catch
            {
                Console.WriteLine($"[<SortArr.cs> TEST CASE {counter}] FAILED!");
            }
        }
        // Testing ManualArr.cs
        public static void ManualArrTests()
        {
            int counter = 1;
            try
            {
                ManualArr.CreateArr(-50, -20, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                ManualArr.CreateArr(-20, 0, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                ManualArr.CreateArr(0, 0, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                ManualArr.CreateArr(0, 20, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                ManualArr.CreateArr(20, 50, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                ManualArr.CreateArr(-150, 150, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter++;

                ManualArr.CreateArr(150, -150, true);
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] PASSED!");
                counter = 1;
            }
            catch
            {
                Console.WriteLine($"[<ManualArr.cs> TEST CASE {counter}] FAILED!");
            }
        }

        // manual test function
        public static void StartTesting()
        {
            SplitArrTests();
            SortArrTests();
            ManualArrTests();
        }
    }
}
