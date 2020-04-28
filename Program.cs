using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Programmer: Corin
 * Date: 11/20/18
 * Purpose: In Chapter 11, Assignment #6 on page 847, for Week 4 Create a multi-class solution that includes a 
 * WeightConverter class. The WeightConverter class should be used to convert standard weight measurements such as
 * grams, kilograms, pounds and ounces. Then create an application class to test the WeightConverter class.
 * If the user enters a negative number or a nonnumeric value throw and handle an exception.
 */

namespace WeightConverter
{
    class WeightConverter
    {
        static void MainWeightConverter()
        {
            try
            {
                Console.WriteLine("Please enter grams: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                double kilograms = num1 / 1000;
                Console.WriteLine("Grams to kilograms = " + kilograms);

                if (num1 < 0)
                {
                    throw new Exception();
                }

                Console.WriteLine("\nPlease enter kilograms: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                double grams = num2 * 1000;
                Console.WriteLine("Kilograms to grams = " + grams);

                if (num2 < 0)
                {
                    throw new Exception();
                }

                Console.WriteLine("\nPlease enter pounds: ");
                double num3 = Convert.ToDouble(Console.ReadLine());
                double ounces = num3 * 16.000;
                Console.WriteLine("Pounds to ounces = " + ounces);

                if (num3 < 0)
                {
                    throw new Exception();
                }

                Console.WriteLine("\nPlease enter ounces: ");
                double num4 = Convert.ToDouble(Console.ReadLine());
                double pounds = num4 * 0.062500;
                Console.WriteLine("Ounces to pounds = " + pounds);

                if (num4 < 0)
                {
                    throw new Exception();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine("Cannot enter a non-numeric value!");
            }
            catch (Exception e)
            {
                    Console.WriteLine("Cannot enter a number less than zero!");
            }
        }

        class TestWeightConverter
        {
            static void Main(string[] args)
            {
                try
                {
                    MainWeightConverter();
                }
                finally
                {
                    Console.WriteLine("Weights have been converted.");
                    Console.ReadLine();
                }
            }

        }
    }
}
