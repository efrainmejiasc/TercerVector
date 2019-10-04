using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerVector
{
    public class EngineData
    {
        public static EngineData valor;
        public static EngineData Instance()
        {
            if ((valor == null))
            {
                valor = new EngineData();
            }
            return valor;
        }

        private Vector vector = new Vector();

        public static int[] Rojo = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };

        public static int[] Negro = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        public int contador  { get; set; }

        public bool inicioEstablecido { get; set; } 

        public int contConsecutivoRojo { get; set; }

        public int contConsecutivoNegro { get; set; }

        public bool anteriorNegro { get; set; }

        public bool anteriorRojo { get; set; }

        public string paredActiva = string.Empty;

        public ListBox listBox1 { get; set; }

        public ListBox listBox2 { get; set; }

        public List<string> listresultado { get; set; }

        public List<string> listresultado2 { get; set; }

        public List<KeyValuePair<string, int>> loop { get; set; }
 

        public Vector GetVector()
        {
            return vector;
        }

        public void SetVector(Vector v)
        {
            vector = new Vector();
            vector = v;
        }
    }
}
