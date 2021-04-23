using System;

namespace TrainingApps
{
    class Clock
    {
        /*Expr3. Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками.
         * Например, 
         * 5 часов -> 150 градусов, 
         * 20 часов -> 120 градусов. 
         * Не использовать циклы.*/
        /// <summary>
        /// Вычисляет угол в градусах между часовой и минутной стрелками
        /// </summary>
        public static int GetTime()
        {
            Console.WriteLine("Введите час дня в формате 24 часа.");
            Console.Write("Час = ");
            int hour = int.Parse(Console.ReadLine());
            return hour;
        }
        public static void СalculatingAngle(int hour)
        {
            int angle;
            /*Окружность 360
                12 секторов по 30
            */

            //Приведем 24 часа к 12
            if (hour - 12 > 0)
            {
                hour = hour - 12;
            }

            //На какой позиции относительно 6 стоит стрелка слева или справа
            //И считаем угол, зная что Окружность = 12 секторов по 30
            if (hour < 6)
            {
                angle = hour * 30;
            }
            else
            {
                angle = (12 - hour) * 30;
            }
            string result = string.Format("Угол между часовой и минутной стрелкой равен {0} градусов.", angle);
            Console.Write(result);
            
        }
    }
}
