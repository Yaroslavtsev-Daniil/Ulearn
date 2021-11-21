using System;

namespace Bracket
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets1 = "()()()))(()))(()()";
            string brackets2 = "()(((()()())())())";

            Console.WriteLine($"brackets1 - {CheckBrackets(brackets1)}");
            Console.WriteLine($"brackets2 - {CheckBrackets(brackets2)}");
        }

        private static bool CheckBrackets(string s)
        {
            string subString = "()";
            while (s.Length > 1 && s.IndexOf(subString) >= 0) s = s.Remove(s.IndexOf(subString), 2);

            if (s.Length == 0) return true;
            else return false;
        }
    }
}
