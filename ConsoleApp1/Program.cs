Console.WriteLine("1 - Word counter\n2 - Calculator");
Console.Write("Choose program: ");

int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.Write("Name of file: ");
        try
        {
            Console.WriteLine("Number of words: " + CountWords(File.ReadAllText(Console.ReadLine())));
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        break;
    case 2:
        Console.Write("Enter the number A: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the number B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the operation (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine($"{a} {operation} {b} = {Calculator(a, b, operation)}");

        break;
    default:
        Console.WriteLine("You can choose only 1 or 2");
        break;
}

int CountWords(string sentence)
{
    return sentence.Split(' ').Length;
}

double Calculator(double a, double b, char operation)
{
    switch (operation)
    {
        case '+':
            return a + b;
        case '-':
            return a - b;
        case '*':
            return a * b;
        case '/':
            return a / b;
        default:
            throw new ArgumentException("Unknown operation", nameof(operation));
    }
}