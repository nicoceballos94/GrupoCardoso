using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Entidades_Compartidas
{
    public class Usuario
    {
        //ATRIBUTOS
        private string correo;
        private string pass;
        private string nombre;
        private int permiso;
        private byte[] imagen;

        //PROPIEDADES
        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                
                if (value.Length > 50)
                    throw new Exception("El Correo es demasiado largo");
                if(value == string.Empty)
                    throw new Exception("El Correo es NO puede ser vacio");
                Regex rx = new Regex("^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:.[a-zA-Z0-9-]+)*$");
                if (!rx.IsMatch(value))
                    throw new Exception("El formato del Mail es incorrecto ");


                correo = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                if(value == string.Empty)
                    throw new Exception("La contraseña NO puede ser vacia");
                if (value.Length < 5)
                    throw new Exception("La contraseña NO puede tener menos de 5 caracteres");
                pass = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("El nombre NO puede ser vacio");
                
                nombre = value;
            }
        }

        public int Permiso
        {
            get
            {
                return permiso;
            }

            set
            {
                
                permiso = value;
            }
        }

        public byte[] Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        //CONTRUCTOR
        public Usuario(string p_correo,string p_pass, string p_nombre, int p_permiso, byte[] p_image)
        {
            Correo = p_correo.ToLower();
            Pass = p_pass.Trim();
            Nombre = p_nombre.Trim().ToLower();
            Permiso = p_permiso;
            Imagen = p_image;
        }
        //TO STRING
        public override string ToString()
        {
            return "Correo: " + Correo + " Nombre: " + Nombre + " Permiso: "+Permiso; 
        }
    }
}
