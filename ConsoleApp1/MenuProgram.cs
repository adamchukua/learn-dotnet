namespace ConsoleApp1
{
    internal class MenuProgram
    {
        // Contains the user's choice of program
        // 1 - Word counter
        // 2 - Calculator
        private int _choice;

        public MenuProgram(int choice)
        {
            _choice = choice;
        }

        public int GetChoice()
        {
            return _choice;
        }

        // Run program that user choose
        public void Execute()
        {
            switch (_choice)
            {
                case 1:
                    Console.Write("Name of file: ");
                    try
                    {
                        Console.WriteLine("Number of words: " + MenuProgram.CountWords(File.ReadAllText(Console.ReadLine())));
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

                    Console.WriteLine($"{a} {operation} {b} = {MenuProgram.Calculator(a, b, operation)}");

                    break;
                default:
                    Console.WriteLine("You can choose only 1 or 2");
                    break;
            }
        }

        // Count words in string by length of array, splitted by space
        public static int CountWords(string sentence)
        {
            return sentence.Split(' ').Length;
        }

        // Calc 2 doubles with specific operation 
        public static double Calculator(double a, double b, char operation)
        {
            return operation switch
            {
                '+' => a + b,
                '-' => a - b,
                '*' => a * b,
                '/' => a / b,
                _ => throw new ArgumentException("Unknown operation", nameof(operation)),
            };
        }
    }
}
