using System;
using static System.Console;

namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers =  new double [10];
            string inputstring;
            int total = 0;
            double average;
            FillArray(numbers);
            DisplayAverage(numbers);
            DisplayAverage(3);
            DisplayAverage(12, 15);
            DisplayAverage(22.3, 44.5, 88.1);
            // Write("FillArray -- Average is {0}", average);
           
        }

        private static void FillArray(params double[] numbersArray)
        {
            // FillArray(numbersArray);
            string inputstring;
            

            for (int x = 0; x < numbersArray.Length; ++x)

            {
                Write("Enter a number: ");
                inputstring = ReadLine();
                numbersArray[x] = Convert.ToInt32(inputstring);
              
            }
            
        }//end fillarray


        private static void DisplayAverage(params double[] average)
        {
            double offavg = 0;
            double offtotal = 0;
            for (int y = 0; y < average.Length; ++y)
            {
                Write("{0} ", average[y]);
            }

        
            for (int y = 0; y < average.Length; ++y)
            {
                offtotal += average[y];
            }
                offavg = offtotal / average.Length;

            Write( " --Average is {0}" , offavg.ToString("F2"));

            WriteLine();
            WriteLine("*****************");


        }//end avgarray














    }//endclass      

}//end namespace
