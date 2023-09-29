using System.Runtime.CompilerServices;

bool validInput = false;
List<string> allTODOItems = new List<string>();
string input = null;

allTODOItems.Add("test item");
allTODOItems.Add("another test item");

Console.WriteLine("Hello, World!");
do
{
    Start();
}
while (!validInput);

void listActions(string input, out bool validInput)
{
    validInput = true;
    switch (input.ToUpper())
    {
        case "S":
            ShowAllTODOS();
            return;
        case "A":
            AddTODO();
            return;
        case "R":
            RemoveItem();
            return;
        case "E":
            Console.WriteLine("Goodbye.");
            return;
        default:
            Console.WriteLine("no man, no.");
            validInput = false;
        break;
    }
}

void ShowAllTODOS(){
    for(int i = 0; i < allTODOItems.Count; i++)
    {
        Console.WriteLine((i + 1) + ": " + allTODOItems[i]);
    }
    Start();
}

void AddTODO()
{
    Console.WriteLine("What would you like to add?");

    string newTODO = Console.ReadLine();
    allTODOItems.Add(newTODO);

    Console.WriteLine("Item added successfully");
    Start();
}

void RemoveItem()
{
    Console.WriteLine("Which item would you like to remove?");
    int itemId = int.Parse(Console.ReadLine());

    Console.WriteLine("You are about to remove " + allTODOItems[itemId - 1] + ", are you sure?");

    string yOrN = Console.ReadLine();
    if(yOrN == "y")
    {
        allTODOItems.RemoveAt(itemId - 1);
    }
    else
    {
        Console.WriteLine("you nini...");
    }
}

void Start()
{
    validInput = false;
    
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    input = Console.ReadLine();

    listActions(input, out validInput);
}

Console.ReadLine();