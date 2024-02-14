using System;
namespace Uppgift_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Störst(1, 4));
            Console.WriteLine(Störst(24, 5));
            Console.WriteLine(Störst(6, 6));
        }
        /// <summary>
        /// Returnerar det största av 2 tal
        /// </summary>
        /// <param name="tal1">Tal 1</param>
        /// <param name="tal2">Tal 1</param>
        /// <returns>Det största av talen</returns>
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}