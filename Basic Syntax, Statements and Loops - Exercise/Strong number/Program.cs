int input = int.Parse(Console.ReadLine());

if (IsStrongNumber(input))
{
    Console.WriteLine("yes");
}

else
{
    Console.WriteLine("no");
}




static int CalculateFactorial(int number)
{
    if (number == 0)
        return 1;

    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }

    return factorial;
}

static bool IsStrongNumber(int number)
{
    int temp = number;
    int sum = 0;

    while (temp > 0)
    {
        int digit = temp % 10;
        sum += CalculateFactorial(digit);
        temp /= 10;
    }

    return sum == number;
}

