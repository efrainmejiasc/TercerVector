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


        //Establecer Vector -> *******************************************************************************************
        #region EstablecerCicloSemiCiclo 

        public VectorModel Set3erVector(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            Valor.inicioEstablecido = true;
            vector = SetPosicionCero(loop, vector);
            vector.ExisteCiclo = ExisteCiclo(loop);
            if (vector.ExisteCiclo)
            {
                vector = SetSemiCiclo(loop, vector);
                vector = SetCiclo(loop, vector);
                vector.Magico = vector.MagicoCiclo + vector.MagicoSemiCiclo;
            }
            else if (!vector.ExisteCiclo)
            {
                vector = SetSemiCiclo(loop, vector);
                vector.Magico = vector.MagicoSemiCiclo;
            }
            return vector;
        }

        private VectorModel SetCiclo (List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            if (Valor.iter)
            {
                vector = SetPosicionIndex(loop, vector, 1);
            }
            else if (!Valor.iter)
            {
                vector = SetPosicionIndex(loop, vector, 4);
            }
            return vector;
        }

        private VectorModel SetPosicionIndex(List<KeyValuePair<string, int>> loop, VectorModel vector,int index)
        {
            vector.MagicoCiclo = loop[index].Value;
            if (loop[index].Key == "Negro")
                vector.CantidadNegroCiclo = loop[index].Value;
            else if (loop[index].Key == "Rojo")
                vector.CantidadRojoCiclo = loop[index].Value;

            return vector;
        }


        private VectorModel SetSemiCiclo(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            int n = 0;
            foreach (KeyValuePair<string, int> item in loop)
            {
                if (n >= 2 && n <= 3)
                {
                    if (item.Key == "Negro")
                    {
                        vector.CantidadNegroSemiCiclo = vector.CantidadNegroSemiCiclo + item.Value;
                    }
                    else if (item.Key == "Rojo")
                    {
                        vector.CantidadRojoSemiCiclo = vector.CantidadRojoSemiCiclo + item.Value;
                    }
                }
                n++;
            }
            vector.MagicoSemiCiclo = vector.CantidadNegroSemiCiclo + vector.CantidadRojoSemiCiclo;
            return vector;
        }

        private VectorModel SetPosicionCero(List<KeyValuePair<string, int>> loop, VectorModel vector)
        {
            vector.CantidadReplica = loop[0].Value;
            if (loop[0].Key == "Negro")
                vector.CantidadNegroReplica = vector.CantidadNegroReplica + loop[0].Value;
            else if (loop[0].Key == "Rojo")
                vector.CantidadRojoReplica = vector.CantidadRojoReplica + loop[0].Value;

            return vector;
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
                }
                n++;
            }
            return resultado;
        }

        #endregion

        // Traza vector -> **********************************************************************************************
        #region TrazaVector

        public string Traza3erVector(string color, VectorModel vector, List<KeyValuePair<string, int>> loop)
        {
            string sabor = string.Empty;
            vector.CantidadReplica++;
            //***************************************************
            if (vector.CantidadReplica == vector.Magico)
            {
                Valor.inicioEstablecido = false;
                Valor.cantidadParedMayor = 0;
                if (Valor.iter)
                    Valor.iter = false;
               return GetUltimoPronostico();
            }
            //***************************************************
            if (vector.CantidadReplica == vector.MagicoSemiCiclo)
            {
                return GetUltimoPronostico();
            }
            //***************************************************

            if (Valor.cantidadParedMayor == 0)
                GetParedMayor(2,3,loop);

            if (vector.ExisteCiclo)
            {
                if (vector.CantidadReplica < vector.MagicoSemiCiclo)
                {
                    if (vector.CantidadReplica  < Valor.cantidadParedMayor)
                    {
                        return Valor.paredActiva;
                    }
                    else if (vector.CantidadReplica  == Valor.cantidadParedMayor)
                    {
                        return GetUltimoPronostico();
                    }
                }
                //else if (vector.CantidadReplica < vector.MagicoCiclo)
                else if (vector.CantidadReplica < vector.Magico)
                {
                    return Valor.paredActiva;
                }
            }
            else if (!vector.ExisteCiclo)
            {
                if (vector.CantidadReplica < Valor.cantidadParedMayor)
                {
                    return Valor.paredActiva;
                }
                else if (Valor.cantidadParedMayor == vector.CantidadReplica)
                {
                    return GetUltimoPronostico();
                }
            }

            return sabor;
        }

        private void  GetParedMayor(int startIndex , int endIndex, List<KeyValuePair<string, int>> loop)
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