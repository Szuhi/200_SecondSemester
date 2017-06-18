using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Figure
    {
        bool holey;
        string color;

        public string Color { get { return color; } }

        public Figure(string color)
        {
            this.color = color;
            holey = false;
        }

        public abstract double Perimeter();
        public abstract double Area();

        public void MakeItHoley()
        {
            holey = true;
        }

        public virtual string Data()
        {
            if (holey)
                return "Holey, and " + color;
            return "Not holey, but " + color; 
        }
    }
}
