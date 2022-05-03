using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Compartidas;

namespace Logica.Interfaces
{
   public interface ILogicaUsuario
    {
        Usuario Logueo(string pMail, string pPass);
        void AgregarUsuario(Usuario u);
    }
}
