using System;

class counter
{
    public int current { get; set; }
    public int max { get; set; }
    public int min { get; set; }

    public counter()
    {
        current = 0;
        min = 0;
        max = 100;
    }

    public counter(int min_, int max_)
    {
        min = min_;
        max = max_;
        Random rnd = new Random();
        current = rnd.Next(min, max);
    }

    public int Current
    {
        get
        {
            return current;
        }
    }

    // Инкремент 
    public void Increase()
    {
        current++;
        // проверка выхода за границу диапозона
        if (current > max)
        {
            current = max;
            throw new Exception("Range error"); //Оператор throw используется для генераций исключений.
                   // После throw записано выражение, создающее объект стандартного класса Exception,
                    // который представляет ошибки, происходящие во время выполнения 
        }
    }

    // Декремент 
    public void Decrease()
    {
        current--;
        // Проверка выхода за границу диапазона
        if (current < min)
        {
            current = min;
            throw new Exception("Range error");
        }
    }
}

