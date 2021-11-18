using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    abstract class Model
    {
        public abstract void Print(Drawer drawer);
    }

    internal class Rectangle : Model
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 100;
            Height = 10;
        }

        public Rectangle(int Width, int Height)
        {
            this.Width = Width;
            this.Height = Height;
        }

        public override void Print(Drawer drawer)
        {
            drawer.DrawRectangle(this);
        }
    }

    internal class Triangle : Model
    {
        public double Height { get; set; }

        public Triangle()
        {
            Height = 40;
        }

        public Triangle(int Height)
        {
            this.Height = Height;
        }

        public override void Print(Drawer drawer)
        {
            drawer.DrawTriangle(this);
        }
    }    
}