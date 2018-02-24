using System;
namespace EA_Lesson2
{
    abstract class AbstractCar
    {
        public string Name { get; set; }
        public string Number
        {
            get;
            set;
        }

        public int YearOfProduction { get; set; }

        public int Width { get; set;  }
        public int Height { get; set; }


        public virtual void Move()
        {
            Console.WriteLine("The car moving");
        }

        public abstract void Beep();


    }
}
