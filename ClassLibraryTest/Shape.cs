using System;

namespace ClassLibraryTest
{
    public abstract class Shape
    {
        public virtual double? Area()
        {
            return null;
        }
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double? Area()
        {
            return _radius * 2 * Math.PI;
        }
    }

    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double? Area()
        {
            double p = (_a+_b+_c)/2;

            return Math.Sqrt(p*(p-_a)*(p-_b)*(p-_c));
        }

        public bool IsRight()
        {
            if (((Math.Pow(_a,2) + Math.Pow(_b,2))) == (Math.Pow(_c,2)) ||
                ((Math.Pow(_a, 2) + Math.Pow(_c, 2))) == (Math.Pow(_b, 2)) ||
                ((Math.Pow(_b, 2) + Math.Pow(_c, 2))) == (Math.Pow(_a, 2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
