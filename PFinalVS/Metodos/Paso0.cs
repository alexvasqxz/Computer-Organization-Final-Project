using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFinalVS.Metodos
{
    class Paso0
    {
        public static void ini (TextBox MD, TextBox QD, TextBox M1, TextBox Q,  TextBox Q1, TextBox Ac, TextBox P ) // VALORES INICIALES DE A, Q Y Q1
            {
            
            M1.Text = Binario.Convertor(int.Parse(MD.Text)); // M
            

            Q.Text = Binario.Convertor(int.Parse(QD.Text)); // Q
            

            Ac.Text = "0000"; // A
         

            Q1.Text = "0"; // Q1

            P.Text = "Valores Iniciales";
            
        }

    }
}
