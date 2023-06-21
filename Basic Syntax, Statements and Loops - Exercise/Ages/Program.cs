int input = int.Parse(Console.ReadLine());

string output = string.Empty;

if (input >= 0 && input <= 2)
{
    output = "baby";
}

if (input >= 3 && input <= 13)
{
    output = "child";
}

if (input >= 14 && input <= 19)
{
    output = "teenager";
}

if (input >= 20 && input <= 65)
{
    output = "adult";
}

if (input >= 66)
{
    output = "elder";
}

Console.WriteLine(output);
