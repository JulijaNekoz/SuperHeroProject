
Console.WriteLine("***********GENERAL INFO*************");
string name = "Groot";
int age = 25;
string ability1 = "Superhuman Strength";
string ability2 = "Enhanced Speed";
string ability3 = "Immortality";
bool isEvil = false;

Console.WriteLine($"'I am {name}.' Translation: 'My name is {name}. I am {age} y.o. at the moment." +
    $"My abilities are: {ability1}, {ability2} and {ability3}. Nice to meet you!'");

if (!isEvil)
{
    Console.WriteLine($"'I am {name}. Translation: 'I am a hero, not a villain. I earn and eat my cookies. Yum!'");
}
else
{
    Console.WriteLine($"'I am {name}. Translation: 'I am evil, I will eat you all alive! ROAR!'");
    Console.WriteLine("Then no salary for you, mister! Forget about the cookies!");
    return;
}

Console.WriteLine("*********FINANCIAL INFO***************");
/*Continue working on Hero Card view
                - Add new variables - deedTimeInHours1, deedTimeInHours2, deedTimeInHours3(INT),
holding time that a deed took to complete
                 - Add methods to calculate:
                -Total time spent on deeds
                - Average time spent on one deed
                - How many cookies Hero will get. 5 cookies per hour
-- Add boughtCookies calculation
-- isEvil or not
-- monthlySalary
*/

int deedTimeInHours1 = 10;
int deedTimeInHours2 = 4;
int deedTimeInHours3 = 36;
int monthlySalary = 2500;
double cookiePrice = 1.29;

int totalTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
Console.WriteLine($"The hero spent {totalTime} hours on his deeds.");

double oneDeedTime = totalTime / 3;
Console.WriteLine($"The hero spends about {oneDeedTime} hours on one deed on average.");

int totalCookies = totalTime * 5;
Console.WriteLine($"The hero gets about {totalCookies} cookies for his deeds.");

double buyCookies = Math.Floor(monthlySalary / cookiePrice);
Console.WriteLine($"The hero can buy about {buyCookies} cookies per month with his salary.");


Console.WriteLine("********HERO GRADE***********");
Console.WriteLine("Please, enter the hero's grade!");
char grade;
string gradeString = Console.ReadLine().ToUpper();//makes all letters capital!!!
bool parsingResult = char.TryParse(gradeString, out grade);

if (parsingResult == false)
{
    Console.WriteLine("Please, enter a valid mark!");
    return;
}

switch (grade)
{
    case 'A':
    case 'B':
        Console.WriteLine("Perfect! You are so brave!");
        break;
    case 'C':
        Console.WriteLine("Good, but you can do better!");
        break;
    case 'D':
    case 'E':
        Console.WriteLine("It is not good! You should choose your bad or good side!");
        break;
    case 'G':
        Console.WriteLine("Bad, you are a true villain!");
        break;
    default:
        Console.WriteLine("The grade is invalid, please check it!");
        break;
}
Console.WriteLine();
Console.WriteLine();

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