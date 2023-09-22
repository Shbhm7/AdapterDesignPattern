public class ModernUser : IUser
{
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private int Age { get; set; }

    public ModernUser(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public int GetAge()
    {
        return Age;
    }
}