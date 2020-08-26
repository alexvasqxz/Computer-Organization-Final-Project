using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class DiferenteQyQ1
    {
        public static bool sumaoresta (string multiplicando, string q1) //COMPARA EL VALOR 0 Y 1 O VICEVERSA DE Q Y Q1 PARA SABER SI SE REALIZA SUMA O RESTA
        {
            char[] multi;
            multi = multiplicando.ToCharArray();
            char[] qu;
            qu = q1.ToArray();

            if (multi[multi.Length - 1] > qu[0])
            {
                return true;
            }
            else
                return false;
        }
    }
}
