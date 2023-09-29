Console.WriteLine("Hello, what you do?!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();
Console.WriteLine("User Input: " + userChoice);

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}
else if (userChoice == "A")
{
    PrintSelectedOption("Add a TODO");
}
else if (userChoice == "R")
{
    PrintSelectedOption("Remove a TODO");
}
else if (userChoice == "E")
{
    PrintSelectedOption("Exit");
}
else
{
    PrintSelectedOption("Why no read?");
}

void PrintSelectedOption(string userChoiceSelected)
{
    Console.WriteLine("Selected: " + userChoiceSelected);
    Console.WriteLine(1 < 2 ? 5 : 10);
}


Console.ReadKey();