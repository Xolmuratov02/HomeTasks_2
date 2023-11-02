using System.Xml.Linq;

User user = new();
user.Name = "Jake";

Console.WriteLine(user.Name);

public class User
{
    public string Name { get; set; }

    //public User(string name)
    //{
    //    Name = name;
    //}
}