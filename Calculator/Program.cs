int firstNumber;
int secondNumber;
string result;
string inputAction;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

inputAction = Console.ReadLine();

result = Calculate(inputAction, firstNumber, secondNumber);

Console.WriteLine(result);

int Add(int firstNumber, int secondNumber)
{
    return firstNumber + secondNumber;
}

int Subtract(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}

int Multiply(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}

string Calculate(string action, int firstNumber, int secondNumber)
{
    string operrand;
    int answer = 0;
    if(action.ToUpper() == "A")
    {
        operrand = "+";
        answer = Add(firstNumber, secondNumber);
    }else if(action.ToUpper() == "S")
    {
        operrand = "-";
        answer = Subtract(firstNumber, secondNumber);
    }
    else if(action.ToUpper() == "M") 
    {
        operrand = "*";
        answer = Multiply(firstNumber, secondNumber);
    }
    else
    {
        return "Invalid option";
    }
    return $"{firstNumber.ToString()} {operrand} {secondNumber.ToString()} = {answer.ToString()}";
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();