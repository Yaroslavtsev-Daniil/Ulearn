using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApps
{
    class Intersection
    {
        static double at;
        public static void СalcСoordinatesOfIntersection()
        {
            Perpendicular PerpendicularOfIntersection = new Perpendicular();
            Perpendicular.GetValues();
            distanceAB = Perpendicular.CalcDistance(pointA, pointB);
            GetCathetus();
        }
        public static void GetCathetus(double distanceTC, double distanceTA)
        {
            cathetus = Math.Sqrt(Math.Pow(distanceTA, 2) - Math.Pow(distanceTC, 2));
        }
    }
}
