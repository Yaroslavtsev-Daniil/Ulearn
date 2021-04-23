using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApps
{
    class Perpendicular
    {
        public static double distanceTC;
        public static double distanceAB;
        public static void CalcDistanceOfPerpendicular()
        {
            Console.WriteLine("Expr6.Посчитать расстояние от точки до прямой, заданной двумя разными точками.");
            ThreePoints PerpendicularWithLine = new ThreePoints();
            PerpendicularWithLine.GetValues();
            distanceAB = CalcDistance(PerpendicularWithLine.pointA, PerpendicularWithLine.pointB);
            distanceTC = CalcLengthOfPerpendicular(PerpendicularWithLine.pointA, PerpendicularWithLine.pointB, PerpendicularWithLine.pointT, distanceAB);
            Console.WriteLine($"Расстояние от точки до прямой {distanceTC}");
        }
        /*Expr6.Посчитать расстояние от точки до прямой, заданной двумя разными точками.*/
        public static double CalcLengthOfPerpendicular((double x, double y) A, (double x, double y) B, (double x, double y) T, double AB)
        {
            return Math.Abs((B.y - A.y) * T.x - (B.x - A.x) * T.y + B.x * A.y - A.x * B.y) / AB;
        }
        public static double CalcDistance((double x, double y) A, (double x, double y) B)
        {
                return Math.Sqrt(Math.Pow(B.y - A.y, 2) + Math.Pow(B.x - A.x, 2));
        }
    }
}
