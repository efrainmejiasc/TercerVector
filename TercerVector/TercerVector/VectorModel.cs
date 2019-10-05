using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TercerVector
{
    public class VectorModel
    {
        // Representan  los numeros que salieron en la ruleta para establecer el ciclo
        public int MagicoCiclo { get; set; }

        public int MagicoSemiCiclo { get; set; }

        public int PostRojoCiclo { get; set; }

        public int PostRojoSemiciclo { get; set; }

        public int PostNegroCiclo { get; set; }

        public int PostNegroSemiciclo { get; set; }

        // Representan  los numeros que salieron en la ruleta para replicar el ciclo
        public int GetCantidad { get; set; }

        public int GetCantidadNegro { get; set; }

        public int GetCantidadRojo { get; set; }


        // Establece si existe ciclo
        public bool ExisteCiclo { get; set; }
    }
}
