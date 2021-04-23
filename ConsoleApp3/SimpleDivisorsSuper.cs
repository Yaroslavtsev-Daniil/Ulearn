using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TrainingApps
{
    class SimpleDivisorsSuper
    {
        /*Expr4. Найти количество чисел меньших N, которые имеют простые делители X или Y*/
        static int n;
        static int x;
        static int y;
        static int start;
        static ArrayList divisors = new ArrayList();//Коллекция делителей
        /// <summary>
        /// Ищет количество чисел меньших N, которые имеют простые делители X или Y и выводит их, используя коллекцию.
        /// </summary>
        public static void FindDivisors()
        {
            GetValues();
            CheckNumbers();
            FindCheckstart();
            GetDivisors();
            Answer();
        }
        /// <summary>
        /// Ввод данных
        /// </summary>
        public static void GetValues()
        {
            Console.WriteLine("Expr4.Найти количество чисел меньших N, которые имеют простые делители X или Y.");
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите делитель X: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Введите делитель Y: ");
            y = int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Проверяем допустимость введенных значений
        /// </summary>
        public static void CheckNumbers()
        {
            if (y <= 0 || x <= 0 || n <= 0 || x > n || y > n)
            {
                Console.WriteLine("Введенные данные не прошли проверку!");
                Environment.Exit(0);
            }
            Console.WriteLine("Введенные данные корректны. Считаем...");
        }
        /// <summary>
        /// Определяет значение start, с которого начнется обработка ряда чисел
        /// </summary>
        public static void FindCheckstart()
        {
            //Меньшее из делителей будет равно наименьшему делимому из искомых.
            //Числа меньше start можно опустить как неподходящие.
            if (x > y)
            {
                start = y;
            }
            else
            {
                start = x;
            }
        }
        /// <summary>
        /// Получение делимых в коллекцию divisors
        /// </summary>
        public static void GetDivisors()
        {
            //Запускаем прогон от start до n-1 для поиска делимых нацело чисел.
            for (int i = start; i < n; i++)
            {
                //Определение остатка
                Math.DivRem(i, x, out int divX);
                Math.DivRem(i, y, out int divY);
                //Console.WriteLine($"i={i} divX={divX} divY={divY}");//Вывод для отладки
                if (divX == 0 || divY == 0)//Если хотя бы один делит число без остатка, то добавляем число в коллекцию
                {
                    divisors.Add(i);
                }
            }
        }
        /// <summary>
        /// Выводит строку с кратким ответом и список всех делимых
        /// </summary>
        public static void Answer()
        {
            Console.Write(
                $"Всего {divisors.Count} чисел меньших {n}, которые имеют простые делители {x} или {y}.\n" +
                "Вот их список: ");
            foreach (object o in divisors)
            {
                Console.Write($"{o} ");
            }
        }
    }
}
