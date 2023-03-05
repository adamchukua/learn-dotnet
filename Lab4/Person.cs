using System;

namespace ConsoleApp4
{
    internal class Person
    {
        public string Name { get; set; }
        private int Age { get; set; }
        protected double Height { get; set; }
        internal bool IsMarried { get; set; }
        public DateTime Created { get; set; }

        public Person(string name, int age, double height, bool isMarried, DateTime created)
        {
            Name = name;
            Age = age;
            Height = height;
            IsMarried = isMarried;
            Created = created;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        private void HaveBirthday()
        {
            Age++;
            Console.WriteLine($"Happy Birthday! I am now {Age} years old.");
        }

        protected bool IsTall()
        {
            return Height >= 6.0;
        }
    }
}
