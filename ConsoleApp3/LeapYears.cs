using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingApps
{
    class LeapYears
    {
        /*Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.
         Предполагаем, что каждый четвертый год от 0 - високосный, т.е. 4,8 и т.д.
        1937 и 1986
         */
        static int a;
        static int b;
        static bool valid;
        public static void FindLeapYaers()
        {
            GetYears();
            CheckYaers();
            if (valid != true) return;
            CheckEnds();


        }
        public static void GetYears()
        {
            Console.WriteLine("Expr5. Найти количество високосных лет на отрезке [a, b] не используя циклы.");
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Проверяем допустимость введенных значений
        /// </summary>
        public static void CheckYaers()
        {
            if (b <= a || b == 0)
            {
                Console.WriteLine("Введенные данные не прошли проверку!");
                valid = false;
            }
            else
            {
                valid = true;
                Console.WriteLine("Введенные данные корректны. Считаем...");
                Console.WriteLine($"b - a = {b - a}\n" + $"(b - a) / 4 = {(b - a) / 4}\n");
            }
        }
        /// <summary>
        /// Cчитает результат, на основе проверки цонцов отрезка.
        /// </summary>
        public static void CheckEnds()
        {
            if (a % 4 != 0 && b % 4 != 0)//Если оба не високосные
            {
                Console.WriteLine($"Ответ {(b - a) / 4}");
            }
            else Console.WriteLine($"Ответ {((b - a) / 4) + 1}");//Если хотя бы один високосный
        }
    }    
}
