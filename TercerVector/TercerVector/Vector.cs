using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerVector
{
   public  class Vector
   {
        // Representan  los numeros que salieron en la ruleta para establecer el ciclo
        public int MagicoCiclo { get; set; }

        public int MagicoSemiCiclo { get; set; }

        public int PostRojoCiclo { get; set; }

        public int PostRojoSemiciclo { get; set; }

        public int PostNegroCiclo { get; set; }

        public int PostNegroSemiciclo { get; set; }

        // Representan  los numeros que salieron en la ruleta para replicar el ciclo
        public int GetCiclo { get; set; }

        public int GetSemiCiclo  { get; set; }

        public int GetCicloNegro { get; set; }

        public int GetSemiCicloNegro { get; set; }

        public int GetCicloRojo { get; set; }

        public int GetSemiCicloRojo { get; set; }

        // Establece si es un ciclo o semi-ciclo 
        public bool CicloSemiciclo { get; set; }
    }
}
