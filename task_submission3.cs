using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //     FindParallelogram();
/***********************Area of a Parallelogram************************************************************/
            void FindParallelogram()
            {
                Console.WriteLine("Enter base of parallelogram:");
                double parallelogramBase = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter height of parallelogram:");
                double parallelogramHeight = Convert.ToDouble(Console.ReadLine());

                double areaOfParallelogram = parallelogramBase * parallelogramHeight;
                Console.WriteLine("Area of parallelogram is: " + areaOfParallelogram);
                Console.ReadLine();
            }
/*******************************   Find Area of a Rhombus    ********************************************/
           //    AreaofRhombus();    
            void AreaofRhombus()
            {
                double Diagonal1 = 16;
                double Diagonal2 = 18;

                double area = (Diagonal1 * Diagonal2) / 2;

                Console.WriteLine("Area of Rhombus is = " + area);
                Console.ReadLine();
            }
/*****************************   Area of a Right Angled Triangle    ***************************************/
          //  AreaofAngledTraingle();
                void AreaofAngledTraingle()
            {
                float Base, Height, Area;
                Base = 10;
                Height = 16;
                Area = (Base * Height) / 2;
                Console.WriteLine("Area of Right Angle Triangle is: " + Area);
            }
/*********************************************************************************************************/
        }
    }
}
