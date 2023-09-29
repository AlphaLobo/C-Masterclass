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
            Start();
            return;
        case "A":
            AddTODO();
            Start();
            return;
        case "R":
            RemoveItem();
            return;
        case "E":
            Console.WriteLine("Goodbye.");
            validInput = true;
            return;
        default:
            Console.WriteLine("no man, no.");
            validInput = false;
        break;
    }
}

void ShowAllTODOS(){
    if(allTODOItems.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
    }
    else
    {
        for(int i = 0; i < allTODOItems.Count; i++)
        {
            Console.WriteLine((i + 1) + ": " + allTODOItems[i]);
        }
    }
}

void AddTODO()
{
    Console.WriteLine("Enter the TODO description");

    string newTODO = Console.ReadLine();

    if(newTODO.Length == 0)
    {
        Console.WriteLine("The description cannot be empty.");
        Console.WriteLine("Enter the TODO description");
    }
    else
    {
        allTODOItems.Add(newTODO);
        Console.WriteLine("TODO successfully added " + newTODO);
        Start();
    }

}

void RemoveItem()
{
    if(allTODOItems.Count == 0)
    {
        ShowAllTODOS();
    }
    else
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");
        ShowAllTODOS();

        string incomingIndex = Console.ReadLine();
        int itemId = 0;
        bool isValidInput = int.TryParse(incomingIndex, out itemId);
        bool isValidIndex = (itemId <= allTODOItems.Count && itemId > 0);
        if (isValidInput && isValidIndex)
        {
            if (incomingIndex == "")
            {
                Console.WriteLine("Selected index cannot be empty.");
                RemoveItem();
            }
            else
            {
                string removingTODO = allTODOItems[itemId - 1];

                Console.WriteLine("You are about to remove \"" + removingTODO + "\", are you sure? (y/n)");

                string yOrN = Console.ReadLine();
                if (yOrN == "y")
                {
                    allTODOItems.RemoveAt(itemId - 1);
                    Console.WriteLine("TODO removed: " + removingTODO);
                }
                else
                {
                    Console.WriteLine("nothing removed");
                }
            }
        }
        else
        {
            Console.WriteLine("The given index is not valid.");
            RemoveItem();
        }
        
    }

    Start();
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