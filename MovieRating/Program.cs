using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            double Cp1 = 9.5;
            double Cp2 = 2.0;
            int N = 12;
            double sum = Cp1 * N;

            int Rating(double sum, double Cp2, int N)
            {
                if (Math.Round(sum++ / N++, 1) == Cp2) return N-1;
                return Rating(sum, Cp2, N);
            }
            Console.WriteLine(Rating(sum, Cp2, N)-N);
        }
    }
}
