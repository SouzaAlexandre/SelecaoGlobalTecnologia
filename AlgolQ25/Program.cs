using System;

namespace AlgolQ25
{
    class Program
    {
        static void Main(string[] args)
        {
            int DivisorMaximo = 20;
            Console.WriteLine("O valor para "+ Convert.ToString(DivisorMaximo) 
                              +" é " + Convert.ToString(Matematicas.RetornaMenorDivisivel(DivisorMaximo)));
        }
    }
}
