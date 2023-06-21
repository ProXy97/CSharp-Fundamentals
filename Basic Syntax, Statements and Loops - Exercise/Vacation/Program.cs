int peopleCount = int.Parse(Console.ReadLine());
string groupType = Console.ReadLine();
string day = Console.ReadLine();
decimal pricePerPerson = 0.0m;
decimal totalPrice = 0.0m;

switch (day)
{
    case "Friday":
        switch (groupType)
        {
            case "Students":
                pricePerPerson = 8.45m;
                break;
            case "Business":
                pricePerPerson = 10.90m;
                break;
            case "Regular":
                pricePerPerson = 15.00m;
                break;
        }
        break;
    case "Saturday":
        switch (groupType)
        {
            case "Students":
                pricePerPerson = 9.80m;
                break;
            case "Business":
                pricePerPerson = 15.60m;
                break;
            case "Regular":
                pricePerPerson = 20.0m;
                break;
        }
        break;
    case "Sunday":
        switch (groupType)
        {
            case "Students":
                pricePerPerson = 10.46m;
                break;
            case "Business":
                pricePerPerson = 16.0m;
                break;
            case "Regular":
                pricePerPerson = 22.50m;
                break;
        }
        break;
}

totalPrice = peopleCount * pricePerPerson;

if (groupType == "Students" && peopleCount >= 30)
{
    totalPrice = totalPrice - (totalPrice * 0.15m);
}

if (groupType == "Business" && peopleCount >= 100)
{
    totalPrice = peopleCount * pricePerPerson - (pricePerPerson * 10);
}

if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
{
    totalPrice = totalPrice - (totalPrice * 0.05m);
}

Console.WriteLine($"Total price: {totalPrice:f2}");