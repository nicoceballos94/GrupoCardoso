using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Compartidas;
using System.Data;
using System.Data.SqlClient;
using System.IO;

using Persistencia.Interfaces;

namespace Persistencia.Clases
{
    internal class PerUsuario : IPerUsuario
    {

        private static PerUsuario _instancia = null;

        private PerUsuario() { }

        public static PerUsuario GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PerUsuario();

            return _instancia;
        }
        public Usuario Logueo(string pMail, string pPass)
        {
            string correo;
            string pass;
            string nombre;
            int permiso;
            byte[] image;
            Usuario U = null;
            int variable =1;

            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Loguear", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            oComando.Parameters.AddWithValue("@pMail", pMail);
            oComando.Parameters.AddWithValue("@pPass", pPass);

            


            SqlDataReader oReader;
            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();

                if (oReader.Read())
                {
                    correo = (string)oReader["CORREO"];
                    pass = (string)oReader["PASS"];
                    nombre = (string)oReader["NOMBRE"];
                    permiso = (int)oReader["PERMISO"];
                    if ((byte[])oReader["FOTO"] != null)
                        image = (byte[])oReader["FOTO"];
                    else
                        
                    U = new Usuario(correo,pass,nombre,permiso,image);

                }

                oReader.Close();
            }
            catch (Exception ex)
            {
                U = null;
                return U;
            }
            finally
            {
                oConexion.Close();
            }
            return U;


        }

        public void AgregarUsuario(Usuario U)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("AltaUsuario", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter correo = new SqlParameter("@pCorreo", U.Correo);
            SqlParameter pass = new SqlParameter("@pPass", U.Correo);
            SqlParameter nombre = new SqlParameter("@pNombre", U.Correo);
            SqlParameter permiso = new SqlParameter("@pPermiso", U.Correo);
            SqlParameter image = new SqlParameter("@pImage", U.Correo);

            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            oComando.Parameters.Add(correo);
            oComando.Parameters.Add(pass);
            oComando.Parameters.Add(nombre);
            oComando.Parameters.Add(permiso);
            oComando.Parameters.Add(image);

            int oAfectados = -1;

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
           
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oConexion.Close();
            }

        }
    }

    
}
