
//3.1 Შექმენით სტუდენტის, მასწავლებლის და საგნის კლასები.  
//Სტუდენტის კლასში უნდა არსეობდეს ინფორმაცია სტუდენტის სახელი გვარი პირადი ნომერი (პირადი ნომერი არ უნდა აღემატებოდეს 11 ციფრს), საგნების ჩამონათვალს და სემესტრების შესახებ ინფორმაციას.(ეს ცალკე კლასად შეგიძლიათ აღწეროთ). Შექმენით property რომელიც გამოტანს სახელს და გვარს ერთად. Სტუდენტს არ უნდა შეეძოს 35 GPA ზე მეტის აღება. Შექმენით მეთოდები რომელიც გამოიტანს სემესტრის ან სემესტრების საგნების ჩამონათვალს და ლექტორების შესახებ ინფორმაციას.  Სტუდენტ კლასს ასევე უნდა ჰქონდეს მეთოდები რომელიც დაამატებს სემესტრს და ამ სემესტრის საგნებს. Ან კონკრეტულ სემესტრში დაამატებს საგანს.
//Მასწავლებლის კლასი უნდა შეიცავდეს მასწავლების სახელს და გვარს და იმ საგნების სიას რომელსაც ასწავლის. Ერთ მასწავლებელს არ უნდა შეეძლოს 3 ზე მეტი საგნის სწავლება. Კლასს განუსაზღვრეთ საგნის დამატების და შეცვლის მეთოდები.
//Საგნის კლასი უნდა შეიცავდეს საგნის დასახელებას, წინაპირობებეს (იმ საგნებს რომელიც არის წინაპირობა ახალი საგნის ასარჩევად), კრედიტის რაოდენობას და საგანზე მაქსიმალური სტუდენტების რაოდენობას. 


using System.Security.Cryptography.X509Certificates;

class Student
{
    public string First_Name;
    public string Last_Name;
    public string ID_Number;
    public double GPI;
    public string Faculty;

    public Student()
    {
        Console.Write("Enter First_Name :");
        First_Name = Console.ReadLine();
        Console.Write("Enter Last_Name :");
        Last_Name = Console.ReadLine();
        Console.Write("Enter ID :");
        ID_Number = Console.ReadLine();
        Console.Write("Enter GPI :");
        GPI = double.Parse(Console.ReadLine());
        Console.Write("Enter Faculty:");
        Faculty = Console.ReadLine();

    }
    public void Print()
    {
        Console.WriteLine("First Name :{0} \nLast Name :{1}\nId :{2}\nGPI: {3} \nFaculty :{4}", First_Name, Last_Name, ID_Number, GPI, Faculty);
    }
}
class Program
{

    private static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Print();
        Console.ReadLine();
    }
}


class Teacher
{
    public string First_Name;
    public string Last_Name;
    public string Listofsubject;
    public string tech;

    public Teacher()
    {
        Console.Write("Enter First_Name :");
        First_Name = Console.ReadLine();
        Console.Write("Enter Last_Name :");
        Last_Name = Console.ReadLine();
        Console.Write("Enter List of Subjects :");
        Listofsubject = Console.ReadLine();

    }
    public void Print()
    {
        Console.WriteLine("First Name :{0} \nLast Name :{1}\nList of Sub :{2}", First_Name, Last_Name, Listofsubject);
    }
}
class Program1
{

    static void Main(string[] args)
    {
        Teacher s1 = new Teacher();
        s1.Print();
        Console.ReadLine();
    }
}

