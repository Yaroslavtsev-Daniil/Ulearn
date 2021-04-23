using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApps
{
    struct ThreePoints
    {
        ///Структура, создающая 3 точки (T,A,B) в пространстве и метод, принимающий их координаты из консоли
        public (double x, double y) pointT;
        public (double x, double y) pointA;
        public (double x, double y) pointB;

        /// <summary>
        /// Метод, принимающий значения координат 3х точек из консоли
        /// </summary>
        public void GetValues()
        {
            Console.Write("Введите координаты точки T:\n" + "Координата по Х - ");
            pointT.x = double.Parse(Console.ReadLine());
            Console.Write("Координата по У - ");
            pointT.y = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки А:\n" + "Координата по Х - ");
            pointA.x = double.Parse(Console.ReadLine());
            Console.Write("Координата по У - ");
            pointA.y = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки В:\n" + "Координата по Х - ");
            pointB.x = double.Parse(Console.ReadLine());
            Console.Write("Координата по У - ");
            pointB.y = double.Parse(Console.ReadLine());
            Console.WriteLine($"Точка T[{pointT}];\n" + $"Прямая: Точка A[{pointA}]; Точка B[{pointB}];");
        }
    }
}