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
        ListBox contenedor = new ListBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) => pronostico.Text = "Esperando Pronostico";

        private void AddNumber_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)
                return;
            int  numero = Convert.ToInt32(txtResultado.Text);
            if (EngineData.Negro.Contains(numero))
                contNegro++; 
            else if (EngineData.Rojo.Contains(numero)) 
                contRojo++;
            
            contEntrada++;
            contenedor.Items.Add(numero);
    
            txtResultado.Text = string.Empty;
            txtResultado.Focus();
        }

        private string CambioColor (string color)
        {
            string colorInverso = string.Empty;
            switch (color)
            {
                case ("Negro"):
                    colorInverso = "Rojo";
                    break;
                case ("Rojo"):
                    colorInverso = "Negro";
                    break;
            }
            return colorInverso;
        }


        private void EliminarResultado_Click(object sender, EventArgs e)
        {
            if (contEntrada > 6)
            {
                int numeroItems = contenedor.Items.Count - 1;
                int posicionFinal = numeroItems;
                int posicionInicial = posicionFinal - numeroItems;
                string colorItem = string.Empty;

                //MessageBox.Show("Numero Items Ingresados " + numeroItems.ToString() + " Posicion Inicial " + posicionInicial.ToString() + " Posicion Final " + posicionFinal.ToString());

                richTextBox1.Text = " El ciclo ingresado es el siguiente : " + Environment.NewLine;
                for (int i = posicionInicial; i <= posicionFinal; i++)
                {
                    int nI = Convert.ToInt32(contenedor.Items[i]);

                    if (EngineData.Negro.Contains(nI))
                        colorItem = "Negro";
                    else if (EngineData.Rojo.Contains(nI))
                        colorItem = "Rojo";

                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "  Valor Item:  " + contenedor.Items[i].ToString() + "  Color :  " + colorItem.ToString();
                }

                richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
                richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
                richTextBox1.Text = richTextBox1.Text + " El ciclo replicado es el siguiente : " + Environment.NewLine;

                for (int j = posicionInicial; j <= posicionFinal; j++)
                {
                    int nI = Convert.ToInt32(contenedor.Items[j]);

                    if (EngineData.Negro.Contains(nI))
                        colorItem = "Negro";
                    else if (EngineData.Rojo.Contains(nI))
                        colorItem = "Rojo";

               

                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine + "  Color Espejo:  " + CambioColor(colorItem);
                }
               
            }
            else
            {
                MessageBox.Show("Debe ingresar mas de 6 resultados");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.contRojo = 0;
            this.contNegro = 0;
            this.contEntrada = 0;
            this.contenedor = new ListBox();
            richTextBox1.Text =string.Empty;
        }

        private void checkNegro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkRojo_CheckedChanged(object sender, EventArgs e)
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

        private void txtResultado_KeyUp(object sender, KeyEventArgs e)
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
