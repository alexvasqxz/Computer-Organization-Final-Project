using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class AmenosM
    {
        public static int unocero(string acumulador, string multiplicador) // RESTA ACUMULADOR Y MULTIPLICADOR CUANDO SE TENGA 1 Y 0
        {
            return int.Parse(acumulador) - int.Parse(multiplicador);
        }

    }
}
