using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class RecorrerA
    {
        public static string recorrido (string acumuladorprevio) //AQUI SE RECORRE EL VALOR DE A DESPUES DE CADA CICLO
        {
            List<string> acumuladornuevo = acumuladorprevio.Select(c => c.ToString()).ToList();


            if (acumuladornuevo[0] == "0")
            {
                acumuladornuevo.Insert(0, "0");
            }
            else if (acumuladornuevo[0] == "1")
            {
                acumuladornuevo.Insert(0, "1");
            }

            acumuladornuevo.RemoveAt(acumuladornuevo.Count - 1);
            string resultado = string.Join("", acumuladornuevo);
            return resultado;
           
        }
    }
}
