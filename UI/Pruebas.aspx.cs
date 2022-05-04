using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades_Compartidas;
using System.Drawing;
using Logica;

public partial class Pruebas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {

            int tamanio = fuImagen.PostedFile.ContentLength;
            byte[] ImagenOriginal = new byte[tamanio];

            fuImagen.PostedFile.InputStream.Read(ImagenOriginal, 0, tamanio);
            Bitmap ImagenOriginalBinaria = new Bitmap(fuImagen.PostedFile.InputStream);
            string imagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(ImagenOriginal);

            ImgPre.ImageUrl = imagenDataURL64;
            Usuario u = new Usuario("gustavo.ceballos.2008@gmail.com", "manchas1", "Gustavo Ceballos", 1, ImagenOriginal);

            Fabrica.GetLU().AgregarUsuario(u);
            lblMensaje.Text = "ususario agregado";

        }
        catch (Exception ex)
        {
            lblMensaje.Text = "exploto";
            throw;
        }
    }
}