using System;

namespace BasicLesson1
{

    class Rectangle
    {
        public double side1;
        public double side2;
        public double area;
        public double perimetr;

        public Rectangle(double side1, double side2)
        {
            this.side1 =  side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return  area = side1 * side2;
        }


        public double PerimeterCalculator()
        {
            return perimetr = (side1 + side2) * 2;
        }
       

        public double Area
        {
            get
            {
                return area;
            }
        }

        public double Perimeter
        {
            get
            {
                return perimetr;
            }
        }

    
        static void Main()
        {
            

            Rectangle area1 = new Rectangle(4.7, 9.3);
            area1.AreaCalculator();
            Console.WriteLine(area1.AreaCalculator());

            Rectangle perimetr1 = new Rectangle(4.7, 9.3);
            perimetr1.PerimeterCalculator();
            Console.WriteLine(perimetr1.PerimeterCalculator());

            Console.ReadKey();
        }
    }
}


