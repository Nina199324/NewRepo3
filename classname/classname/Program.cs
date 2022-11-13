
class Student
{
   public static void main(string[] args);

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

