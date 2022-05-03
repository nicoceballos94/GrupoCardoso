using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Compartidas;

namespace Persistencia.Interfaces
{
    public interface IPerUsuario
    {
        Usuario Logueo(string pMail, string pPass);
        void AgregarUsuario(Usuario U);
    }
}
