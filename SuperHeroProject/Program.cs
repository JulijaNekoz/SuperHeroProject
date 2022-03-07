
Console.WriteLine("***********GENERAL INFO*************");
string name = "Groot";
int age = 25;
string ability1 = "Superhuman strength";
string ability2 = "Enhanced speed";
string ability3 = "Immortality";
bool isEvil = false;
int monthlySalary = 3000;
int workDays = 22;
double cookiePrice = 1.29;


Console.WriteLine("**********FINANCIAL INFO***************");
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

int totalTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
double oneDeedTime = totalTime / 3;
int totalCookies = totalTime * 5;


