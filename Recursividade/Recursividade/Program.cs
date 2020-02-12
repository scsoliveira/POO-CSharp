using System;

namespace Recursividade
{
    class Program
    {

        static void Main(string[] args)
        {
            Contas ct = new Contas();

            //POTENCIA
            Console.WriteLine(ct.Pot(2, 6));
            //FIBO
            Console.WriteLine(ct.Fib(10));
            //SOMA
            Console.WriteLine(ct.Soma(1234));

            Console.Read();
        }

        



    }

}
