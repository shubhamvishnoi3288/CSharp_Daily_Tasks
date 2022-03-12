using System;
public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Math.Round(12.5));
            Console.WriteLine(Math.Round(10.5));
        }
    }
output:
12
15

question n 2:

        public static void Main(string[] args)
        {
            
                int valincrement, number;

                // Reading the number
                Console.WriteLine("Enter number to the print table: ");
                number = Convert.ToInt32(Console.ReadLine());
                for (valincrement = 1; valincrement <= 20; valincrement++)
                {
                    //Table Number Entered By the User:         
                    Console.WriteLine("{0} X {1} = {2} ", number, valincrement, number * valincrement);
                }
                Console.ReadLine();

question9:
    private static void Question9()
        {
            string[] vs = { "shubham", "akshay", "kisan", "Shivani", "Ayush", "ombeer" };
            int i = 0;
            for (i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
            try
            {
                vs[vs.Length + 1] = "vikas";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }