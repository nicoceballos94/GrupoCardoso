using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
   internal class Conexion
    {
        private static string _cnn = "Data Source=DESKTOP-V8DJHSA; Initial Catalog = GrupoCardoso; Integrated Security = true";
        
        internal static string Cnn
        {
            get { return _cnn; }
        }
    }
}
