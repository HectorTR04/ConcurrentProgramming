namespace LoanManagementSys.SystemItems;

//Stores and handles data about members of the system
public class Member
{
    //Properties
    private int id;
    private string name;

    public Member(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public int ID
    {
        get { return id; }
        set { id = value; }

    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //The toString method returning a textual representation of the object's values.
    public override string ToString()
    {
        return $"{name}, ID {id}";
    }
}
