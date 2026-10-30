Person p = new Person();
p.Name = "Sam";
Console.WriteLine(p.Name);
class Person
{
    private string name = "";
    public string Name
    {
        get {return name;}
        set {name = value;}
    }
}