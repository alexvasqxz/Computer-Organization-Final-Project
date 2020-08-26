using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PFinalVS.Metodos
{
    class Paso // AQUI SE REALIZA TODO EL PROCEDIMIENTO REPETIDO
    {
        // SI Q Y Q1 SON IGUALES NO SE REALIZARA NINGUNA OPERACION
        // POR LO QUE SE ASIGNAN LOS MISMOS VALORES QUE EL CICLO ANTERIOR Y SE REALIZA EL RECORRIMIENTO DE A, Q Y Q1
        public static void verd(TextBox An, TextBox A, TextBox A1, TextBox Qan, TextBox Q, TextBox Q1, TextBox quan, TextBox qu, TextBox qu1, TextBox P)
        {
            A.Text = An.Text;
            Q.Text = Qan.Text;
            qu.Text = quan.Text;
            A1.Text = RecorrerA.recorrido(An.Text);
            Q1.Text = RecorrerQ.recorridoQ(Qan.Text, An.Text);
            qu1.Text = RecorrerQ1.recorridoq1(Qan.Text);
            P.Text = "Sin operacion";
            Q.BackColor = Color.White;
            qu.BackColor = Color.White;
        }

        // ESTO SUCEDE SI Q Y Q1 SON DIFERENTES
        // SE REALIZARA SUMA O RESTA DEPENDIENDO DE LA CLASE "DIFERENTEQYQ1", DESPUES DE ASIGNAN LOS VALORES Y SE RECORREN
        public static void men(TextBox An, TextBox A, TextBox A1, TextBox Qan, TextBox Q, TextBox Q1, TextBox quan, TextBox qu, TextBox qu1, TextBox M, TextBox P)
        {
            if (DiferenteQyQ1.sumaoresta(Qan.Text, quan.Text) == true) //RESTA 
            {
                A.Text = Binario.Convertor(AmenosM.unocero(Decimal.dec(An.Text).ToString(), M.Text));
                P.Text = "Resta";
                Q.BackColor = Color.Orange; 
                qu.BackColor = Color.Orange;
            }
            else if(DiferenteQyQ1.sumaoresta(Qan.Text, quan.Text) == false) // SUMA
            {
                A.Text = Binario.Convertor(AmasM.cerouno(Decimal.dec(An.Text).ToString(), M.Text));
                P.Text = "Suma";
                Q.BackColor = Color.LightGreen;
                qu.BackColor = Color.LightGreen;
            }
            Q.Text = Qan.Text;
            qu.Text = quan.Text;
            A1.Text = RecorrerA.recorrido(A.Text);
            Q1.Text = RecorrerQ.recorridoQ(Qan.Text, A.Text);
            qu1.Text = RecorrerQ1.recorridoq1(Qan.Text);
            
        }
    }
}
