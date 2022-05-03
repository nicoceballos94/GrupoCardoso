using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Interfaces;
using Logica.Clases;
namespace Logica
{
    public class Fabrica
    {
        public static ILogicaUsuario GetLU()
        {
            return LogicaUsuario.GetInstancia();
        }
    }
}
