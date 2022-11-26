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
