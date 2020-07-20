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

        private void btnEjecutarJug1_Click(object sender, EventArgs e)
        {
            int i = 1, veces = 10;
            while (veces < 160)
            {
                lblCasilla01.BackColor = i == 1 ? Color.Aqua : Color.Transparent;
                lblCasilla02.BackColor = i == 2 ? Color.Aqua : Color.Transparent;
                lblCasilla03.BackColor = i == 3 ? Color.Aqua : Color.Transparent;
                lblCasilla04.BackColor = i == 4 ? Color.Aqua : Color.Transparent;
                lblCasilla05.BackColor = i == 5 ? Color.Aqua : Color.Transparent;
                lblCasilla06.BackColor = i == 6 ? Color.Aqua : Color.Transparent;
                lblCasilla07.BackColor = i == 7 ? Color.Aqua : Color.Transparent;
                lblCasilla08.BackColor = i == 8 ? Color.Aqua : Color.Transparent;
                lblCasilla09.BackColor = i == 9 ? Color.Aqua : Color.Transparent;
                lblCasilla10.BackColor = i == 10 ? Color.Aqua : Color.Transparent;
                lblCasilla11.BackColor = i == 11 ? Color.Aqua : Color.Transparent;
                lblCasilla12.BackColor = i == 12 ? Color.Aqua : Color.Transparent;
                lblCasilla13.BackColor = i == 13 ? Color.Aqua : Color.Transparent;
                lblCasilla14.BackColor = i == 14 ? Color.Aqua : Color.Transparent;
                lblCasilla15.BackColor = i == 15 ? Color.Aqua : Color.Transparent;
                lblCasilla16.BackColor = i == 16 ? Color.Aqua : Color.Transparent;
                Thread.Sleep(50);
                if (i < 16)
                {
                    i++;
                }
                else
                {
                    i = 1;
                }
                veces++;
                this.Refresh();
            }
        }
    }
}
