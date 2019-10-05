using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerVector
{
    public class EngineProject
    {
        private EngineData Valor = EngineData.Instance();

        public string AddResultadoLista(int n , ListBox listBox1 , ListBox  listBox2, List<string> listresultado)
        {
            int resultado = Convert.ToInt32(n);

            string color = string.Empty;
            if (EngineData.Negro.Contains(resultado))
            {
                color = "Negro";
                listBox1.Items.Add(resultado);
                listBox2.Items.Add(string.Empty);
                listresultado.Insert(Valor.contador, color);
            }
            else if (EngineData.Rojo.Contains(resultado))
            {
                color = "Rojo";
                listBox2.Items.Add(resultado);
                listBox1.Items.Add(string.Empty);
                listresultado.Insert(Valor.contador, color);
            }
            return color;
        }


        public void SetListBoxView(ListBox ListNegro,ListBox ListRojo , List<string> listresultado2 , ListBox listBox1, ListBox listBox2, List<string> listresultado)
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


        public int EstablecerPared(int posicion, List<string> listresultado2, List<KeyValuePair<string, int>> loop)
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


        public string EstablecerValoresSecuencia(string color, int iteracion)
        {
            string resultado = string.Empty;
            if (iteracion == 0)
            {
                if (color == "Negro")
                {
                    Valor.contConsecutivoRojo = 0;
                    Valor.contConsecutivoNegro = 1;
                    Valor.anteriorNegro = true;
                    Valor.anteriorRojo = false;
                }
                else if (color == "Rojo")
                {
                    Valor.contConsecutivoNegro = 0;
                    Valor.contConsecutivoRojo = 1;
                    Valor.anteriorNegro = false;
                    Valor.anteriorRojo = true;
                }
                return resultado;
            }

            if (color == "Negro")
            {
                Valor.contConsecutivoRojo = 0;
                Valor.anteriorRojo = false;
                Valor.anteriorNegro = true;
                if (Valor.anteriorNegro)
                {
                    Valor.contConsecutivoNegro++;
                }
                else if (!Valor.anteriorNegro)
                {
                    Valor.contConsecutivoNegro = 0;
                }
            }
            else if (color == "Rojo")
            {
                Valor.contConsecutivoNegro = 0;
                Valor.anteriorNegro = false;
                Valor.anteriorRojo = true;
                if (Valor.anteriorRojo)
                {
                    Valor.contConsecutivoRojo++;
                }
                else if (!Valor.anteriorRojo)
                {
                    Valor.contConsecutivoRojo = 0;
                }
            }

            if (Valor.contConsecutivoNegro > 3)
                resultado = "Negro";
            else if (Valor.contConsecutivoRojo > 3)
                resultado = "Rojo";

            return resultado;
        }

        public void SetColor(string color,GroupBox pronostico)
        {
            if (color == "Negro")
                pronostico.BackColor = Color.Black;
            else if (color == "Rojo")
                pronostico.BackColor = Color.Red;
        }


        //Establecer Vector -> 
        #region EstablecerCicloSemiCiclo 
        public VectorModel EstablecerVector(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            if (loop.Count < 4)
                return null;

            if (vector.MagicoSemiCiclo == 0)
                SetCicloSemiCiclo(loop,vector);

            return vector;
        }

        public void SetCicloSemiCiclo(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            Valor.inicioEstablecido = true;
            if (loop.Count == 4)
            {
                EstablecerPosicionDosTres(loop , vector);
            }
            else if (loop.Count >= 5)
            {
                bool existeCiclo = ExisteCiclo(loop);
                if (!existeCiclo)
                    EstablecerPosicionDosTres(loop, vector);
                else if (existeCiclo)
                    EstablecerPosicionDosTresCuatro(loop, vector);
            }
        }


        public void EstablecerPosicionDosTres(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            int n = 0;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n == 0)
                {
                    vector.GetCantidad = item.Value;
                    if (item.Key == "Negro")
                        vector.GetCantidadNegro = vector.GetCantidadNegro + item.Value;
                    else if (item.Key == "Rojo")
                        vector.GetCantidadRojo = vector.GetCantidadRojo + item.Value;
                }
                else if (n >= 2 && n <= 3)
                {
                    if (item.Key == "Negro")
                        vector.PostNegroSemiciclo = item.Value;
                    else if (item.Key == "Rojo")
                        vector.PostRojoSemiciclo = item.Value;
                }
                n++;
            }
            vector.MagicoSemiCiclo = vector.PostNegroSemiciclo + vector.PostRojoSemiciclo;
        }

        private void EstablecerPosicionDosTresCuatro(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
           /* int n = 0;
            vector.CicloSemiciclo = true;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n == 0)
                {
                    vector.NumeroResultado = item.Value;
                    if (item.Key == "Negro")
                        vector.NumeroResultadoNegro = item.Value;
                    else if (item.Key == "Rojo")
                        vector.NumeroResultadoRojo = item.Value;
                }
                else if (n >= 2 && n <= 4)
                {
                    if (item.Key == "Negro")
                        vector.NumeroEsperadoNegro = vector.NumeroEsperadoNegro + item.Value;
                    else if (item.Key == "Rojo")
                        vector.NumeroEsperadoRojo = vector.NumeroEsperadoRojo + item.Value;
                }
                n++;
            }
            vector.Magico = SetNumeroMagico();*/
        }

        private bool ExisteCiclo(List<KeyValuePair<string, int>> loop)
        {
            int n = 0;
            bool resultado = false;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n >= 1 && n <= 3)
                {
                    if (item.Value == 1)
                        resultado = true;
                    n++;
                }
            }
            return resultado;
        }
        #endregion

    }
}
