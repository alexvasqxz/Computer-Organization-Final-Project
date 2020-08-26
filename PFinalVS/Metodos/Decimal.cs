using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class Decimal 
    {
        static public int dec(string a ) //CONVIERTE LOS VALORES DEL ACUMULADOR A DECIMAL PARA PODER REALIZAR LAS OPERACIONES EN AMASM
        {
            List<string> acum = a.Select(c => c.ToString()).ToList();
            if (acum[0] == "0")
            {
                return  (int)((Math.Pow(2, 2) * int.Parse(acum[1])) + (2 * int.Parse(acum[2]) + (1 * int.Parse(acum[3]))));
            }
            else if (acum [0] == "1")
            {
                acum[0] = "0";
                if (acum[1] == "0") { acum[1] = "1"; }
                else { acum[1] = "0"; }
                if (acum[2] == "0") { acum[2] = "1"; }
                else { acum[2] = "0"; }
                if (acum[3] == "0") { acum[3] = "1"; }
                else { acum[3] = "0"; }

                int resultado = (int)(Math.Pow(2, 2) * int.Parse(acum[1]) + (2 * int.Parse(acum[2])) + (1 * int.Parse(acum[3])) + 1);
                return resultado * (-1);

            }
            return 111;
           
        }
    }
}
