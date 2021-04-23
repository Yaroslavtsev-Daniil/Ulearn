using System;

namespace TrainingApps
{
    /// <summary>
    /// Решение задания 1
    /// </summary>
    class ProgramChange
    {
        static int a;
        static int b;

        /// <summary>
        /// Смена значений 2х переменных
        /// </summary>
        public static void ChangeVariables()
        {
            GetValues();
            ChangeValues();
            OutputValues();
        }

        public static void GetValues()
        {
            Console.Write("Введите a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            string valuein = string.Format("Входные значения: a={0}, b={1}", a, b);
            Console.WriteLine(valuein);
        }
        public static void ChangeValues()
        {
            a = a + b;
            b = a - b;
            a = a - b;            
        }
        public static void OutputValues()
        {
            string valueout = string.Format("Значения на выходе: a={0}, b={1}", a, b);
            Console.WriteLine(valueout);
        }
    }
}
