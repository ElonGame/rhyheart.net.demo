using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Extension
{
    public static class PersonExtension
    {
        public static void Show(this Person person)
        {
            var desc = $"My name is {person.Name},I'm {person.Age} years old!";

            Console.WriteLine(desc);
        }
    }
}
