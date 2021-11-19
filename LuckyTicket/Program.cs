using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = { "715068", "445219", "012200" };
            for (int i = 0 ; i < tickets.Length; i++)
            {
                Console.Write($"Билет №{tickets[i]} ");
                int number = Convert.ToInt32(tickets[i]);
                if (isNumberLucky(number + 1) || isNumberLucky(number - 1)) Console.WriteLine("имеет счасливых соседей!");
                else Console.WriteLine("не имеет счастливых соседей.");
            }
            static bool isNumberLucky(int number)
            {
                char[] numbers = number.ToString("000000").ToCharArray();
                int leftSum = 0;
                int rightSum = 0;
                for (int i = 0; i < 6; i++)
                {
                    if (i < 3) leftSum += Convert.ToInt32(numbers[i].ToString());
                    else rightSum += Convert.ToInt32(numbers[i].ToString());
                }
                return leftSum == rightSum;
            }
        }
    }
}
