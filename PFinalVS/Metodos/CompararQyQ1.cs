using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class CompararQyQ1
    {
        public static bool comprar (string multiplicando, string q1) // COMPARA Q CON Q1 PARA SABER SI SE RESTARA, SUMARA O NADA
        {
            char[] multi;
            multi = multiplicando.ToCharArray();
            char[] qu;
            qu = q1.ToCharArray();

            if (multi[multi.Length - 1] == qu[0])
            {
                return true;
            }
            else return false;
        }
    }
}
