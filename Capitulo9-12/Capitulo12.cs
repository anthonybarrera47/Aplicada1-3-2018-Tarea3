using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo9_12
{
    public class Capitulo12
    {
        public Capitulo12()
        {

        }
        public static int Ejercicio1(int n)//Usar la depuración paso a paso para observar cómo cambia el valor de la variable en el programa del factorial.
        {
            return n = (n<2) ? n: n*Ejercicio1(n-1);
        } 

        public static void Ejercicio2()
        {

        }
        public static void Ejercicio3()
        {
            //Cuando dentro de un arreglo intentamos acceder a una posición fuera del rango de este obtendremos una del tipo: IndexOutOfRangeException
        }
        public static void Ejercicio()
        {

        }
    }
}
