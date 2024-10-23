using System.Diagnostics.Metrics;

bool continueProgram = true;
do
{
    Console.WriteLine("Hello, World!");

    Console.WriteLine("would you like to continue? (y/n)");
    string stopAnswer = Console.ReadLine();
    if (stopAnswer.ToLower() == "n")
    {
        continueProgram = false;
    }
} while (continueProgram == true);
Console.WriteLine("Goodbye!");

Console.WriteLine("Please give me a number.");
int userNumber = int.Parse(Console.ReadLine());
Console.WriteLine();

for (int i = userNumber; i >= 0; i--)
{
    Console.WriteLine(i);
}
for (int i = 0; i <= userNumber; i++)
{
    Console.WriteLine(i);
}


Console.WriteLine();

bool keypadLocked = false;


while (keypadLocked == false)
{
    Console.WriteLine("Please enter a combination for the keypad.");
    int keypadEntry = int.Parse(Console.ReadLine());

    if (keypadEntry == 1234)
    {
        keypadLocked = true;
    }
    if (keypadEntry != 1234)
    {
        keypadLocked = false;
    }


}

Console.WriteLine("Welcome back.");
//now with limited number of tries
Console.WriteLine();

Console.WriteLine("Now you only have 5 tries to get it right. The combination has now been changed!");
Console.WriteLine();



bool keypadLock = false;
int tryCounter = 1;

while (keypadLock == false && tryCounter < 6)
{

    Console.WriteLine("Please enter a combination for the keypad.");
    int keypadEnter = int.Parse(Console.ReadLine());


    if (keypadEnter != 2345)
    {
        keypadLock = false;
        tryCounter++;
    }


    if (keypadEnter == 2345)
    {
        keypadLock = true;
        break;
    }

}
if (keypadLock == true)
{
    Console.WriteLine();
    Console.WriteLine("Welcome");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Too many failed attempts. You've been locked out.");
}