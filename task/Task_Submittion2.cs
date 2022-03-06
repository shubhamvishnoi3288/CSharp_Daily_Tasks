using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace submittion_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
/********************************************************************************************************/
            //   Find2Largest();
            void Find2Largest()
            {
                int maxNumber;
                int number1 = 50;
                int number2 = 90;
                Console.WriteLine("Number 1: " + number1);
                Console.WriteLine("Number 2: " + number2);
                if (number1 > number2)
                {
                    maxNumber = number1;
                }
                else
                {
                    maxNumber = number2;
                }
                Console.WriteLine("Maximum number is: " + maxNumber);
                Console.ReadKey();
            }
/*********************************************************************************************************/
       //         Find3Largest();

            void Find3Largest()
            {
                int num1, num2, num3;
                Console.Write("\n\n");
                Console.Write("Find the largest of three numbers:\n");
                Console.Write("------------------------------------------------------------------");
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n");
                Console.Write("Enter the 1st Number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the 2nd Number");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the 3rd Number");
                num3 = Convert.ToInt32(Console.ReadLine());
                if (num1 >= num2)
                {
                    if (num1 >= num3)
                    {
                        Console.Write("The 1st Number is the greatest among three. \n\n");
                    }
                    else
                    {
                        Console.Write("The 3rd Number is the greatest among three. \n\n");
                    }
                }
                else if (num2 >= num3)
                    Console.Write("The 2nd Number is the greatest among three \n\n");
                else
                    Console.Write("The 3rd Number is the greatest among three \n\n");
                Console.ReadLine();
            }
/******************************************************************************************************/

            //      TableCreate();


            void TableCreate()
            {
                int valincrement, number;

                // Reading the number
                Console.WriteLine("Enter number to the print table: ");
                number = Convert.ToInt32(Console.ReadLine());
                for (valincrement = 1; valincrement <= 10; valincrement++)
                {
                    //Table Number Entered By the User:         
                    Console.Write("{0} X {1} = {2} \n", number, valincrement, number * valincrement);
                }
                Console.ReadLine();
            }
/******************************************************************************************************/
       //          FindDivisibility();
            void FindDivisibility()
            {
               
               
               int value1 = Convert.ToInt32(Console.ReadLine());
                if ((value1 % 5 == 0) && (value1 % 11 == 0))
                {
                   
                        Console.WriteLine("number is divisible by 5 and 11");
                        Console.ReadLine();
                    }
                else
                {
                    Console.WriteLine("Number is not divisible by 5 and 11");
                    Console.ReadLine();
                }
            }
/********************************************************************************************************/           
       //        CalculateSI();
            void CalculateSI()
            {
                int year;
                double principle, Rate, Interest, Total_Amount;
                Console.Write("Enter The Loan Amount : ");
                principle = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter The Number of Years : ");
                year = Convert.ToInt16(Console.ReadLine());
                Console.Write("Enter the Rate Of Interest : ");
                Rate = Convert.ToDouble(Console.ReadLine());
                Interest = (principle * year * Rate) / 100;
                Total_Amount = principle + Interest;
                Console.WriteLine("Total Amount : {0}", Total_Amount);
                Console.ReadLine();
            }
/********************************************************************************************************/
       //         CheckPrime();
            void CheckPrime()
            {
                int number = 5, checkprime = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        checkprime++;
                    }
                }
                if (checkprime == 2)
                {
                    Console.WriteLine("{0} is a Prime Number", number);
                }
                else
                {
                    Console.WriteLine("Not a Prime Number");
                }
                Console.ReadLine();
            }
/*******************************************************************************************************/
        }

    }
    }

