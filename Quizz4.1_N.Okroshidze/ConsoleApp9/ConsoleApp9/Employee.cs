using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Employee
    {
        public string ID, Name, Last_name, Salary_Field;
    }
    class Depapertment : Employee
    {
        class Department
        {
            public string DepartmentName
            { get; set; }
            public string NumberofEmployee


            {
                get { return DepartmentName; }
                set { DepartmentName = value; }
            }

        }
    }
}
         
//    {
//        Hashtable h = new Hashtable();
//        Employee[] em = new Employee [21];
//        for (int i = 0; i < 21; i++)
//        { 
//            em[i] = new Employee();
//            Console.WriteLine("Enter ID: ");
//            string a = Console.ReadLine();
//            em[i].ID = a;

//            Console.WriteLine("Enter Name: ");
//            string b = Console.ReadLine();
//            em[i].Name = b;

//            Console.WriteLine("Enter Last name: ");
//            string c = Console.ReadLine();
//            em[i].Last_name = c;
//            h.Add(a, b);

//            em[i] = new Employee();
//            Console.WriteLine("Salary Field: ");
//            string d = Console.ReadLine();
//            em[i].ID = d;
//        }
//        foreach (DictionaryEntry e in h)
//            Console.WriteLine(" {0}  {1} ", e.Key, e.Value);
//        string f = "";
//    }

//}






