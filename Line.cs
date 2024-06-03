using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Line : GeometricFigure
    {
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public Line(double x, double y, double x2, double y2) : base(x, y)
        {
            X2 = x2;
            Y2 = y2;
        }

        public override (double X1, double Y1, double X2, double Y2) GetBoundingRectangle()
        {
            return (Math.Min(X, X2), Math.Min(Y, Y2), Math.Max(X, X2), Math.Max(Y, Y2));
        }

        public override double GetArea()
        {
            return 0;
        }
    }
}
