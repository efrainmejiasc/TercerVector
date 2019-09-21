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
        private bool iniciado = false;
        private int contConsecutivoNegro = 0;
        private int contConsecutivoRojo = 0;
        private bool anteriorNegro = false ;
        private bool anteriorRojo = false;
        private ListBox listBox1 = new ListBox();
        private ListBox listBox2 = new ListBox();

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

            AddResultadoLista();
            txtResultado.Text = string.Empty;
            txtResultado.Focus();
        }

        private void AddResultadoLista()
        {
            string n = txtResultado.Text;
            int resultado = Convert.ToInt32(n);
            List<string> listresultado = new List<string>();
            string color = string.Empty;
            if (EngineData.Negro.Contains(resultado))
            {
                color = "Negro";
                listBox1.Items.Add(resultado);
                listBox2.Items.Add(string.Empty);
                listresultado.Add(color);
            }
            else if (EngineData.Rojo.Contains(resultado))
            {
                color = "Rojo";
                listBox2.Items.Add(resultado);
                listBox1.Items.Add(string.Empty);
                listresultado.Add(color);
            }
            SetListBoxView();

            string setColor = EstablecerValoresSecuencia(color,contador);
            if (setColor != string.Empty && !iniciado)
                SetColor(setColor);

            contador++;
        } 

        private string  EstablecerValoresSecuencia(string color , int iteracion)
        {
            string resultado = string.Empty;
            if (iteracion == 0)
            {
                if (color == "Negro")
                {
                    contConsecutivoRojo = 0;
                    contConsecutivoNegro = 1;
                    anteriorNegro = true;
                    anteriorRojo = false;
                }
                else if (color == "Rojo")
                {
                    contConsecutivoNegro = 0;
                    contConsecutivoRojo = 1;
                    anteriorNegro = false;
                    anteriorRojo = true;
                }
                return resultado;
            }

            if (color == "Negro")
            {
                contConsecutivoRojo = 0;
                anteriorRojo = false;
                anteriorNegro = true;
                if (anteriorNegro)
                {
                    contConsecutivoNegro++;
                }
                else if (!anteriorNegro)
                {
                    contConsecutivoNegro = 0;
                }
            }
            else if (color == "Rojo")
            {
                contConsecutivoNegro = 0;
                anteriorNegro = false;
                anteriorRojo = true;
                if (anteriorRojo)
                {
                    contConsecutivoRojo++;
                }
                else if (!anteriorRojo)
                {
                    contConsecutivoRojo = 0;
                }
            }

            if (contConsecutivoNegro > 3)
                resultado = "Negro";
            else if (contConsecutivoRojo > 3)
                resultado = "Rojo";

            return resultado;
        }

        private void SetColor (string color)
        {
            if (color =="Negro")
                pronostico.BackColor = Color.Black;
            else if (color == "Rojo")
                pronostico.BackColor = Color.Red;
        }

        private void SetListBoxView()
        {
            ListNegro.Items.Clear();
            ListRojo.Items.Clear();

            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                ListNegro.Items.Add (listBox1.Items[i]);

            for (int j = listBox2.Items.Count - 1; j >= 0; j--)
                ListRojo.Items.Add(listBox2.Items[j]);
        }

        //********************************************************************************************
      
        private void EliminarResultado_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ListNegro.Items.Clear();
            ListRojo.Items.Clear();
            contador = 0;
            iniciado = false;
            contConsecutivoNegro = 0;
            contConsecutivoRojo = 0;
            anteriorNegro = false;
            anteriorRojo = false;
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

        //****************************************************************************
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
