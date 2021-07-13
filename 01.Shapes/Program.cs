using System;

namespace _01.Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            IDrawable circle = new Circle(radius);

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            IDrawable rectangle = new Rectangle(width, height);

            circle.Draw();
            rectangle.Draw();
        }
    }
}
