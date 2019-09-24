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
        private int contador = 0;
        private bool iniciado = false;
        private int contConsecutivoNegro = 0;
        private int contConsecutivoRojo = 0;
        private bool anteriorNegro = false ;
        private bool anteriorRojo = false;
        private ListBox listBox1 = new ListBox();
        private ListBox listBox2 = new ListBox();
        List<string> listresultado = new List<string>();
        List<string> listresultado2 = new List<string>();
        private List<KeyValuePair<string, int>> loop = new List<KeyValuePair<string, int>>();

        public Form1()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Date >= Convert.ToDateTime("2019/09/29"))
                Application.Exit();
            pronostico.Text = "Esperando Pronostico";
        }

        private void AddNumber_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)
                return;

            string color = AddResultadoLista();
            //**********************************************************************************
             SetListBoxView();
            //**********************************************************************************
            if (listresultado.Count > 2)
            {
                int startIndex = 1;
                int conteo = 0;
                loop.Clear();
                while (startIndex <= listresultado2.Count - 1) 
                {
                  startIndex = startIndex + conteo;
                    if (startIndex >= listresultado2.Count)
                        break;

                    conteo = EstablecerPared(startIndex);
                }

            }
       
            string setColor = EstablecerValoresSecuencia(color, contador);
            if (setColor != string.Empty && !iniciado)
                SetColor(setColor);
           //***********************************************************************************
            contador++;
            txtResultado.Text = string.Empty;
            txtResultado.Focus();
        }


        private int EstablecerPared(int posicion)
        {
            int conteo = 0;
            string color = listresultado2[posicion];
            for (int i = posicion; i <= listresultado2.Count - 1; i++)
            {
                if (listresultado2[i] == color)
                    conteo++;
                else
                    break;
            }
            loop.Add(new KeyValuePair<string, int>(color, conteo));

            return conteo;
        }

        private string  AddResultadoLista()
        {
            string n = txtResultado.Text;
            int resultado = Convert.ToInt32(n);
         
            string color = string.Empty;
            if (EngineData.Negro.Contains(resultado))
            {
                color = "Negro";
                listBox1.Items.Add(resultado);
                listBox2.Items.Add(string.Empty);
                listresultado.Insert(contador,color);
            }
            else if (EngineData.Rojo.Contains(resultado))
            {
                color = "Rojo";
                listBox2.Items.Add(resultado);
                listBox1.Items.Add(string.Empty);
                listresultado.Insert(contador, color);
            }
            return color;
        }


        private void SetListBoxView()
        {
            ListNegro.Items.Clear();
            ListRojo.Items.Clear();
            listresultado2.Clear();

            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                ListNegro.Items.Add(listBox1.Items[i]);

            for (int j = listBox2.Items.Count - 1; j >= 0; j--)
                ListRojo.Items.Add(listBox2.Items[j]);

            for (int k = listresultado.Count - 1; k >= 0; k--)
                listresultado2.Add(listresultado[k]);
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



        //********************************************************************************************
      
        private void EliminarResultado_Click(object sender, EventArgs e)
        {
            listresultado.Clear();
            listresultado2.Clear();
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

        private void GuardarRuta_Click(object sender, EventArgs e)
        {
            if (loop.Count < 4)
            {
                MessageBox.Show( "Agrega mas paredes" , "Informacion del Sistema");
                return;
            }
            else if (loop.Count == 4)
            {

            }

            int n = 0;
            string mensaje = string.Empty;
            bool existe = false;
            int magico = 0;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n >= 0 && n <= 2)
                {
                    mensaje = mensaje + item.Key + ": " + item.Value + Environment.NewLine;
                    if (item.Value == 1)
                        existe = true;
                }
                n++;
            }

            n = 0;

            if (existe)
                mensaje = mensaje + "Existe unidad se tomara el ciclo" + Environment.NewLine;
            else
                mensaje = mensaje + "No existe unidad se tomara el semi-ciclo" + Environment.NewLine;

            foreach (KeyValuePair<string, int> item in loop)
            {
                if (existe)
                {
                    if (n >= 0 && n <= 2)
                    {
                        magico = magico + item.Value ;
                    }
                }
                else
                {
                    if (n >= 0 && n <= 1)
                    {
                        magico = magico + item.Value;
                    }
                }
             
                n++;
            }
            mensaje = mensaje + "El numero Magico es: " + magico.ToString();

            MessageBox.Show(mensaje, "Informacion del Sistema");
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

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
