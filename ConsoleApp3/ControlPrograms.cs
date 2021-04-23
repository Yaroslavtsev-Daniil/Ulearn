using System;

namespace TrainingApps
{
    class ControlPrograms
    {
        ///Для каждой задачи вызываем свои методы

        ///Флаг для работы программы
        static string power = "1";
        static void Main()
        {
            do
            {
                //Выбираем что запустить
                ChooseExpr();

                //Запрашиваем повтор
                AskRestart();
            }
            while (power == "1");
        }
        static void ChooseExpr()
        {
            Console.WriteLine(
                "Что запустить?\nВарианты:\n" +
                "Expr1 ProgramChange - 1\n" +
                "Expr2 ProgramReverse Ver1 - 21\n" +
                "Expr2 ProgramReverse Ver2 - 22\n" +
                "Expr3 Clock - 3\n" +
                "Expr4 SimpleDivisors - 41\n" +
                "Expr4 SimpleDivisorsSuper - 42\n" +
                "Expr5 LeapYears - 5\n" +
                "Expr6 Perpendicular - 6\n" +
                "Expr7 Intersection - 7\n");
            int expr = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (expr)
            {
                case 1: Expr1(); break;
                case 21: Expr2Ver1(); break;
                case 22: Expr2Ver2(); break;
                case 3: Expr3(); break;
                case 41: Expr4(); break;
                case 42: Expr4ver2(); break;
                case 5: Expr5(); break;
                case 6: Expr6(); break;
                /*case 7: Expr7(); break;*/
                case 0:
                    Console.Clear();
                    Console.WriteLine("Работа завершена");
                    break;
            }
        }
        static void AskRestart()
        {
            Console.WriteLine("\nВыбрать задачу - 1\n" + "Выйти 0");
            power = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Работа завершена");
        }
        /// <summary>
        /// Вызов решения задания №1
        /// </summary>
        static void Expr1()
        {
            ProgramChange.ChangeVariables();
        }
        /// <summary>
        /// Вызов решения задания №2 Вариант с массивом char[]
        /// </summary>
        static void Expr2Ver1()
        {
            ProgramReverse.Ver1();
        }
        /// <summary>
        /// Вызов решения задания №2 Вариант математический только для зхзначных чисел.
        /// </summary>
        static void Expr2Ver2()
        {
            ProgramReverse.ReverseNumber2(ProgramReverse.GetNumber());
        }
        /// <summary>
        /// Вызов решения задания №3
        /// </summary>
        static void Expr3()
        {
            Clock.СalculatingAngle(Clock.GetTime());
        }
        /// <summary>
        /// Вызов решения задания №4
        /// </summary>
        static void Expr4()
        {
            //new SimpleDivisors();
            SimpleDivisors.FindDivisors();
        }
        /// <summary>
        /// Вызов решения задания №4 упрощенный вариант
        /// </summary>
        static void Expr4ver2()
        {
            SimpleDivisorsSuper.FindDivisors();
        }
        /// <summary>
        /// Вызов решения задания №5
        /// </summary>
        static void Expr5()
        {
            LeapYears.FindLeapYaers();
        }
        /// <summary>
        /// Вызов решения задания №6
        /// </summary>
        static void Expr6()
        {
            Perpendicular.CalcDistanceOfPerpendicular();
        }
        /*static void Expr7()
        {
            Intersection.СalcСoordinatesOfIntersection();
        }*/
    }
}
