using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerVector
{
    public class EngineData
    {
        private static EngineData valor;
        public static EngineData Instance()
        {
            if ((valor == null))
            {
                valor = new EngineData();
            }
            return valor;
        }

        public static int[] Rojo = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        public static int[] Negro = { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

        public static string SQLRuta = "INSERT INTO Ruta (Campo1,Campo2,Campo3,Campo4,Campo5,Campo6) VALUES (@Campo1,@Campo2,@Campo3,@Campo4,@Campo5,@Campo6)";
        public static string SQLMapa = "";
    }
}
