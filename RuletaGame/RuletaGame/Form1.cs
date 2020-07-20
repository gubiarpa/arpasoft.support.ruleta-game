using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuletaGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            // Limpiamos los resultados
            lblPuntajeJug1.Text = "0";
            lblPuntajeJug2.Text = "0";
            lblResultado.Text = "";

            // Habilita / Inhabilita los botones
            btnEjecutarJug1.Enabled = true; // Habilitado
            btnEjecutarJug2.Enabled = false; // Inhabilitado
        }

        private void btnEjecutarJug1_Click(object sender, EventArgs e)
        {
            // Inhabilitamos el botón del Jugador 1 y Borrar
            btnEjecutarJug1.Enabled = false;
            btnBorrar.Enabled = false;

            // Recorremos la ruleta
            Random random = new Random();
            int i = random.Next(1, 17); // Obtiene un número entre 1 y 16
            int totalVeces = 50; // Recorro 50 cuadraditos
            string resultado = "";            

            for (int vez = 0; vez < totalVeces; vez++)
            {
                if (i ==  1) { lblCasilla01.BackColor = Color.Aqua; resultado = lblCasilla01.Text; } else { lblCasilla01.BackColor = Color.Transparent; }
                if (i ==  2) { lblCasilla02.BackColor = Color.Aqua; resultado = lblCasilla02.Text; } else { lblCasilla02.BackColor = Color.Transparent; }
                if (i ==  3) { lblCasilla03.BackColor = Color.Aqua; resultado = lblCasilla03.Text; } else { lblCasilla03.BackColor = Color.Transparent; }
                if (i ==  4) { lblCasilla04.BackColor = Color.Aqua; resultado = lblCasilla04.Text; } else { lblCasilla04.BackColor = Color.Transparent; }
                if (i ==  5) { lblCasilla05.BackColor = Color.Aqua; resultado = lblCasilla05.Text; } else { lblCasilla05.BackColor = Color.Transparent; }
                if (i ==  6) { lblCasilla06.BackColor = Color.Aqua; resultado = lblCasilla06.Text; } else { lblCasilla06.BackColor = Color.Transparent; }
                if (i ==  7) { lblCasilla07.BackColor = Color.Aqua; resultado = lblCasilla07.Text; } else { lblCasilla07.BackColor = Color.Transparent; }
                if (i ==  8) { lblCasilla08.BackColor = Color.Aqua; resultado = lblCasilla08.Text; } else { lblCasilla08.BackColor = Color.Transparent; }
                if (i ==  9) { lblCasilla09.BackColor = Color.Aqua; resultado = lblCasilla09.Text; } else { lblCasilla09.BackColor = Color.Transparent; }
                if (i == 10) { lblCasilla10.BackColor = Color.Aqua; resultado = lblCasilla10.Text; } else { lblCasilla10.BackColor = Color.Transparent; }
                if (i == 11) { lblCasilla11.BackColor = Color.Aqua; resultado = lblCasilla11.Text; } else { lblCasilla11.BackColor = Color.Transparent; }
                if (i == 12) { lblCasilla12.BackColor = Color.Aqua; resultado = lblCasilla12.Text; } else { lblCasilla12.BackColor = Color.Transparent; }
                if (i == 13) { lblCasilla13.BackColor = Color.Aqua; resultado = lblCasilla13.Text; } else { lblCasilla13.BackColor = Color.Transparent; }
                if (i == 14) { lblCasilla14.BackColor = Color.Aqua; resultado = lblCasilla14.Text; } else { lblCasilla14.BackColor = Color.Transparent; }
                if (i == 15) { lblCasilla15.BackColor = Color.Aqua; resultado = lblCasilla15.Text; } else { lblCasilla15.BackColor = Color.Transparent; }
                if (i == 16) { lblCasilla16.BackColor = Color.Aqua; resultado = lblCasilla16.Text; } else { lblCasilla16.BackColor = Color.Transparent; }

                if (i < 16) { i++; } else { i = 1; }
                this.Refresh(); // Refresca la pantalla
            }

            // Imprimimos el resultado
            lblPuntajeJug1.Text = resultado;

            // Inhabilitamos el botóon del Jugador 2
            btnEjecutarJug2.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnEjecutarJug2_Click(object sender, EventArgs e)
        {
            // Inhabilitamos el botón del Jugador 2 y Borrar
            btnEjecutarJug2.Enabled = false;
            btnBorrar.Enabled = false;

            // Recorremos la ruleta
            Random random = new Random();
            int i = random.Next(1, 17); // Obtiene un número entre 1 y 16
            int totalVeces = 50; // Recorro 50 cuadraditos
            string resultado = "";

            for (int vez = 0; vez < totalVeces; vez++)
            {
                if (i == 1) { lblCasilla01.BackColor = Color.Magenta; resultado = lblCasilla01.Text; } else { lblCasilla01.BackColor = Color.Transparent; }
                if (i == 2) { lblCasilla02.BackColor = Color.Magenta; resultado = lblCasilla02.Text; } else { lblCasilla02.BackColor = Color.Transparent; }
                if (i == 3) { lblCasilla03.BackColor = Color.Magenta; resultado = lblCasilla03.Text; } else { lblCasilla03.BackColor = Color.Transparent; }
                if (i == 4) { lblCasilla04.BackColor = Color.Magenta; resultado = lblCasilla04.Text; } else { lblCasilla04.BackColor = Color.Transparent; }
                if (i == 5) { lblCasilla05.BackColor = Color.Magenta; resultado = lblCasilla05.Text; } else { lblCasilla05.BackColor = Color.Transparent; }
                if (i == 6) { lblCasilla06.BackColor = Color.Magenta; resultado = lblCasilla06.Text; } else { lblCasilla06.BackColor = Color.Transparent; }
                if (i == 7) { lblCasilla07.BackColor = Color.Magenta; resultado = lblCasilla07.Text; } else { lblCasilla07.BackColor = Color.Transparent; }
                if (i == 8) { lblCasilla08.BackColor = Color.Magenta; resultado = lblCasilla08.Text; } else { lblCasilla08.BackColor = Color.Transparent; }
                if (i == 9) { lblCasilla09.BackColor = Color.Magenta; resultado = lblCasilla09.Text; } else { lblCasilla09.BackColor = Color.Transparent; }
                if (i == 10) { lblCasilla10.BackColor = Color.Magenta; resultado = lblCasilla10.Text; } else { lblCasilla10.BackColor = Color.Transparent; }
                if (i == 11) { lblCasilla11.BackColor = Color.Magenta; resultado = lblCasilla11.Text; } else { lblCasilla11.BackColor = Color.Transparent; }
                if (i == 12) { lblCasilla12.BackColor = Color.Magenta; resultado = lblCasilla12.Text; } else { lblCasilla12.BackColor = Color.Transparent; }
                if (i == 13) { lblCasilla13.BackColor = Color.Magenta; resultado = lblCasilla13.Text; } else { lblCasilla13.BackColor = Color.Transparent; }
                if (i == 14) { lblCasilla14.BackColor = Color.Magenta; resultado = lblCasilla14.Text; } else { lblCasilla14.BackColor = Color.Transparent; }
                if (i == 15) { lblCasilla15.BackColor = Color.Magenta; resultado = lblCasilla15.Text; } else { lblCasilla15.BackColor = Color.Transparent; }
                if (i == 16) { lblCasilla16.BackColor = Color.Magenta; resultado = lblCasilla16.Text; } else { lblCasilla16.BackColor = Color.Transparent; }

                if (i < 16) { i++; } else { i = 1; }
                this.Refresh(); // Refresca la pantalla
            }

            // Imprimimos el resultado
            lblPuntajeJug2.Text = resultado;

            // Mostrar ganador
            int puntaje1, puntaje2;
            puntaje1 = int.Parse(lblPuntajeJug1.Text);
            puntaje2 = int.Parse(lblPuntajeJug2.Text);

            if (puntaje1 > puntaje2)
            {
                lblResultado.Text = "¡El ganador es el Jugador 1!";
            }
            else if (puntaje1 < puntaje2)
            {
                lblResultado.Text = "¡El ganador es el Jugador 2!";
            }
            else
            {
                lblResultado.Text = "¡Empate!";
            }

            // Inhabilitamos el botóon del Jugador 2
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Cargamos los valores aleatorios
            int minValorPremio = 10, maxValorPremio = 100;
            Random random = new Random();
            lblCasilla01.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla01.BackColor = Color.Transparent;
            lblCasilla02.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla02.BackColor = Color.Transparent;
            lblCasilla03.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla03.BackColor = Color.Transparent;
            lblCasilla04.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla04.BackColor = Color.Transparent;
            lblCasilla05.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla05.BackColor = Color.Transparent;
            lblCasilla06.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla06.BackColor = Color.Transparent;
            lblCasilla07.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla07.BackColor = Color.Transparent;
            lblCasilla08.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla08.BackColor = Color.Transparent;
            lblCasilla09.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla09.BackColor = Color.Transparent;
            lblCasilla10.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla10.BackColor = Color.Transparent;
            lblCasilla11.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla11.BackColor = Color.Transparent;
            lblCasilla12.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla12.BackColor = Color.Transparent;
            lblCasilla13.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla13.BackColor = Color.Transparent;
            lblCasilla14.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla14.BackColor = Color.Transparent;
            lblCasilla15.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla15.BackColor = Color.Transparent;
            lblCasilla16.Text = random.Next(minValorPremio, maxValorPremio).ToString(); lblCasilla16.BackColor = Color.Transparent;

            // Limpiamos los resultados
            lblPuntajeJug1.Text = "0";
            lblPuntajeJug2.Text = "0";
            lblResultado.Text = "";

            // Habilita / Inhabilita los botones
            btnEjecutarJug1.Enabled = true; // Habilitado
            btnEjecutarJug2.Enabled = false; // Inhabilitado
        }
    }
}
