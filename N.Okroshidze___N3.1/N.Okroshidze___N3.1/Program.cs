
class Teacher_Student
{
    class Student
    {
        private double age;
        private string name, iD;
        public double Age { get { return age; } set { if (18 <= value && value <= 40) { age = value; } } }

        public string ID { get { return iD; } set { if (value.Length >= 11) { iD = value; } } }
    }
}
    
   


