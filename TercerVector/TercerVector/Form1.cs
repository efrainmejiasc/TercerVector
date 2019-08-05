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
        private EngineDb Metodo = new EngineDb();
        private int contador = 0;

       
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
            if (txtResultado.Text == string.Empty)
                return;
            EngineData Valor = EngineData.Instance();
            string n = txtResultado.Text;
            int resultado = Convert.ToInt32(n);
            List<string> listresultado = new List<string>();
            if (EngineData.Negro.Contains(resultado))
            {
                ListNegro.Items.Add(resultado);
                ListRojo.Items.Add(string.Empty);
                listresultado.Add("Negro");
            }
            else if (EngineData.Rojo.Contains(resultado))
            {
                ListRojo.Items.Add(resultado);
                ListNegro.Items.Add(string.Empty);
                listresultado.Add("Rojo");
            }
            
            if (contador >= 2)
            {
                int contNegro = 0;
                int contRojo = 0;

                foreach (string item in listresultado)
                {
                    if (item == "Negro")
                        contNegro++;
                    else
                        contRojo++;
                }

                if (contNegro > contRojo)
                {
                    pronostico.BackColor = Color.Red;
                    pronostico.Text = "Juega al Rojo";
                }
                else if (contNegro < contRojo)
                {
                    pronostico.BackColor = Color.Black;
                    pronostico.Text = "Juega al Negro";
                }
                else if(contNegro == contRojo)
                {
                    int t = listresultado.Count;
                    string ultimo = listresultado[t - 1];
                    if (ultimo == "Negro")
                    {
                        pronostico.BackColor = Color.Red;
                        pronostico.Text = "Juega al Rojo";

                    }
                    else
                    {
                        pronostico.BackColor = Color.Black;
                        pronostico.Text = "Juega al Negro";
                    }
                }
            }

            contador++;
            txtResultado.Text = string.Empty;
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
            pronostico.BackColor = Color.SeaGreen;
        }

        private void txtResultado_Leave(object sender, EventArgs e)
        {
            if (txtResultado.Text != string.Empty)
            {
                int resultado = Convert.ToInt32(txtResultado.Text);
                if (resultado <= 0  || resultado > 36)
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
            List<string> tercerVector = new List<string>();
            for (int i = 0; i <= 5 ; i++)
            {
                if (ListNegro.Items[i].ToString() != string.Empty)
                    tercerVector.Add (ListNegro.Items[i].ToString());
                else if (ListRojo.Items[i].ToString() != string.Empty)
                    tercerVector.Add(ListRojo.Items[i].ToString());
            }
            tercerVector.Add(txtPronostico.Text);
            //NuevoLoop();
            txtPronostico.Text = string.Empty;
            Ruta R = Funcion.ConstruirModeloRuta(tercerVector);
            if (Metodo.InsertarRuta(R))
                MessageBox.Show("Registro Exitoso");
            else
                MessageBox.Show("Registro Fallido");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }
    }
}
