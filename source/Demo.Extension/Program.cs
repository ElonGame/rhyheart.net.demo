using System;

namespace Demo.Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Rhy Heart",
                Age = 23
            };

            person.Show();

            Console.ReadKey();
        }
    }
}
