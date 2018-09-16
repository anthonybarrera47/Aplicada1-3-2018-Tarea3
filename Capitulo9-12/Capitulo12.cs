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
        public static int Ejercicio1(int n)
        {
            return n = (n<2) ? n: n*Ejercicio1(n-1);
        } 
    }
}
