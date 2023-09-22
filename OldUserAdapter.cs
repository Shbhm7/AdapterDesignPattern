public class OldUserAdapter : IUser
{
    private readonly OldUser _oldUser;

    public OldUserAdapter(OldUser oldUser)
    {
        _oldUser = oldUser;
    }

    public string GetFullName()
    {
        return _oldUser.GetFullName();
    }

    public int GetAge()
    {
        int birthYear = int.Parse(_oldUser.GetBirthYear());
        int currentYear = DateTime.Now.Year;
        return currentYear - birthYear;
    }
}