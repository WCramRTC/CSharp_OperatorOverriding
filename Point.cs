using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OperatorOverriding
{
    public class Point
    {

        int _x;
        int _y;

        public Point(int x, int y )
        {
            _x = x;
            _y = y;
        } // Point

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        // Adding Two Points

        // Required
        // To override an operator, you method must be
        // static
        // operator keyword
        // the operator to override ( +, -, >, <, etc.... )
        // Two parameter's ( the first argument represents the left value, the second the right )
        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);      
        }

        // Result:
        // Point p1 = new Point(5, 10); // X : 5, Y : 10
        // Point p2 = new Point(10, 20); // X : 10, Y : 20
        // Point pointResult = p1 + p2; // X : 15, X : 30

        // Subtracting Two Points
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.X - p2.X, p1.Y - p2.Y);
        }

        // Multiplying Two Points
        public static Point operator *(Point p1, Point p2)
        {
            return new Point(p1.X * p2.X, p1.Y * p2.Y);
        }

        // Override Comparison Operators
        // Same as math operators
        // Return a bool
        // Must have a matching override ( if you do >, you must do < )
        // You can override comparison operators too
        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X;
        }

        // You can override comparison operators too
        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X;
        }

        // Result above compares the X of both points and returns a result.
        // Point p1 = new Point(25, 10);
        // Point p2 = new Point(13, 15);
        // bool pGreaterThan = p1 > p2; // True
        // bool pLessThan = p1 < p2; // False

        public override string ToString()
        {
            return $"X:{_x} - Y:{_y} ";
        }

    }
}
