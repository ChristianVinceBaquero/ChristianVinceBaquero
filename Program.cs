using Quiz1;
using System;

namespace Quiz1
{
    public class Person
    {
        public string Name { get; set; }
        public int Weight { get; set; }

    }
}

class Progress
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>();

        while (true)
        {
            Console.WriteLine("Enter new data? [Y/N]");

            if (Console.ReadLine() == "N")
            {
                break;
            }

            Person person1 = new Person();

            Console.WriteLine("Enter Person Name = ");
            person1.Name = Console.ReadLine();

            Console.WriteLine("Enter Person Weight = ");
            person1.Weight = int.Parse(Console.ReadLine());

            list.Add(person1);
        }

        list.ForEach(x =>
        {
            Console.WriteLine(x.Name);
            Console.WriteLine(x.Weight);
            Console.WriteLine("=====================");
        });

    }
}