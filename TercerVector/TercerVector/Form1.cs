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
        private EngineProyect Funcion = new EngineProyect();
        private string [] tercerVector = new string[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pronostico.Text = "Esperando Pronostico";
        }

        private void AddNumber_Click(object sender, EventArgs e)
        {
            int resultado = -1;
            if (txtResultado.Text != string.Empty)
            {
                resultado = Convert.ToInt32(txtResultado.Text);
                if (EngineData.Negro.Contains(resultado))
                {
                    ListNegro.Items.Add(resultado);
                    ListRojo.Items.Add(string.Empty);
                }
                else if (EngineData.Rojo.Contains(resultado))
                {
                    ListRojo.Items.Add(resultado);
                    ListNegro.Items.Add(string.Empty);
                }
                else
                {
                    if (checkNegro.Checked)
                    {
                        ListNegro.Items.Add(0);
                        checkNegro.Checked = false;
                    }
                    else if (checkRojo.Checked)
                    {
                        ListRojo.Items.Add(0);
                        checkRojo.Checked = false;
                    }
                }
            }
            //*******************************************
            if (ListNegro.Items.Count + ListRojo.Items.Count >= 5)
            {
                if (resultado % 2 == 1)
                {
                    pronostico.BackColor = Color.Black;
                    pronostico.Text = "Juega al Negro";
                }
                else
                {
                    pronostico.BackColor = Color.Red;
                    pronostico.Text = "Juega al Rojo";
                }
            }
            else
            {
                pronostico.BackColor = Color.SeaGreen;
            }
            //******************************************

            txtResultado.Text =string.Empty;
            txtResultado.Focus();
        }
      
        private void EliminarResultado_Click(object sender, EventArgs e)
        {
            if (ListNegro.SelectedIndex >= 0)
                ListNegro.Items.RemoveAt(ListNegro.SelectedIndex);

            else if (ListRojo.SelectedIndex >= 0)
                ListRojo.Items.RemoveAt(ListRojo.SelectedIndex);
            //****************************************************
            pronostico.BackColor = Color.SeaGreen;
        }

        private void NuevoCiclo_Click(object sender, EventArgs e)
        {
            NuevoLoop();
        }

        private void NuevoLoop()
        {
            ListNegro.Items.Clear();
            ListRojo.Items.Clear();
            //****************************************************
            pronostico.BackColor = Color.SeaGreen;
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
        }

        private void txtResultado_Leave(object sender, EventArgs e)
        {
            if (txtResultado.Text != string.Empty)
            {
                int resultado = Convert.ToInt32(txtResultado.Text);
                if (resultado < 0  || resultado > 36)
                {
                    txtResultado.Text = string.Empty;
                }
            }
        }

        private void checkNegro_CheckedChanged(object sender, EventArgs e)
        {
            checkRojo.Checked = false;
            if(checkNegro.Checked)
                txtResultado.Text = "0";
            else
                txtResultado.Text = string.Empty;
        }

        private void checkRojo_CheckedChanged(object sender, EventArgs e)
        {
            checkNegro.Checked = false;
            if (checkRojo.Checked)
                txtResultado.Text = "0";
            else
                txtResultado.Text = string.Empty;
        }

        private void GuardarRuta_Click(object sender, EventArgs e)
        {
            if (txtPronostico.Text == string.Empty || txtPronostico.Text == null)
                return;
            for(int i = 0; i <= 5; i++)
            {
                if (ListNegro.Items[i]!= null)
                    tercerVector[i] = ListNegro.Items[i].ToString();
                else if (ListRojo.Items[i] != null)
                    tercerVector[i] = ListRojo.Items[i].ToString();
            }
            tercerVector[6] = txtPronostico.Text;
            NuevoLoop();
            txtPronostico.Text = string.Empty;
        }
    }
}
