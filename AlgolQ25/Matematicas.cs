using System;
using System.Collections.Generic;
using System.Text;

namespace AlgolQ25
{
    public static class Matematicas
    {
       public static int RetornaMenorDivisivel(int DivisorMaximo)
        {
            int valor = 0;
            bool ok = false;

            while (!ok)
            {
                valor++; 
                for (int i = 1; i <= DivisorMaximo; i++)
                {
                    if(valor % i != 0)
                    {
                        ok = false;
                        break;
                    } else
                    {
                        if(i == DivisorMaximo)
                        {
                            ok = true;
                        }
                    }

                }

            }



            return valor;
        }


    }
}
