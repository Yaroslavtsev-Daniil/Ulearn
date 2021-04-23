using System;

namespace TrainingApps
{
    class ProgramReverse
    {

        /// Задается натуральное трехзначное число (гарантируется, что трехзначное).
        /// Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
        /// 123
        /// 321

        /// <summary>
        /// Возвращает число с переставленными в обратном порядке цифрами
        /// </summary>
        public static void Ver1()
        {
            ReverseNumber(GetNumber());
        }
        /// <summary>
        /// Возвращает число с переставленными в обратном порядке цифрами
        /// </summary>
        public static void Ver2()
        {
            ReverseNumber2(GetNumber());
        }

        /// <summary>
        /// Возвращает любое число с переставленными в обратном порядке цифрами
        /// </summary>
        /// <param name="num">Строка с введенным числом</param>
        public static void ReverseNumber(string num)
        {
            char[] strbuf = num.ToCharArray();
            Array.Reverse(strbuf);
            num = new String(strbuf);
            Console.Write("Перевернутое число: ");
            Console.WriteLine(num);
        }
        public static string GetNumber()
        {
            Console.Write("Введите число:");
            string strNumber = Console.ReadLine();
            return strNumber;
        }
        /// <summary>
        /// Возвращает число с переставленными в обратном порядке цифрами. Только для трехзначных чисел!!!
        /// </summary>
        /// <param name="num">Строка с введенным числом</param>
        public static void ReverseNumber2(string num)
        {
            int number = int.Parse(num);
            int o = number/100;
            int t = (number - (int)(number / 100) * 100)/10;
            int h = number - (int)(number / 10)*10;
            int revnumber = h * 100 + t * 10 + o;
            Console.Write("Перевернутое число");
            Console.WriteLine(revnumber);
            /*число разделить на 100 и 10 и 1, результаты 100 и 1 при сложении обменять местами, умножив на соответствующие коэф.
            375
            number = 375 - 375/100 = 3.75 и ,75 должно отсекаться приведением типа к инт
            */
        }
    }    
}
