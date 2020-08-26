using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class ResuDecimal
    {
        static public int Deci (string resultado)
        {
            List<string> acum = resultado.Select(c => c.ToString()).ToList();

            if (acum[0] == "0")
            {
                return (int)((Math.Pow(2, 6) * int.Parse(acum[1])) + (Math.Pow(2, 5) * int.Parse(acum[2]))
                    + (Math.Pow(2, 4) * int.Parse(acum[3])) + (Math.Pow(2, 3) * int.Parse(acum[4]))
                    + (Math.Pow(2, 2) * int.Parse(acum[5]))
                    + (2 * int.Parse(acum[6]) + (1 * int.Parse(acum[7]))));
            }
            else if (acum[0] == "1")
            {
                acum[0] = "0";
                if (acum[1] == "1") { acum[1] = "0"; }
                else {acum[1] = "1"; }
                if (acum[2] == "1") { acum[2] = "0"; }
                else { acum[2] = "1"; }
                if (acum[3] == "1") { acum[3] = "0"; }
                else { acum[3] = "1"; }
                if (acum[4] == "1") { acum[4] = "0"; }
                else { acum[4] = "1"; }
                if (acum[5] == "1") { acum[5] = "0"; }
                else { acum[5] = "1"; }
                if (acum[6] == "1") { acum[6] = "0"; }
                else { acum[6] = "1"; }
                if (acum[7] == "1") { acum[7] = "0"; }
                else { acum[7] = "1"; }

                int neg = (int)((Math.Pow(2, 6) * int.Parse(acum[1])) + (Math.Pow(2, 5) * int.Parse(acum[2]))
                    + (Math.Pow(2, 4) * int.Parse(acum[3])) + (Math.Pow(2, 3) * int.Parse(acum[4]))
                    + (Math.Pow(2, 2) * int.Parse(acum[5]))
                    + (2 * int.Parse(acum[6]) + (1 * int.Parse(acum[7]))) + 1);
                return neg * (-1);
             
            }
            return 0;
        }
    }
}
