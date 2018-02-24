using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_2
{
    class Apple
    {
        public Apple()
        {
            Name = "Test apple";
        }
        public Apple(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
    class Orange
    {
        public Orange()
        {
            Name = "Test orange";
        }
        public Orange(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    class Busket<T> where T : new()
    {
        public T GiveElement()
        {
            return new T();
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {

            Busket<Apple> busketApple = new Busket<Apple>();            
            Apple apple = busketApple.GiveElement();
            Console.WriteLine(apple);


            Busket<Orange> busketOrange = new Busket<Orange>();
            Orange orange = busketOrange.GiveElement();
            Console.WriteLine(orange);

            Console.ReadKey();
        }
    }
}
