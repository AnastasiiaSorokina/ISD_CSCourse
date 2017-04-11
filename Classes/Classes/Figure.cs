using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Figure
    {
        public List<Point> points;

        public double Perimeter;

        public Figure(Point A, Point B, Point C)
        {
            points = new List<Point> { A, B, C };
            PerimeterCalculator();
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            points = new List<Point> { A, B, C, D };
            PerimeterCalculator();
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points = new List<Point> { A, B, C, D, E };
            PerimeterCalculator();
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
        }

        public void PerimeterCalculator()
        {
            int count = 0;
            foreach (Point point in points)
            {
                count++;
            }

            for (int i = 0; i < count-1; i++)
            {
                Perimeter += LengthSide(points[i], points[i + 1]);
            }

            Perimeter += LengthSide(points[count - 1], points[0]);
        }
    }
}
