using System;

namespace BasicLesson1
{

    class Point
    {
        public int field1;
        public int field2;
        public string field3;

        public int Field1
        {
            get { return field1; }
        }

        public int Field2
        {
            get { return field2; }
        }

        public string Field3
        {
            get { return field3; }
        }

        public Point(int field1, int field2, string field3)
        {
            this.field1 = field1;
            this.field2 = field2;
            this.field3 = field3;
        }
     }

     class Figure
     {

        Point p1, p2, p3, p4, p5;

        public Figure ( Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
            : this(p1, p2, p3)
        {
            this.p4 = p4;
            this.p5 = p5;
        }

        public double LengthSide(Point A, Point B)
        {
            return
        }

     }
       


    class Program
    {
        static void Main()
        {
            


            Console.ReadKey();
        }
    }
}


