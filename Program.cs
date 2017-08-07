using System;
using System.Collections.Generic;

namespace Week5_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Shape> Shapes = new List<Shape>();
            Shapes.Add(new Rectangle());
            Shapes.Add(new Circle());
            Shapes.Add(new Triangle());

        foreach (Shape x in Shapes)
        {
            x.Draw();
        }
        }
    }
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Virtual Draw method");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is a Rectangle");
            base.Draw();
        }
    }
    class Circle : Shape
    {
        public override void Draw() 
        {
            Console.WriteLine("This is a Circle");
            base.Draw();
        }

    }
    class Triangle : Shape
    {
        public override void Draw() 
        {
            Console.WriteLine("This is a Triangle");
            base.Draw();
        }

    }
}
