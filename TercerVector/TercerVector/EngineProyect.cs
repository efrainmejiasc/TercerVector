using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerVector
{
    public class EngineProyect
    {

        public Ruta ConstruirModeloRuta(string [] v)
        {
            Ruta m = new Ruta();
            m.Campo1 = v[0];
            m.Campo2 = v[1];
            m.Campo3 = v[2];
            m.Campo4 = v[3];
            m.Campo5 = v[4];
            m.Campo6 = v[5];
            m.Resultado = v[6];
            return m;
        }
    }
}
