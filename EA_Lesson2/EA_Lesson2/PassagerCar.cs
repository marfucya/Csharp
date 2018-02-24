using System;
namespace EA_Lesson2
{
    public class PassagerCar : AbstractCar
    {
        public override void Move()
        {
            Console.WriteLine("The passager car moving clowly");
        }

        public override void Beep ()
        {
            Console.WriteLine( "The passager car beeping");
        }
    }
}
