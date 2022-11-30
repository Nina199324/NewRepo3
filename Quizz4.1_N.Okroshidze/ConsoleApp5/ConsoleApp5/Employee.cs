using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{ }
        class Employee
        {
            public string First_Name;
            public string Last_Name;
            public string ID_Number;
            public double Salary_in_GEL;            

            public Employee()
            {
                Console.Write("Enter First_Name :");
                First_Name = Console.ReadLine();
                Console.Write("Enter Last_Name :");
                Last_Name = Console.ReadLine();
                Console.Write("Enter ID :");
                ID_Number = Console.ReadLine();
                Console.Write("Enter Salary in Georgian Lari :");
                Salary_in_GEL = double.Parse(Console.ReadLine());
              
            }
            public void Print()
            {
                Console.WriteLine("First Name :{0} \nLast Name :{1}\nID :{2}\nSalary (In GEL): {3} \n", First_Name, Last_Name, ID_Number, Salary_in_GEL);
            }
        }
        class Department
        {

            static void Main(string[] args)
            {
            Employee s1 = new Employee();
                s1.Print();
                Console.ReadLine();
            }
        }
    


