using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
   
 /*************************************************************************************************/
    // Question    :     10
    internal class Student
    {
        int StudentID;
        string FullName;
        string CourseName;
        string PhoneNo;
        public Student(int studentId, string fullName, string courseName, string phoneNo)
        {
            StudentID = studentId;
            FullName = fullName;
            CourseName = courseName;
            PhoneNo = phoneNo;
        }
        public void Summary()
        {
            Console.WriteLine($"STUDENT ID : {StudentID}");
            Console.WriteLine($"FULL NAME : {FullName}");
            Console.WriteLine($"COURSE NAME : {CourseName}");
            Console.WriteLine($"PHONE NUMBER : {PhoneNo}");
        }
    }
/***************************************************************************************************/
    //Question   :   13
    internal class Employee
    {
        public int EmployeeID;
        public string FullName;
        public string PhoneNo;
        public string DepartmentName;
        public Employee(int employeeID, string fullName, string phoneNo, string departmentName)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            PhoneNo = phoneNo;
            DepartmentName = departmentName;

        }
        public void ShowDetail()
        {
            Console.WriteLine($"EMPLOYEE ID : {EmployeeID}");
            Console.WriteLine($"FULL NAME : {FullName}");
            Console.WriteLine($"PHONE NUMBER : {PhoneNo}");
            Console.WriteLine($"DEPARTMENT : {DepartmentName}");
        }
    }
    internal class ITEmployee : Employee
    {
        public ITEmployee(int employeeID, string fullName, string phoneNo, string departmentName) : base(employeeID, fullName, phoneNo, departmentName)
        {
            employeeID = employeeID;
            fullName = fullName;
            phoneNo = phoneNo;
            departmentName = departmentName;
        }
    }


    // Question ---> 14
    //..............................................................................
    interface IContractEmployee
    {
        void CalculateSalary(int hour, int perHourRupees);
    }
    internal class Infosys : IContractEmployee
    {
        public void CalculateSalary(int hour, int perHourRupees)
        {
            Console.WriteLine($"SALARY : { CalculateSalary()}");

            int CalculateSalary()
            {
                int salary = hour * perHourRupees;
                return salary;
            }
        }
    }
    //.................................................................................
    internal class Program
    {
        string UserName;
        int ID;
        string Password;
        Program(string UserName, int ID, string Password)
        {
            this.UserName = UserName;
            this.ID = ID;
            this.Password = Password;
        }
        static void Main(string[] args)
        {   
            //Question7();
            //Question8();
            //Question9();
            //Question10();
            //Question11();
            //Question13();
            //Question14();
           // Question15A();
           // Question15B();
            //Question15C();
           // Question17();
            Console.ReadLine();
        }
/*************************************************************************************************/
        private static void Question7()
        {
            Param("Shubham", "Shivani", "Akshay", "Vikas", "Somnath", "Ayush");
            void Param(params string[] name)
            {
                foreach (string s in name)
                    Console.WriteLine(s);
            }
        }

/**************************************************************************************************/
        private static void Question8()
        {
            Tuple<int, string, float> t = new Tuple<int, string, float>(1, "Shubham", 93.2f);
            Console.WriteLine($"ID : {t.Item1}");
            Console.WriteLine($"NAME : {t.Item2}");
            Console.WriteLine($"PERCENTAGE : {t.Item3}");
        }

/************************************************************************************************/

        private static void Question9()
        {
            string[] vs = { "Shubham", "Yashu", "Neeraj", "Sumit", "Jai", "Piyush" };
            int i = 0;
            for (i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
            try
            {
                vs[vs.Length + 1] = "Goutam";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
/*********************************************************************************************/
        private static void Question10()
        {
            Student stu = new Student(1, "Shubham", "Designer", "8574968");
            stu.Summary();
        }

/***********************************************************************************************/
        private static void Question11()
        {
            //  SORT METHOD USED

            int[] num = { 9, 6, 8, 7, 4, 6, 1, 3 };
            Array.Sort(num);
            int i = 0;
            Console.WriteLine($"Highest value 3rd Position : {num[2]}");


            // SORT METHOD NOT USED 

            int[] num2 = { 9, 5, 7, 8, 2, 4, 3, 1 };
            int J = 0;
            int temp;
            int k;
            for (J = 1; J < num2.Length; J++)
            {

                if (num2[J - 1] > num2[J])
                {
                    int index;
                    for (index = J - 1; index >= 0; index--)
                    {
                        if (num2[index] > num2[index + 1])
                        {
                            temp = num2[index];
                            num2[index] = num2[index + 1];
                            num2[index + 1] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"Third Highest Value : {num2[2]}");

        }

/**********************************************************************************************/
       
        private static void Question13()
        {
            Employee e = new ITEmployee(1, "Shubham", "4572547", "internet");
            e.ShowDetail();
        }

/**********************************************************************************************/

        private static void Question14()
        {
            Infosys info = new Infosys();
            info.CalculateSalary(2, 5000);
        }

/*************************************************************************************************/

        private static void Question15A()
        {
            Console.WriteLine("Enter a name : ");
            string nm = Console.ReadLine();
            Console.WriteLine(IsPalidromeOrNot(nm));

            Boolean IsPalidromeOrNot(string name)
            {
                string Rev_name = null;
                int i;
                for (i = 0; i < name.Length; i++)
                {
                    Rev_name = name[i] + Rev_name;
                }
                Console.WriteLine(Rev_name);
                if (Rev_name == name)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        /// <summary>
        /// 15(b).  create a static method to accept value from user and checks if year is leap.
        /// </summary>
        private static void Question15B()
        {
            Console.WriteLine("Enter Year.... : ");
            dynamic Leap_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (Leap_year % 4 == 0)
                Console.WriteLine("..............Leap Year...............");
            else
                Console.WriteLine(".............NOT Leap Year.............");
        }

/*************************************************************************************************/
        private static void Question15C()
        {
            Console.WriteLine("Enter Element.......");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(0);
            FiboSeries(0, 1, num);
            int FiboSeries(int min, int max, int dec)
            {
                Console.WriteLine(max);
                int temp;
                temp = min + max;
                min = max;
                max = temp;

                if (dec == 0)
                {
                    return 1;
                }
                return FiboSeries(min, max, dec - 1);
            }
        }
/********************************************************************************************/
        private static void Question17()
        {
            Program obj = new Program("Shubham", 1, "Vishnoi");

            string Pass = Console.ReadLine();
            if (Pass == obj.Password)
                Console.WriteLine("Welcome to portal...! have a nice day");
            else
                Console.WriteLine("Invalid login name or password");
        }



    }
}
    