using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            GeometricFigure point = new Point(1, 1);
            GeometricFigure line = new Line(1, 1, 4, 4);
            GeometricFigure polygon = new Polygon(0, 0, new List<(double X, double Y)> { (1, 1), (5, 1), (4, 5), (1, 4) });
            GeometricFigure ellipse = new Ellipse(0, 0, 3, 2);

            PrintFigureInfo(point);
            PrintFigureInfo(line);
            PrintFigureInfo(polygon);
            PrintFigureInfo(ellipse);
        }

        public static void PrintFigureInfo(GeometricFigure figure)
        {
            var (x1, y1, x2, y2) = figure.GetBoundingRectangle();
            Console.WriteLine($"Figure: {figure.GetType().Name}");
            Console.WriteLine($"Bounding Rectangle: ({x1}, {y1}) to ({x2}, {y2})");
            Console.WriteLine($"Area: {figure.GetArea()}");
            Console.WriteLine();
        }
    }
}
