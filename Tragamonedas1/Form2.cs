using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // CUANDO EL SCORE LLEGA A CERO MUESTRA GAME OVER Y SE SALE DE LA APP.  
//APLICATION.EXTI

namespace Tragamonedas1
{
    public partial class Form2 : Form
    {
        int puntaje, num1, num2, num3; 

        public Form2()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtcredito.Text) > 0)
            {
                lblcredito.Enabled = false;
                txtcredito.Enabled = false;
                btnentrar.Enabled = false;
                pbximagen1.Visible = true;
                pbximagen2.Visible = true;
                pbximagen3.Visible = true;
                lblscore.Visible = true;
                lblscore.Text = "SCORE: " + lblcredito.Text;
                btnplay.Visible = true;
                puntaje = int.Parse(txtcredito.Text); 

            }

            else
            {
                MessageBox.Show("DEBE INGRESAR DATOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }



        }

        public void generarnumeros()
        {
            Random aleatorio = new Random();
            num1 = aleatorio.Next(1,11);
            num2 = aleatorio.Next(1,11);
            num3 = aleatorio.Next(1,11);
        }

        public void asigna_imagen()
        {
            pbximagen1.Image = Image.FromFile(@"C:\Users\Mario\OneDrive\Escritorio\Estrella\" + num1 + ".WEBP");
            pbximagen2.Image = Image.FromFile(@"C:\Users\Mario\OneDrive\Escritorio\hongo\" + num2 + ".WEBP");
            pbximagen3.Image = Image.FromFile(@"C:\Users\Mario\OneDrive\Escritorio\goomba\" + num3 + ".WEBP");

        }

        public string puntajeobtenido()
        {
            string resultado;

            if (num1 == num2 && num1 == num3)
            {
                puntaje += 10;
                MessageBox.Show("GANASTE 10 PUNTOS", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resultado = "SCORE: " + puntaje.ToString();
            }

            else
            {
                puntaje -= 2;
                resultado = "SCORE :" + puntaje.ToString();
            }

            return resultado;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            generarnumeros();
            asigna_imagen();
            lblscore.Text = puntajeobtenido(); 
        }
    }
}
