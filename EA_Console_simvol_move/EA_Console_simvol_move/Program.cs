using System;
using System.Collections.Generic;

namespace Queue
{
    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(1);
            numbers.Enqueue(2); 
            numbers.Enqueue(3); 

            Queue<Person> persons = new Queue<Person>();
            persons.Enqueue(new Person() { Name = "Галя" });
            persons.Enqueue(new Person() { Name = "Настя" });
            persons.Enqueue(new Person() { Name = "Петя" });

            Person pp = persons.Peek();
            Console.WriteLine("Первый в очереди - {0}", pp.Name);

            Console.WriteLine("Всего в очереди {0} человек", persons.Count);

            foreach (Person p in persons)
            {
                Console.WriteLine(p.Name);
            }

            //Person person = persons.Dequeue(); 
            //Console.WriteLine(person.Name);

            Console.ReadLine();
        }
    }
}
