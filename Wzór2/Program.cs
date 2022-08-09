using System;

namespace Wzór2
{
    class Program
    {
        public static void Gwiazdki(int n)
        {
          int i,p, j,k,zz;
         // nn = n;
          int Rzad(int n) {
                if (n % 2 == 0) { p = n / 2; }
                else { p = (n + 1) / 2; }
                return p;
            }
            zz = Rzad(n);
            for (i = zz; i >= 1; i--)
            {
                for (j = zz; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (k = 1; k < (i * 2); k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {

            Gwiazdki(3);
            Gwiazdki(15);
        }
    }
}
