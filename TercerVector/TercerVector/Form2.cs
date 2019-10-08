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
    public partial class Form2 : Form
    {
        private ListBox listBox1 = new ListBox();
        private ListBox listBox2 = new ListBox();
        private List<string> listresultado = new List<string>();
        private List<string> listresultado2 = new List<string>();
        private List<KeyValuePair<string, int>> loop = new List<KeyValuePair<string, int>>();
        private EngineData Valor = EngineData.Instance();
        private EngineProject Funcion = new EngineProject();
        private VectorModel Vector = new VectorModel();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Date >= Convert.ToDateTime("2019/10/14"))
                Application.Exit();
            pronostico.Text = "Esperando Pronostico";
        }

        private void AddNumber_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)
                return;
             //*********************************************************************************
            int n = Convert.ToInt32(txtResultado.Text);
            string color = Funcion.AddResultadoLista(n, this.listBox1, this.listBox2, this.listresultado);
            //**********************************************************************************
            Funcion.SetListBoxView(this.ListNegro, this.ListRojo, this.listresultado2, this.listBox1, this.listBox2, this.listresultado);
            //**********************************************************************************
            int startIndex = 0;
            int conteo = 0;
            loop.Clear();
            while (startIndex < listresultado2.Count)
            {
                conteo = Funcion.EstablecerPared(startIndex, this.listresultado2,this.loop);
                startIndex = startIndex + conteo;
            }
            //**********************************************************************************
            txtResultado.Text = string.Empty;
            string setColor = Funcion.EstablecerValoresSecuencia(color, Valor.contador);
            if (setColor != string.Empty)
            {
                Funcion.SetColor(setColor,this.pronostico);
                Valor.contador++;
                txtResultado.Focus();
                return;
            }
            //***********************************************************************************
            if (Valor.inicioEstablecido == false && loop.Count >= 4)
            {
                this.Vector = new VectorModel();
                this.Vector= Funcion.Set3erVector(loop,this.Vector);
                Funcion.SetColor(Funcion.SetParedActiva(loop,0), this.pronostico);
                Valor.contador++;
                txtResultado.Focus();
                return;
            }
            else if (Valor.inicioEstablecido == true)
            {
                Funcion.SetColor(Funcion.Traza3erVector(color, this.Vector, this.loop), this.pronostico);
            }
            //***********************************************************************************
            Valor.contador++;
            txtResultado.Focus();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Vector = new VectorModel();
            loop.Clear();
            listresultado.Clear();
            listresultado2.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ListNegro.Items.Clear();
            ListRojo.Items.Clear();
            Valor.contador = 0;
            Valor.inicioEstablecido = false;
            Valor.contConsecutivoNegro = 0;
            Valor.contConsecutivoRojo = 0;
            Valor.anteriorNegro = false;
            Valor.anteriorRojo = false;
            //****************************************************
            pronostico.BackColor = Color.SeaGreen;
            txtResultado.Focus();
        }

        private void Condiciones_Click(object sender, EventArgs e)
        {

        }

        //EVENTOS
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
            this.pronostico.BackColor = Color.SeaGreen;
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
