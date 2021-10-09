using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String resultado = "";
            long contador2 = 50000;
            for (int i = 0; i <= contador2; i++)
            {
                resultado += " " + i;
            }
            Console.WriteLine(resultado);
        }
    }
}
