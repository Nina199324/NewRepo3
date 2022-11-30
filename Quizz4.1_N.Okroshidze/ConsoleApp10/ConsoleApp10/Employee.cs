public class Department
{
    private int _DepartID;
    private string _DepartName;
    private string _DepartDescp;

    public int DepartmentID
    {
        get { return _DepartID; }
        set { _DepartID = value; }
    }

    public string DepartmentName
    {
        get { return _DepartName; }
        set { _DepartName = value; }
    }

    public string DepartDescription
    {
        get { return _DepartDescp; }
        set { _DepartDescp = value; }
    }

    public override string ToString()
    {
        return this.DepartmentID + " " + this._DepartName + " " + this.DepartDescription;
    }

    List<string> EmployeeList = new List<string>();

    public List<string> Empoyees(string objEmp)
    {
        EmployeeList.Add(objEmp);
        return EmployeeList;
    }

}
public class Employee
{
    private int _employeeID;
    private string _empFirstName;
    private string _empLastName;
    private string _empTitle;


    public int EmployeeID
    {
        get { return _employeeID; }
        set { _employeeID = value; }
    }

    public string EmpFirstName
    {
        get { return _empFirstName; }
        set { _empFirstName = value; }
    }

    public string EmpLastName
    {
        get { return _empLastName; }
        set { _empLastName = value; }
    }

    public string EmpTitle
    {
        get { return _empTitle; }
        set { _empTitle = value; }
    }

    public override string ToString()
    {
        return this.EmpTitle + " " + this.EmpFirstName + " " + this._empLastName + " " + this._employeeID.ToString();
    }

}