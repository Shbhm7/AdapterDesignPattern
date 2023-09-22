public class OldUser
{
    private string FullName { get; set; }
    private string BirthYear { get; set; }

    public OldUser(string fullName, string birthYear)
    {
        FullName = fullName;
        BirthYear = birthYear;
    }

    public string GetFullName()
    {
        return FullName;
    }

    public string GetBirthYear()
    {
        return BirthYear;
    }
}