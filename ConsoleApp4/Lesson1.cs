using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons
{
    class Lesson1
    {
        /*Реализуйте метод GetMinX для нахождения такого числа x, при котором кривая, заданная уравнением y(x) = ax^2 + bx + c  принимает минимальное значение.
         * Метод должен принимать неотрицательный коэффициент a, а также произвольные коэффициенты b и c, и, если решение существует,
         * возвращать строковое представление искомого x, а иначе — строку Impossible.*/
        private static string GetMinX(double a, double b, double c)
        {
            if (a < 0)
            {
                return "Impossible";
            }
            if (a == 0 && b > 0)
            {
                return "Impossible";
            }
            return ((-b) / (2 * a)).ToString();
        }
        public static void Tests()
        {
            Console.WriteLine(GetMinX(1, 2, 3));
            Console.WriteLine(GetMinX(0, 3, 2));
            Console.WriteLine(GetMinX(1, -2, -3));
            Console.WriteLine(GetMinX(5, 2, 1));
            Console.WriteLine(GetMinX(4, 3, 2));
            Console.WriteLine(GetMinX(0, 4, 5));

            // А в этих случаях решение существует:
            Console.WriteLine(GetMinX(0, 0, 2) != "Impossible");
            Console.WriteLine(GetMinX(0, 0, 0) != "Impossible");
        }
    }
}
