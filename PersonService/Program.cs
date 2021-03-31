using System;

namespace PersonService
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Firstname = "John";
            person.Lastname = "Doe";

            Console.WriteLine(person);
        }
    }
}
