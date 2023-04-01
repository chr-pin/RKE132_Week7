Console.WriteLine("Are you coming or leaving (in/out)");

string userchoice = Console.ReadLine();

if (userchoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodbye();
}




static void PrintHello() // function
{
    Console.WriteLine("Hello, world!");
}

static void PrintGoodbye() // function
{
    Console.WriteLine("See you later!");
}