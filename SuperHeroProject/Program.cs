
string[] superHeroNameList =
{
    "Groot",
};

bool isMenuRunning = true;
do
{
    string menuItems;

    Console.WriteLine("Welcome to the superhero application!");
    Console.WriteLine("Select what to do:");
    Console.WriteLine("1 - Show a list of superheroes");
    Console.WriteLine("2 - Show specific hero");
    Console.WriteLine("3 - Adding a superhero");
    Console.WriteLine("4 - Deleting a superhero");
    Console.WriteLine("5 - Exit");

    menuItems = Console.ReadLine();

    switch (menuItems)
    {
        case "1":
            Console.WriteLine("********List of superheroes********");
            for (int i = 0; i < superHeroNameList.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroNameList[i]}");
            }
            Console.WriteLine("****************");
            break;
        case "2":
            Console.WriteLine("Please choose a superhero by number:");
            for (int i = 0; i < superHeroNameList.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroNameList[i]}");
            }
            int.TryParse(Console.ReadLine(), out int chosenNumber);
            Console.WriteLine($"You have chosen {superHeroNameList[chosenNumber]}");

            Console.WriteLine("Choose what type of info to show:");
            Console.WriteLine($"1 - GENERAL INFO");
            Console.WriteLine($"2 - FINANCIAL INFO");
            string showMenu = Console.ReadLine();
            if (showMenu == "1")
            {
                Console.WriteLine("*********************GENERAL INFO******************");
                Console.WriteLine($"Hero: {superHeroNameList[chosenNumber]}");
                Console.WriteLine("Age: " + 25 + " year old");
                string[] abilityArray = {"Superhuman Strength", "Enhanced Speed" , "Immortality"};
                Console.WriteLine($"Hero powers: \n {0}, \n {1},\n {2}\n, {abilityArray[0]}, {abilityArray[1]}, {abilityArray[2]}");
                Console.WriteLine("******************************************** \n \n");
            }
            else if (showMenu == "2")
            {
                double salary = 2500;
                int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3;
                deedTimeInHours1 = 10;
                deedTimeInHours2 = 4;
                deedTimeInHours3 = 36;
                var totalTimeSpent = (deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3);
                double rewardMoney = totalTimeSpent * 5;
                salary += rewardMoney;
                var averageTime = totalTimeSpent / 3;

                double cookieCost = 1.29;
                double boughtCookies = Math.Floor(salary / cookieCost);
                double dailySalary = Math.Round(salary / 30, 2);


                Console.WriteLine("************FINANCIAL INFO*****************");
                Console.WriteLine($"The hero can buy {boughtCookies}");
                Console.WriteLine($"Our hero earns daily {dailySalary}");
                Console.WriteLine($"Our hero spent {totalTimeSpent} hours doing deeds");
                Console.WriteLine($"Our hero on average spent {averageTime} hours per deed");
                Console.WriteLine($"For the deeds our hero got as a reward {rewardMoney} EUR");
            }


            break;
        case "3":
            Console.WriteLine("What is the new superhero name?");
            string superHeroName = Console.ReadLine();
            superHeroNameList = superHeroNameList.Append(superHeroName);
            Console.WriteLine($"SuperHero {superHeroName} Added!");
            break;
        case "4":
            superHeroNameList = superHeroNameList.Remove(3);
            break;
        case "5":
            isMenuRunning = false;
            Console.WriteLine($"Good bye!");
            break;
        default:
            Console.WriteLine("Please choose from the available menu!");
            break;
    }
} while (isMenuRunning);


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
/*
int deedTimeInHours1 = 10;
int deedTimeInHours2 = 4;
int deedTimeInHours3 = 36;
int monthlySalary = 2500;
double cookiePrice = 1.29;
*/

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