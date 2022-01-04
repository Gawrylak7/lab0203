using System.Collections.Generic;

namespace lab2_z1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> lista = new List<Shape>();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();
            lista.Add(triangle);
            lista.Add(rectangle);
            lista.Add(circle);
            lista[0].Draw();
            lista[1].Draw();
            lista[2].Draw();
        }
    }
}
