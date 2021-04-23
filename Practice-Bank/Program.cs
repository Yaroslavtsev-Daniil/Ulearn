using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Console.ReadLine()));
            Console.ReadLine();
        }
        public static double Calculate(string userInput)
        {
            /*Пользователь должен ввести исходные данные с консоли — три числа через пробел:
             * исходную сумму, 
             * процентную ставку (в процентах) и 
             * срок вклада в месяцах. 
             * Программа должна вывести накопившуюся сумму на момент окончания вклада.
             * Детали:
             * В конце каждого месяца происходит капитализация — к сумме прибавляется накопившийся за месяц процент. Далее процент вычисляется от этой увеличенной суммы.
             * Процентная ставка — годовая (то есть в конце месяца сумма на счете увеличивается на одну двенадцатую ставки)
             * Считайте, что вклад открыт в первый день месяца, а срок вклада — это целое количество месяцев.
             * Код, решающий основную задачу нужно оформить в виде метода Calculate, принимающего строку, введенную пользователем.
             * В этой задаче гарантируется, что ввод корректный.
             * Решите эту задачу без использования циклов!
             * Пример ввода
             * 100.00 12 1      Этот ввод соответствует вкладу 100 рублей под 12% годовых на 1 месяц.
             * Пример вывода
             * 101              Через месяц на 100 рублей добавится 1% (1/12 от годового процента), значит общая сумма будет 101.*/

            string [] requestData = userInput.Split(' ');
            
            double deposit = Convert.ToDouble(requestData[0]);
            double percent = Convert.ToDouble(requestData[1]);
            double period = Convert.ToDouble(requestData[2]);

            return deposit * Math.Pow((1 + percent / (12 * 100)), period);
        }
    }
}
