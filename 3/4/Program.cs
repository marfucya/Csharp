using System;

namespace _4
{
    //Описать класс, реализующий десятичный счетчик, который может увеличивать
    //или уменьшать свое значение на единицу в заданном диапазоне.Предусмотреть 
    //инициализацию счетчика значениями по умолчанию и произвольными значениями.
    //Счетчик имеет два метода: увеличения и уменьшения, — и свойство, 
    //позволяющее получить его текущее состояние.Написать программу, 
    //демонстрирующую все возможности класса.

    class Counter
    {
        private readonly int _min;
        private readonly int _max;
        private int _value;

        public string Current => $"{_value:X}";

        public Counter(int min, int max)
        {
            _min = min;
            _max = max;

            _value = min;
        }

        public void Increase()
        {
            while (_value < _max)
            {
                Console.WriteLine(_value);
                _value++;
            }
        }

        public void Decrease()
        {
            while (_value > _min)
            {
                Console.WriteLine(_value);
                _value--;
            }
        }

        static void Main()
        {
            var c = new Counter(1, 6);

            c.Increase();
            Console.WriteLine(c.Current);

            c.Decrease();
            Console.WriteLine(c.Current);

            Console.ReadKey();
        }
    }

}
