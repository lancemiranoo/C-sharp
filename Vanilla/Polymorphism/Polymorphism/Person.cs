public interface IRole
{
    string GetRole();
}
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public virtual string GetInfo()
    {
        return "Name: " + FirstName + " " + LastName;
    }
}

public class Student : Person, IRole
{
    public override string GetInfo()
    {
        return base.GetInfo() + " - Role: " + GetRole();
    }
    public string GetRole()
    {
        return "Student";
    }
}
public class Teacher : Person, IRole
{
    public override string GetInfo()
    {
        return base.GetInfo() + " - Role: " + GetRole();
    }
    public string GetRole()
    {
        return "Teacher";
    }
}

