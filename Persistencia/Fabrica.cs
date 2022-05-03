using Persistencia.Clases;
using Persistencia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
   public class Fabrica
    {
        public static IPerUsuario GetPU()
        {
            return PerUsuario.GetInstancia();
        }
    }
}
