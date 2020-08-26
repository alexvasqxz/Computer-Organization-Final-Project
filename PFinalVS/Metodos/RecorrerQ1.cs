using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class RecorrerQ1
    {
        public static string recorridoq1(string muliplicandoanterior) // SE RECORRE Q1 DESPUES DE CADA CICLO
        {
            List<string> multiplicador = muliplicandoanterior.Select(c => c.ToString()).ToList();

            if (multiplicador[multiplicador.Count - 1] == "0")
            {
                return "0";
            }
            if (multiplicador[multiplicador.Count - 1] == "1")
            {
                return "1";
            }

            return "error";
        }

    }
}
