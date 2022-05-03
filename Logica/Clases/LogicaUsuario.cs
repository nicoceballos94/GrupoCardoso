using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Compartidas;
using Persistencia;
using System.Data;
using Logica.Interfaces;

namespace Logica.Clases
{
    internal class LogicaUsuario : ILogicaUsuario
    {
        #region singleton
        private static LogicaUsuario _instancia = null;

        private LogicaUsuario() { }

        public static LogicaUsuario GetInstancia()
        {
            if (_instancia == null)
                _instancia = new LogicaUsuario();

            return _instancia;
        }
        #endregion

        public Usuario Logueo (string pMail, string pPass)
        {
            Usuario u = (Persistencia.Fabrica.GetPU().Logueo(pMail, pPass));
            return u;
        }
        public void AgregarUsuario(Usuario u)
        {
            Persistencia.Fabrica.GetPU().AgregarUsuario(u);
        }
    }
}
