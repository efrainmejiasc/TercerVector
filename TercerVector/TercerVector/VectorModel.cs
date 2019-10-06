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
        //*****************************************************

        public int CantidadNegroSemiCiclo { get; set; }

        public int CantidadRojoSemiCiclo { get; set; }

        public int CantidadNegroCiclo { get; set; }

        public int CantidadRojoCiclo { get; set; }


        // Representan  los numeros que salieron en la ruleta para replicar el ciclo
        public int CantidadReplica { get; set; }

        public int CantidadNegroReplica { get; set; }

        public int CantidadRojoReplica { get; set; }
       //****************************************************

        public int CantidadReplicaSemiCiclo { get; set; }

        public int CantidadNegroReplicaSemiCiclo { get; set; }

        public int CantidadRojoReplicaSemiCiclo { get; set; }

        public int CantidadReplicaCiclo { get; set; }

        public int CantidadNegroReplicaCiclo { get; set; }

        public int CantidadRojoReplicaCiclo { get; set; }


        // Establece si existe ciclo
        public bool ExisteCiclo { get; set; }
    }
}
