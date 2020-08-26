using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinalVS.Metodos
{
    class RecorrerQ
    {
        public static string recorridoQ (string multiplicandoprevio, string acumulador) // AQUI SE RECORRE Q DESPUES DE CADA CICLO
        {
            List<string> acumuladoronuevo = acumulador.Select(c => c.ToString()).ToList();
            List<string> multiplicandonuevo = multiplicandoprevio.Select(c => c.ToString()).ToList();

            if (acumuladoronuevo[acumuladoronuevo.Count - 1] == "0")
            {
                multiplicandonuevo.Insert(0, "0");
            }
            else if (acumuladoronuevo[acumuladoronuevo.Count - 1] == "1")
            {
                multiplicandonuevo.Insert(0, "1");
            }

            multiplicandonuevo.RemoveAt(multiplicandonuevo.Count - 1);
            string resultado = string.Join("", multiplicandonuevo);
            return resultado;

        }
        // se recorrera Q
        // requiere del string Acumulador y Multiplicando
    }
}
