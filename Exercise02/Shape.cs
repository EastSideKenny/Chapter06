using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public abstract class Shape
    {
        protected double height;
        protected double width;

        public virtual double Height { get { return height; } set { height = value; } }
        public virtual double Width { get { return width; } set { width = value; } }


        public abstract double Area { get; }


    }
}
