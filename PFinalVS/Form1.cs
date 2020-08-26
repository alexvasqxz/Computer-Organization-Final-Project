using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PFinalVS.Metodos;

namespace PFinalVS //FP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label3.Font = new Font(label3.Font, FontStyle.Italic);
            label4.Font = new Font(label4.Font, FontStyle.Italic);
            label5.Font = new Font(label5.Font, FontStyle.Italic);
            label6.Font = new Font(label6.Font, FontStyle.Italic);
            label7.Font = new Font(label7.Font, FontStyle.Italic);
            lblRes.Font = new Font(lblRes.Font, FontStyle.Bold);
            bttnPaP.Font = new Font(bttnPaP.Font, FontStyle.Underline);
            button1.Font = new Font(button1.Font, FontStyle.Underline);
            bttnCiclo1.Font = new Font(bttnCiclo1.Font, FontStyle.Italic);
            bttnCiclo2.Font = new Font(bttnCiclo2.Font, FontStyle.Italic);
            bttnCiclo3.Font = new Font(bttnCiclo3.Font, FontStyle.Italic);
            bttnCiclo4.Font = new Font(bttnCiclo4.Font, FontStyle.Italic);
            txtBoxAP44.Font = new Font(txtBoxAP44.Font, FontStyle.Bold);
            txtBoxQP44.Font = new Font(txtBoxQP44.Font, FontStyle.Bold);
;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bttnReset.Visible = false;
        }

        private void ocultarsinpasos ()
        {
            bttnPaP.Visible = false;
            bttnCiclo1.Visible = false;
            bttnCiclo2.Visible = false;
            bttnCiclo3.Visible = false;
            bttnCiclo4.Visible = false;
            button1.Visible = false;
        }

        private void reset ()
        {
            bttnPaP.Visible = true;
            bttnCiclo1.Visible = true;
            bttnCiclo2.Visible = true;
            bttnCiclo3.Visible = true;
            bttnCiclo4.Visible = true;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ocultarsinpasos();
                bttnReset.Visible = true;

                if (int.Parse(txtboxmultiplicadord.Text) > 7 || int.Parse(txtboxmultiplicadord.Text) < -7) // VERIFICA QUE EL NUMERO ESTE EN EL RANGO
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (int.Parse(txtboxmultiplicandod.Text) > 7 || int.Parse(txtboxmultiplicandod.Text) < -7)
                {
                    throw new ArgumentOutOfRangeException();
                }

                    Paso0.ini(txtboxmultiplicadord, txtboxmultiplicandod, txtboxmultiplicadorbi, txtboxmultiplicandobi, txtboxQ1, txtboxA, txtBoxProc0); // INICIALIZADOR

                txtBoxMP1.Text = txtboxmultiplicadorbi.Text;                                            // CICLO 1
                if (CompararQyQ1.comprar(txtboxmultiplicandobi.Text, txtboxQ1.Text) == true)
                {
                    Paso.verd(txtboxA, txtBoxAP1, txtBoxAP11, txtboxmultiplicandobi, txtBoxQP1, txtBoxQP11, txtboxQ1, txtBoxQ1P1, txtBoxQ1P11, txtBoxProc1);
                }
                else
                {
                    Paso.men(txtboxA, txtBoxAP1, txtBoxAP11, txtboxmultiplicandobi, txtBoxQP1, txtBoxQP11, txtboxQ1, txtBoxQ1P1, txtBoxQ1P11,  txtboxmultiplicadord, txtBoxProc1);
                }

                txtBoxMP2.Text = txtboxmultiplicadorbi.Text;                                                // CICLO 2
                if (CompararQyQ1.comprar(txtBoxQP11.Text, txtBoxQ1P11.Text) == true)
                {
                    Paso.verd(txtBoxAP11, txtBoxAP2, txtBoxAP22, txtBoxQP11, txtBoxQP2, txtBoxQP22, txtBoxQ1P11, txtBoxQ1P2, txtBoxQ1P22, txtBoxProc2);
                } 
                else
                {
                    Paso.men(txtBoxAP11, txtBoxAP2, txtBoxAP22, txtBoxQP11, txtBoxQP2, txtBoxQP22, txtBoxQ1P11, txtBoxQ1P2, txtBoxQ1P22, txtboxmultiplicadord, txtBoxProc2);
                }

                txtBoxMP3.Text = txtboxmultiplicadorbi.Text;                                         // CICLO 3
                if (CompararQyQ1.comprar(txtBoxQP22.Text, txtBoxQ1P22.Text) == true)
                {
                    Paso.verd(txtBoxAP22, txtBoxAP3, txtBoxAP33, txtBoxQP22, txtBoxQP3, txtBoxQP33, txtBoxQ1P22, txtBoxQ1P3, txtBoxQ1P33, txtBoxProc3);
                }
                else
                {
                    Paso.men(txtBoxAP22, txtBoxAP3, txtBoxAP33, txtBoxQP22, txtBoxQP3, txtBoxQP33, txtBoxQ1P22, txtBoxQ1P3, txtBoxQ1P33, txtboxmultiplicadord, txtBoxProc3);
                }

                txtBoxMP4.Text = txtboxmultiplicadorbi.Text;                                         // CICLO 4
                if (CompararQyQ1.comprar(txtBoxQP33.Text, txtBoxQ1P33.Text) == true)
                {
                    Paso.verd(txtBoxAP33, txtBoxAP4, txtBoxAP44, txtBoxQP33, txtBoxQP4, txtBoxQP44, txtBoxQ1P33, txtBoxQ1P4, txtBoxQ1P44, txtBoxProc4);
                }
                else
                {
                    Paso.men(txtBoxAP33, txtBoxAP4, txtBoxAP44, txtBoxQP33, txtBoxQP4, txtBoxQP44, txtBoxQ1P33, txtBoxQ1P4, txtBoxQ1P44, txtboxmultiplicadord, txtBoxProc4);
                }
                if (txtBoxQP44.Text != null)
                {
                    string resu = txtBoxAP44.Text + txtBoxQP44.Text;
                    txtBoxResultado.Text = resu + " " + "=" + " " + Metodos.ResuDecimal.Deci(resu);
                }
            }


            catch (FormatException) // SOLO SE PERMITEN NUMEROS
            {
                MessageBox.Show("Por favor ingresa un numero", "Error");
            }
            catch (ArgumentOutOfRangeException) // FUERA DE RANGO
            {
                MessageBox.Show("Ingresa un numero entre el rango de -7 a 7", "Numero invalido");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtboxmultiplicadord_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxmultiplicandod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxmultiplicadorbi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxmultiplicandobi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxQ1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtboxAmenos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxAmas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxcomparar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxacumrecorr1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxacumrecorr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxRecorridoQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxQP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            bttnCiclo3.Visible = false;
            txtBoxMP3.Text = txtboxmultiplicadorbi.Text;                                         // CICLO 3
            if (CompararQyQ1.comprar(txtBoxQP22.Text, txtBoxQ1P22.Text) == true)
            {
                Paso.verd(txtBoxAP22, txtBoxAP3, txtBoxAP33, txtBoxQP22, txtBoxQP3, txtBoxQP33, txtBoxQ1P22, txtBoxQ1P3, txtBoxQ1P33, txtBoxProc3);
            }
            else
            {
                Paso.men(txtBoxAP22, txtBoxAP3, txtBoxAP33, txtBoxQP22, txtBoxQP3, txtBoxQP33, txtBoxQ1P22, txtBoxQ1P3, txtBoxQ1P33, txtboxmultiplicadord, txtBoxProc3);
            }
            bttnCiclo4.Visible = true;
        }

        private void BttnReset_Click(object sender, EventArgs e)
        {
            Vaciar.empty(txtboxmultiplicadorbi, txtboxmultiplicadord, txtboxmultiplicandobi, txtboxmultiplicandod, txtboxA, txtBoxAP1, txtBoxAP11, txtBoxAP2, 
                txtBoxAP22, txtBoxAP3, txtBoxAP33, txtBoxAP4,txtBoxAP44, txtBoxQP1, txtBoxQP11, txtBoxQP2, txtBoxQP22,txtBoxQP3, txtBoxQP33, txtBoxQP4, txtBoxQP44,
                txtboxQ1, txtBoxQ1P1, txtBoxQ1P11, txtBoxQ1P2, txtBoxQ1P22, txtBoxQ1P3,txtBoxQ1P33, txtBoxQ1P4, txtBoxQ1P44, txtBoxMP1, txtBoxMP2, txtBoxMP3, 
                txtBoxMP4, txtBoxProc0, txtBoxProc1, txtBoxProc2, txtBoxProc3, txtBoxProc4, txtBoxResultado);

            if (txtBoxProc1.Text != "Sin operacion")
            {
                txtBoxQ1P1.BackColor = Color.White;
                txtBoxQP1.BackColor = Color.White;
            }
            if (txtBoxProc2.Text != "Sin operacion")
            {
                txtBoxQP2.BackColor = Color.White;
                txtBoxQ1P2.BackColor = Color.White;
            }
            if (txtBoxProc3.Text != "Sin operacion")
            {
                txtBoxQP3.BackColor = Color.White;
                txtBoxQ1P3.BackColor = Color.White;
            }
            if (txtBoxProc4.Text != "Sin operacion")
            {
                txtBoxQP4.BackColor = Color.White;
                txtBoxQ1P4.BackColor = Color.White;
            }
            reset();
        }

        private void BttnPaP_Click(object sender, EventArgs e)
        {
            try
            {
                ocultarsinpasos();
                bttnCiclo1.Visible = true;
                bttnReset.Visible = true;

                if (int.Parse(txtboxmultiplicadord.Text) > 7 || int.Parse(txtboxmultiplicadord.Text) < -7) // VERIFICA QUE EL NUMERO ESTE EN EL RANGO
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (int.Parse(txtboxmultiplicandod.Text) > 7 || int.Parse(txtboxmultiplicandod.Text) < -7)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Paso0.ini(txtboxmultiplicadord, txtboxmultiplicandod, txtboxmultiplicadorbi, txtboxmultiplicandobi, txtboxQ1, txtboxA, txtBoxProc0); // INICIALIZADOR
            }
            catch (FormatException) // SOLO SE PERMITEN NUMEROS
            {
                MessageBox.Show("Por favor ingresa un numero", "Error");
            }
            catch (ArgumentOutOfRangeException) // FUERA DE RANGO
            {
                MessageBox.Show("Ingresa un numero entre el rango de -7 a 7", "Numero invalido");
            }
        }

        private void BttnCiclo1_Click(object sender, EventArgs e)
        {
            bttnCiclo1.Visible = false;
            txtBoxMP1.Text = txtboxmultiplicadorbi.Text;                                            // CICLO 1
            if (CompararQyQ1.comprar(txtboxmultiplicandobi.Text, txtboxQ1.Text) == true)
            {
                Paso.verd(txtboxA, txtBoxAP1, txtBoxAP11, txtboxmultiplicandobi, txtBoxQP1, txtBoxQP11, txtboxQ1, txtBoxQ1P1, txtBoxQ1P11, txtBoxProc1);
            }
            else
            {
                Paso.men(txtboxA, txtBoxAP1, txtBoxAP11, txtboxmultiplicandobi, txtBoxQP1, txtBoxQP11, txtboxQ1, txtBoxQ1P1, txtBoxQ1P11, txtboxmultiplicadord, txtBoxProc1);
            }
            bttnCiclo2.Visible = true;
        }

        private void BttnCiclo2_Click(object sender, EventArgs e)
        {
            bttnCiclo2.Visible = false;
            txtBoxMP2.Text = txtboxmultiplicadorbi.Text;                                                // CICLO 2
            if (CompararQyQ1.comprar(txtBoxQP11.Text, txtBoxQ1P11.Text) == true)
            {
                Paso.verd(txtBoxAP11, txtBoxAP2, txtBoxAP22, txtBoxQP11, txtBoxQP2, txtBoxQP22, txtBoxQ1P11, txtBoxQ1P2, txtBoxQ1P22, txtBoxProc2);
            }
            else
            {
                Paso.men(txtBoxAP11, txtBoxAP2, txtBoxAP22, txtBoxQP11, txtBoxQP2, txtBoxQP22, txtBoxQ1P11, txtBoxQ1P2, txtBoxQ1P22, txtboxmultiplicadord, txtBoxProc2);
            }
            bttnCiclo3.Visible = true;
        }

        private void BttnCiclo4_Click(object sender, EventArgs e)
        {
            bttnCiclo4.Visible = false;
            txtBoxMP4.Text = txtboxmultiplicadorbi.Text;                                         // CICLO 4
            if (CompararQyQ1.comprar(txtBoxQP33.Text, txtBoxQ1P33.Text) == true)
            {
                Paso.verd(txtBoxAP33, txtBoxAP4, txtBoxAP44, txtBoxQP33, txtBoxQP4, txtBoxQP44, txtBoxQ1P33, txtBoxQ1P4, txtBoxQ1P44, txtBoxProc4);
            }
            else
            {
                Paso.men(txtBoxAP33, txtBoxAP4, txtBoxAP44, txtBoxQP33, txtBoxQP4, txtBoxQP44, txtBoxQ1P33, txtBoxQ1P4, txtBoxQ1P44, txtboxmultiplicadord, txtBoxProc4);
            }
            if (txtBoxQP44.Text != null)
            {
                string resu = txtBoxAP44.Text + txtBoxQP44.Text;
                txtBoxResultado.Text = resu + " " + "=" + " " + Metodos.ResuDecimal.Deci(resu);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
