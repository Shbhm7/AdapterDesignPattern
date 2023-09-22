class Program
{
    static void Main(string[] args)
    {
        IUser modernUser = new ModernUser("Rohan", "Gupta", 30);
        Console.WriteLine($"Modern User: {modernUser.GetFullName()}, Age: {modernUser.GetAge()}");
        OldUser oldUser = new OldUser("Ajay", "1980");
        IUser oldUserAdapter = new OldUserAdapter(oldUser);
        Console.WriteLine($"Old User (via Adapter): {oldUserAdapter.GetFullName()}, Age: {oldUserAdapter.GetAge()}");
    }
}