using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramSubmission
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*************************************  Call the all Functions    *************************************/
            //      FindAverage();
            //      AbsoluteValueFind();
            //      CubeofNumber();
            //      CubeRoot();
            //      CheckLeapYear();
            //      EvenOdd();
            //      OnlyEven
            //      CalculateCI();
/******************************************************************************************************/
            void FindAverage()
            {
                int number1 = 30;
                int number2 = 60;
                Console.WriteLine("Find the Average");
                int average = (number1 + number2) / 2;
                Console.WriteLine("Average of the Expresssion  == " + average);
                Console.ReadLine();
            }
/******************************************************************************************************/
/**************************        Find Absolute Value    *********************************************/
            void AbsoluteValueFind()
            {
                int absval1 = 56;
                int absval2 = -99;
                Console.WriteLine("Before the Execution...");
                Console.WriteLine(absval1);
                Console.WriteLine(absval2);
                int abs1 = Math.Abs(absval1);
                int abs2 = Math.Abs(absval2);
                Console.WriteLine("After the Execution...");
                Console.WriteLine(abs1);
                Console.WriteLine(abs2);
                Console.ReadLine();
            }
/***************************************************************************************************/
/******************************Find Compound Interest***********************************************/
                 void CalculateCI()
            {
                  double Principle = 5000;
                  double Rate_of_Interest = 10;
                  dynamic Time = 3;
                  dynamic CI = (Principle*(Math.Pow((1 + Rate_of_Interest / 100), Time)));
                  Console.WriteLine($"{CI}");
                  Console.ReadLine();
            }
/*****************************************************************************************************/
/******************************  Cube of Number   ****************************************************/

            void CubeofNumber()
            {
                Console.WriteLine("Enter Side Of Cube: ");
                decimal Side = Convert.ToDecimal(Console.ReadLine());
                decimal Volume = Side * Side * Side;
                Console.WriteLine("Volume of cube=" + Volume);
                Console.ReadLine();
            }
/*******************************************************************************************************/
/******************************  Cube Root   ***********************************************************/
                void CubeRoot()
            {
                int number = 0;
                double cubeRoot = 0;
                Console.WriteLine("Enter the value of number: ");
                number = Convert.ToInt32(Console.ReadLine());
                cubeRoot = Math.Ceiling(Math.Pow(number, (double)1 / 3));
                Console.WriteLine("Cube Root is : " + cubeRoot);
                Console.ReadLine();
            }
/******************************************************************************************************/
/****************************** Find the Leap Year   **************************************************/
            void CheckLeapYear()
            {
                int check_year;
                Console.Write("\n\n");
                Console.Write("Check whether a given year is leap year or not:\n");
                Console.Write("----------------------------------------------");
                Console.Write("\n\n");
                Console.Write("Input an year : ");
                check_year = Convert.ToInt32(Console.ReadLine());

                if ((check_year % 400) == 0)
                    Console.WriteLine("{0} is a leap year.\n", check_year);
                else if ((check_year % 100) == 0)
                    Console.WriteLine("{0} is not a leap year.\n", check_year);
                else if ((check_year % 4) == 0)
                    Console.WriteLine("{0} is a leap year.\n", check_year);
                else
                    Console.WriteLine("{0} is not a leap year.\n", check_year);
                Console.ReadLine();
            }
 /*****************************************************************************************************/
 /**********************************Check Number Even or Odd ******************************************/
            void EvenOdd()
            {
                int value1;
                Console.WriteLine("\n");
                Console.WriteLine("Enter a Number");
                Console.WriteLine(value1 = Convert.ToInt32(Console.ReadLine()));
                if (value1 % 2 == 0)
                    Console.WriteLine("This is a Even Number");
                else
                    Console.WriteLine("This is a Odd Number");
                    Console.ReadLine();
/*******************************************************************************************************/
/********************************  Print Even Numbers from 1 to N  *************************************/
                /*      void OnlyEven()
                     {
                      int i, start, end;
                      /* Input upper and lower limit */
                /*    Console.WriteLine("Enter lower limit: ");
                      Console.WriteLine((start = Convert.ToInt32(Console.ReadLine())).ToString());
                      Console.WriteLine("Enter upper limit: ");
                      Console.WriteLine((start = Convert.ToInt32(Console.ReadLine())).ToString());
                        if (start % 2 == 0)
                          {
                             start++;
                          }
                             Console.ReadLine();
                          }                                                                 */
/*******************************************************************************************************/
                } 
                
            }
        }
    }





