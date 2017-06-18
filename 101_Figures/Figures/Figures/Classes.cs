using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square : Rectangle
    {
        public Square(int side, string color)
            : base(side, side, color)
        { }

        public override string Data()
        {
            return base.Data() + ", this is a square by the way";
        }
    }

    class Rectangle: Figure
    {
        protected int height, width;
        public int Height { get { return height; } }
        public int Width { get { return width; } }

        public Rectangle(int height, int width, string color)
            : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Perimeter()
        {
            return (width + height) * 2;
        }

        public override double Area()
        {
            return width * height;
        }

        public override string Data()
        {
            return base.Data() + " rectangle, sides: " + height + ", " + width;
        }
    }

    class Circle : Figure
    {
        double radius;
        public double Radius { get { return radius; } }

        public Circle(double radius, string color)
            : base(color)
        {
            this.radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override double Area()
        {
            return 2 * radius * radius * Math.PI;
        }

        public override string Data()
        {
            return base.Data() + " circle, radius: " + radius;
        }
    }
}
