using System;

namespace Lessons
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
                ChooseLesson();

                //Запрашиваем повтор
                AskRestart();
            }
            while (power == "1");
        }
        static void ChooseLesson()
        {
            Console.WriteLine(
                "Что запустить?\nВарианты:\n" +
                "Первое - 1\n");
                
            int Lesson = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Lesson)
            {
                case 1: Lesson1.Tests(); break;
                
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
        
    }
}
