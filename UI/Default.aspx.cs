using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades_Compartidas;
using Logica;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Usuario"] = null;
    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtMail.Text.Length == 0 || txtPass.Text.Length ==0)
                lblMensaje.Text = "Los campos no pueden estar Vacio";
            else
            {
                Usuario u = Fabrica.GetLU().Logueo(txtMail.Text, txtPass.Text);
                if (u == null)
                    lblMensaje.Text = "usuario no encontrado";
                else
                {
                    Session["Usuario"] = u;
                    Response.Redirect("Pruebas.aspx");
                }
            }

        }
        catch (Exception)
        {

            throw;
        }
        
    }
}