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
        public int Magico { get; set; }

        public int NumeroEsperadoNegro { get; set; }

        public int NumeroEsperadoRojo { get; set; }

        // Representan  los numeros que salieron en la ruleta para replicar el ciclo
        public int NumeroResultado { get; set; }

        public int NumeroResultadoNegro { get; set; }

        public int NumeroResultadoRojo { get; set; }

        //Iniciado o no iniciado el ciclo
        public bool Iniciado { get; set; }

        // Establece si es un ciclo o semi-ciclo 
        public bool CicloSemiciclo { get; set; }
    }
}
