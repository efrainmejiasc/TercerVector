using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerVector
{
    public partial class Form1 : Form
    {
        private int contRojo = 0;
        private int contNegro = 0;
        private int contEntrada = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => pronostico.Text = "Esperando Pronostico";

        private void AddNumber_Click(object sender, EventArgs e)
        {
            ListBox contenedor = new ListBox();
            if (txtResultado.Text == string.Empty)
                return;
            int  numero = Convert.ToInt32(txtResultado.Text);
            if (EngineData.Negro.Contains(numero))
            {
                contNegro++;
            }   
            else if (EngineData.Rojo.Contains(numero))
            {
                contRojo++;
            }
            contEntrada++;
            contenedor.Items.Add(numero);
            if (contEntrada > 5)
            {
                foreach(int n in contenedor.Items)
                {
                    if (EngineData.Negro.Contains(numero))
                    {

                    }
                    else if (EngineData.Rojo.Contains(numero))
                    {

                    }
                }

            }
            txtResultado.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkNegro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkRojo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void EliminarResultado_Click(object sender, EventArgs e)
        {

        }

        private void GuardarRuta_Click(object sender, EventArgs e)
        {

        }

        private void NuevoCiclo_Click(object sender, EventArgs e)
        {
            NuevoLoop();
        }

        private void NuevoLoop()
        {

        }

        //*********** Eventos ************************************************************
        private void txtResultado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            pronostico.BackColor = Color.SeaGreen;
        }

        private void txtResultado_Leave(object sender, EventArgs e)
        {
            if (txtResultado.Text != string.Empty)
            {
                int resultado = Convert.ToInt32(txtResultado.Text);
                if (resultado <= 0 || resultado > 36)
                {
                    txtResultado.Text = string.Empty;
                }
            }
        }
    }
}
