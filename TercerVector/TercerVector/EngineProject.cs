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

        //**************************BEGIN PRINCIPAL *********************************************************************************************************************************
        #region PRINCIPAL 

        public string AddResultadoLista(int n, ListBox listBox1, ListBox listBox2, List<string> listresultado)
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


        public void SetListBoxView(ListBox ListNegro, ListBox ListRojo, List<string> listresultado2, ListBox listBox1, ListBox listBox2, List<string> listresultado)
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
            {
                resultado = "Negro";
            }
            else if (Valor.contConsecutivoRojo > 3)
            {
                resultado = "Rojo";
            }

            return resultado;
        }

        public string EstablecerValoresAlternado(List<KeyValuePair<string, int>> loop)
        {
            int n = 0;
            bool resultado = true;
            string sabor = string.Empty;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n > 3)
                    break;

                if (item.Value > 1)
                {
                    resultado = false;
                    Valor.inicioEstablecido = false;
                    break;
                }
                n++;
            }

            if (resultado)
            {
                if (loop[0].Key == "Negro")
                    sabor = "Rojo";
                else if (loop[0].Key == "Rojo")
                    sabor = "Negro";
            }

            return sabor;
        }

        public void SetColor(string color, GroupBox pronostico)
        {
            if (color == "Negro")
                pronostico.BackColor = Color.Black;
            else if (color == "Rojo")
                pronostico.BackColor = Color.Red;

            pronostico.Text = "Jugar";
        }

        #endregion
        //*******************END PRINCIPAL*************************************************************************************************************************************************
        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //*******************BEGIN INICIO_JUEGO********************************************************************************************************************************************
        #region INICIOJUEGO
        public string  LoopCountSecuencia(List<KeyValuePair<string, int>> loop , string color)
        {
            string sabor = string.Empty;

            if (loop.Count == 2 || loop.Count ==  3)
                sabor = color;

            return sabor;
        }

        #endregion
        //*******************END INICIO_JUEGO**********************************************************************************************************************************************
        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //*******************BEGIN SET3ERVECTOR********************************************************************************************************************************************
        #region SET3ERVECTOR
        public Model3ErVector Set3erVector(List<KeyValuePair<string, int>> loop, Model3ErVector Vector)
        {
            Valor.inicioEstablecido = true;
            if (Valor.iteraccion == 0)
            {
                GetParedMayor(2, 3, loop);//Establesco pared con mayor cantidad y color
                Vector = SetPosicionCero(loop, Vector);
                Vector.ExisteCiclo = ExisteCicloIteracion0(loop);
                if (Vector.ExisteCiclo)
                {
                    Vector = SetSemiCiclo(loop, Vector);
                    Vector = SetCiclo(loop, Vector);
                    Vector.Magico = Vector.MagicoCiclo + Vector.MagicoSemiCiclo;
                }
                else if (!Vector.ExisteCiclo)
                {
                    Vector = SetSemiCiclo(loop, Vector);
                    Vector.Magico = Vector.MagicoSemiCiclo;
                }
            }
            else if (Valor.iteraccion > 0)
            {
                if (Vector.ExisteCiclo)
                {
                    Vector = SetSemiCiclo(loop, Vector);
                    Vector = SetCiclo(loop, Vector);
                    Vector.Magico = Vector.MagicoCiclo + Vector.MagicoSemiCiclo;
                }
                else if (!Vector.ExisteCiclo)
                {
                    Vector = SetSemiCiclo(loop, Vector);
                    Vector.Magico = Vector.MagicoSemiCiclo;
                }
            }
            Valor.iteraccion++;
            return Vector;
        }

        private bool ExisteCicloIteracion0(List<KeyValuePair<string, int>> loop)
        {
            int n = 0;
            bool resultado = false;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n >= 1 && n <= 3)
                {
                    if (item.Value == 1)
                        resultado = true;
                }
                n++;
            }
            return resultado;
        }

        private void GetParedMayor(int startIndex, int endIndex, List<KeyValuePair<string, int>> loop)
        {
            if (loop[startIndex].Value >= loop[endIndex].Value)
            {
                Valor.cantidadParedMayor = loop[startIndex].Value;
                Valor.colorParedMayor = loop[startIndex].Key;
            }
            else if (loop[endIndex].Value > loop[startIndex].Value)
            {
                Valor.cantidadParedMayor = loop[endIndex].Value;
                Valor.colorParedMayor = loop[endIndex].Key;
            }
        }

        private Model3ErVector SetPosicionCero(List<KeyValuePair<string, int>> loop, Model3ErVector Vector)
        {
            Vector.CantidadReplicada =  loop[0].Value;
            return Vector;
        }

        private Model3ErVector SetCiclo(List<KeyValuePair<string, int>> loop, Model3ErVector Vector)
        {
            if (Valor.iteraccion == 0)
            {
                Vector = SetPosicionIndex(loop, Vector, 1);
            }
            else if (Valor.iteraccion  > 0)
            {
                Vector = SetPosicionIndex(loop, Vector, 4);
            }
            return Vector;
        }

        private Model3ErVector SetPosicionIndex(List<KeyValuePair<string, int>> loop, Model3ErVector vector, int index)
        {
            vector.MagicoCiclo = loop[index].Value;
            return vector;
        }

        private Model3ErVector SetSemiCiclo(List<KeyValuePair<string, int>> loop, Model3ErVector Vector)
        {
            int n = 0;
            int cantidadNegroSemiCiclo = 0;
            int cantidadRojoSemiCiclo = 0;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n >= 2 && n <= 3)
                {
                    if (item.Key == "Negro")
                    {
                        cantidadNegroSemiCiclo = cantidadNegroSemiCiclo + item.Value;
                    }
                    else if (item.Key == "Rojo")
                    {
                        cantidadRojoSemiCiclo = cantidadRojoSemiCiclo + item.Value;
                    }
                }
                n++;
            }
            Vector.MagicoSemiCiclo = cantidadNegroSemiCiclo + cantidadRojoSemiCiclo;
            return Vector;
        }

        #endregion
        //*******************END SET3ERVECTOR**********************************************************************************************************************************************
        // ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //********************BEGIN TRAZA3ERVECTOR********************************************************************************************************************************************
        #region TRAZA3ERVECTOR
        public string Traza3erVector(string color, Model3ErVector vector, List<KeyValuePair<string, int>> loop)
        {
            string sabor = string.Empty;
            vector.CantidadReplicada++;
            //***************************************************
            if (vector.CantidadReplicada == vector.Magico)
            {
                Valor.inicioEstablecido = false;
                Valor.cantidadParedMayor = 0;
                return GetUltimoPronostico();
            }
            //***************************************************
            if (vector.CantidadReplicada == vector.MagicoSemiCiclo)
            {
                return GetUltimoPronostico();
            }
            //***************************************************

            if (Valor.cantidadParedMayor == 0)
                GetParedMayor(2, 3, loop);

            if (vector.ExisteCiclo)
            {
                if (vector.CantidadReplicada < vector.MagicoSemiCiclo)
                {
                    if (vector.CantidadReplicada < Valor.cantidadParedMayor)
                    {
                        return Valor.paredActiva;
                    }
                    else if (vector.CantidadReplicada == Valor.cantidadParedMayor)
                    {
                        return GetUltimoPronostico();
                    }
                }
                //else if (vector.CantidadReplicada < vector.MagicoCiclo)
                else if (vector.CantidadReplicada < vector.Magico)
                {
                    return Valor.paredActiva;
                }
            }
            else if (!vector.ExisteCiclo)
            {
                if (vector.CantidadReplicada < Valor.cantidadParedMayor)
                {
                    return Valor.paredActiva;
                }
                else if (Valor.cantidadParedMayor == vector.CantidadReplicada)
                {
                    return GetUltimoPronostico();
                }
            }

            return sabor;
        }

        private string GetUltimoPronostico()
        {
            if (Valor.paredActiva == "Negro")
                Valor.paredActiva = "Rojo";
            else if (Valor.paredActiva == "Rojo")
                Valor.paredActiva = "Negro";

            return Valor.paredActiva;
        }

        public string SetParedActiva(List<KeyValuePair<string, int>> loop, int indice = 0)
        {
            if (loop[indice].Key == "Negro")
            {
                Valor.paredActiva = "Negro";
            }
            else if (loop[indice].Key == "Rojo")
            {
                Valor.paredActiva = "Rojo";
            }

            return Valor.paredActiva;
        }

        #endregion
    }
}