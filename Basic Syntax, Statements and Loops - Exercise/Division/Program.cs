int input = int.Parse(Console.ReadLine());


if (input % 10 == 0)
{
    Console.WriteLine("The number is divisible by 10");
    return;
}

if (input % 7 == 0)
{
    Console.WriteLine("The number is divisible by 7");
    return;
}

if (input % 6 == 0)
{
    Console.WriteLine("The number is divisible by 6");
    return;
}

if (input % 3 == 0)
{
    Console.WriteLine("The number is divisible by 3");
    return;
}

if (input % 2 == 0)
{
    Console.WriteLine("The number is divisible by 2");
    return;
}

else
{
    Console.WriteLine("Not divisible");
}