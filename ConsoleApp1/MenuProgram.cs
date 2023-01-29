namespace ConsoleApp1
{
    internal class MenuProgram
    {
        private int _choice;

        public MenuProgram(int choice)
        {
            _choice = choice;
        }

        public int GetChoice()
        {
            return _choice;
        }

        public static int CountWords(string sentence)
        {
            return sentence.Split(' ').Length;
        }

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
