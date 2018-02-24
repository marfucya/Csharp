using System;

namespace _5
{
   // Создать класс с двумя переменными.Добавить конструктор с входными 
   //параметрами.Добавить конструктор, инициализирующий члены класса
    //по умолчанию.Добавить деструктор, выводящий на экран сообщение об
    //удалении объекта.

    class MyClass
    {
        int a;
        int b;

        public MyClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        ~MyClass()
        {
            Console.WriteLine("Объект уничтожен");
        }

        public void objectGenerator(int i)
        {
            MyClass ob = new MyClass(i);
        }
       
    }

    class Program
    {
        static void Main()
        {
            int i = 1;
            MyClass myClass = new MyClass(0,0);
            for (; i < 100; i++)
            {
                myClass.objectGenerator(i);
            }


           // Console.WriteLine(5);

            //Console.ReadKey();
        }
    }
}
