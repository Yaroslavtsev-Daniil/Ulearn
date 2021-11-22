using System;

namespace Bracket
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets1 = "()()()))(()))(()()";
            string brackets2 = "()(((()(())())())())";

            Console.Write($"brackets1 - {iSBracketsCorrect(brackets1)}");
            if (iSBracketsCorrect(brackets1)) Console.Write($"; Lvl: {CaclLvl(brackets1)}");
            Console.WriteLine();
            Console.Write($"brackets2 - {iSBracketsCorrect(brackets2)}");
            if (iSBracketsCorrect(brackets2)) Console.Write($"; Lvl: {CaclLvl(brackets2)}");
            Console.Write($"; Lvl: {CaclLvl(brackets1)}");
            Console.WriteLine();

            CheckBrackets(brackets1);
            CheckBrackets(brackets2);
        }

        private static int CaclLvl(string s)
        {
            char[] br = s.ToCharArray();
            int lvl = 0;
            int maxlvl = 0;
            
            for (int i = 0; i < br.Length; i++)
            {
                if (br[i] == '(')
                {
                    lvl++;
                    if (lvl > maxlvl) maxlvl++;
                }
                else lvl--;
            }
            return maxlvl;
        }

        private static bool iSBracketsCorrect(string s)
        {
            string subString = "()";
            while (s.Length > 1 && s.IndexOf(subString) >= 0)
            {
                s = s.Remove(s.IndexOf(subString), 2);
            }


            if (s.Length == 0) return true;
            else return false;
        }
        private static void CheckBrackets(string s)
        {
            char[] br = s.ToCharArray();
            int lvl = 0;
            int maxlvl = 0;

            for (int i = 0; i < br.Length; i++)
            {
                if (br[i] == '(')
                {
                    lvl++;
                    if (lvl > maxlvl) maxlvl++;
                }
                else if (br[i] == ')' && lvl > 0) lvl--;
                else
                {
                    Console.WriteLine("String isn't correct");
                    maxlvl = 0;
                    break;
                }
            }
            if (maxlvl != 0) Console.WriteLine($" {s} - correct, lvl = {maxlvl}");

        }
    }
}
