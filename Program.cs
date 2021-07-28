using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace IntegrationTesting
{
    // Program.cs
    class Program
    {           
        static void Main(string[] args)
        {

            int choose;
            Console.Write("Choose mode of program ( <1> - 'Main program' or <2> - 'Intergration tests of program' : ");
            choose = Int32.Parse(Console.ReadLine());
            switch(choose)
            {
                case 1:
                    int[] arr = ManualArr.CreateArr(-20, 20);
                    Console.WriteLine("\nInitial array: ");
                    ManualArr.PrintArr(arr);

                    int[] B = SplitArr.GetPosArr(arr);
                    int[] C = SplitArr.GetNegArr(arr);

                    Console.WriteLine("\nPositive Array: ");
                    ManualArr.PrintArr(B);

                    Console.WriteLine("\nNegative Array: ");
                    ManualArr.PrintArr(C);

                    Console.WriteLine("\nSorted Array B: ");
                    B = SortArr.SortArray(B);
                    ManualArr.PrintArr(B);

                    Console.WriteLine("\nSorted Array C: ");
                    C = SortArr.SortArray(C);
                    ManualArr.PrintArr(C);
                    break;
                case 2:
                    IntergrationTesting.StartTesting();
                    break;
                default:
                    break;
            }
        }
    }
}
