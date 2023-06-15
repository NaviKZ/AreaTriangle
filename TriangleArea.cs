using System;

namespace TriangleArea
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты X1 первой точки:");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты Y1 первой точки:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты X2 второй точки:");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты Y2 второй точки:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты X3 третьей точки:");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты Y3 третьей точки:");
            double y3 = Convert.ToDouble(Console.ReadLine());

            double epsilon = 1E-10;

            if (Math.Abs((x3 - x1) * (y2 - y1) - (x2 - x1) * (y3 - y1)) <= epsilon)
            {
                Console.WriteLine("Ошибка!!! Точки лежат на одной прямой");
            }
            else
            {
                double sideALength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                double sideBLength = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                double sideCLength = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

                double trianglePerimeter = sideALength + sideBLength + sideCLength;
                double halfTrianglePerimeter = trianglePerimeter / 2;
                double triangleArea = Math.Sqrt(halfTrianglePerimeter * (halfTrianglePerimeter - sideALength) *
                    (halfTrianglePerimeter - sideBLength) * (halfTrianglePerimeter - sideCLength));

                Console.WriteLine($"Площадь треугольника равна: {triangleArea:f2}");
            }

            Console.ReadKey();
        }
    }
}
