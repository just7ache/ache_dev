using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubly_connected
{
    internal class Program
    {
        public class Vertex
        {
            public double X { get; set; }
            public double Y { get; set; }
            public Vertex(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        static void Main(string[] args)
        {
            LinkedList<Vertex> vertices = new LinkedList<Vertex>();
            vertices.AddLast(new Vertex(0.0, 0.0));
            vertices.AddLast(new Vertex(0.0, 2.0));
            vertices.AddLast(new Vertex(2.0, 2.0));
            vertices.AddLast(new Vertex(2.0, 0.0));
            vertices.AddLast(new Vertex(0.0, 0.0));
            double sum = 0;
            LinkedListNode<Vertex> vertex = vertices.First;
            for (int i = 0; i < vertices.Count - 1; i++)
            {
                //sum += Abs(vertex.Value.X + vertex.Next.Value.X) * (vertex.Value.Y - vertex.Next.Value.Y);
                vertex = vertex.Next;
            }
            double square = 0.5 * sum;
            Console.WriteLine($"Площадь многоугольника {square}");
        }
    }
}
