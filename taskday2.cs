using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shubham_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
 /*************************  call all function  ****************************************************/
            

/***************************************************************************************************/
            question4();
/***************************************************************************************************/
            question3();
            
            
            Console.ReadLine();
        }

        private static void question3()
        {
            Console.WriteLine("enter your input here :");
            int user_input = Convert.ToInt32(Console.ReadLine());
            switch (user_input)
            {
                case 1:
                    Console.WriteLine(daynames.sunday);
                    break;
                case 2:
                    Console.WriteLine(daynames.monday);
                    break;
                case 3:
                    Console.WriteLine(daynames.tuesday);
                    break;
                case 4:
                    Console.WriteLine(daynames.wednesday);
                    break;
                case 5:
                    Console.WriteLine(daynames.thursday);
                    break;
                case 6:
                    Console.WriteLine(daynames.friday);
                    break;
                case 7:
                    Console.WriteLine(daynames.saturday);
                    break;
                default:
                    Console.WriteLine("please enter a valid input");
                    break;
            }
        }

        private static void question4()
        {
            int count = 0;
            Dictionary<int, string> passvalue = new Dictionary<int, string>();
            passvalue.Add(1, "shubham");
            passvalue.Add(2, "ombeer ");
            passvalue.Add(3, "rahul ");
            passvalue.Add(4, "ayush ");
            passvalue.Add(5, "shivani ");
            int userinput = Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<int, string> keys in passvalue)
            {
                if (userinput == keys.Key)
                {
                    Console.WriteLine("hii this key is exist");

                }
                count++;
            }
            if (userinput > count)
            {
                Console.WriteLine("exit");
            }
        }
        enum daynames
        {
            sunday = 1,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday
        }
    }
}



 

