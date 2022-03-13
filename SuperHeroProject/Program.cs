
Console.WriteLine("**********SALARY CALCULATOR************");

Console.WriteLine("Please, enter the amount of working hours in a day:");
string input = Console.ReadLine();
if (double.TryParse(input, out double workingHoursInDay) == false)
{
    Console.WriteLine("Please, enter a valid amount of daily working hours!");
    return;
}

if (workingHoursInDay < 0 || workingHoursInDay > 24)
{
    Console.WriteLine("The number for the amount of daily working hours is invalid. Try again.");
    return;
}

if (workingHoursInDay <= 8)
{
    Console.WriteLine($"Salary per day is {workingHoursInDay * 10}");
}
else
{ 
    Console.WriteLine($"Salary per day is {80 + (workingHoursInDay - 8) * 15} euros");
}
