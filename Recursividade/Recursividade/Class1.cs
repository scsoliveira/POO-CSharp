using System;
using System.Collections.Generic;
using System.Text;

namespace Recursividade
{
    class Contas
    {
        public int Pot(int x, int n)
        {
            if (n == 0) return 1;

            return x * Pot(x, n - 1);
        }

        public int Fib(int n)
        {
            if (n <= 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        public int Soma(int n)
        {
            if (n < 10) return n;
            return n % 10 + Soma(n / 10);
        }
    }
}
