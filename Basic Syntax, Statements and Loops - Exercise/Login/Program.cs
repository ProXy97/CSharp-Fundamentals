string userName = Console.ReadLine();

char[] passwordChars = userName.ToCharArray();

string reversedPassword = string.Empty;
int passwordAttempts = 1;

for (int i = passwordChars.Length - 1; i >= 0; i--)
{
    reversedPassword += passwordChars[i];
}

while (true)
{
    string input = Console.ReadLine();
    if (passwordAttempts == 4)
    {
        Console.WriteLine($"User {userName} blocked!");
        break;
    }

    if (input == reversedPassword)
    {
        Console.WriteLine($"User {userName} logged in.");
        break;
    }

    else
    {
        passwordAttempts++;
        Console.WriteLine("Incorrect password. Try again.");
    }
}
