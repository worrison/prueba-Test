/*Nuestra empresa nos piden crear una librería matemática que incluya las siguientes utilidades:
1º Una función que nos determine si es un número Par o no, siempre en número positivos y en el rango de Enteros.
Para ello utilizaremos la función matemática del módulo el cual nos índica el resto de una división, 
ejemplo: 4 % 2 = 0 En el caso de que el resto es 0 se tratará de un número par, 
en caso de que sea a distinto a 0 nos indicará que se trata de un número impar.

2º Una función que nos determine si el número es Primo o No siempre en número positivos y en el rango de Enteros.
Para ello iremos calculando el resto de los números anteriores e iremos sumando en un contador las veces que es 0 
si el resultado del contador = 2 no es primo en caso contrario no.

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace calculadora
{
    public class matematicas
    {
        public static int sumar(int a, int b)
        {
            return a + b;
        }
        public static bool esPar(int n)
        {
            return n > 0 && n % 2 == 0;
           
        }
        public static bool esPrimo(int n)
        {
            int i, suma = 0; ;
            if(n>0)
            {
                for(i=n; i>0; i--)
                {
                    if(i%2==0)
                    {
                        suma++;
                    }
                }
            }
            return suma!=2;//true -> primo ,false no primo
        }
    }
}
