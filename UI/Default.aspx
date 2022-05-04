<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section class="vh-100 gradient-custom">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">

              <h2 class="fw-bold mb-2 ">Iniciar Sesion</h2>
              <p class="text-white-50 mb-5">Ingrese Correo y Contraseña</p>

              <div class="form-outline form-white mb-4">
                <%--<input type="email" id="typeEmailX" class="form-control form-control-lg" placeholder="Correo" />--%>
                  <asp:TextBox ID="txtMail" runat="server" class="form-control form-control-lg" placeholder="Mail"></asp:TextBox>
                <label class="form-label" for="typeEmailX"></label>
              </div>

              <div class="form-outline form-white mb-4">
                <%--  <asp:TextBox ID="txtpass" runat="server"placeholder="Contraseña"class="form-control form-control-lg" type="password" ></asp:TextBox>--%>
                 <%-- <asp:TextBox ID="TextBox1" runat="server"</asp:TextBox>--%>
                  <asp:TextBox ID="txtPass" runat="server" TextMode="Password" class="form-control form-control-lg" placeholder="Password"></asp:TextBox>
                <%--<input type="password" id="typePasswordX" class="form-control form-control-lg"   />--%>
                <label class="form-label" for="typePasswordX"></label>
              </div>

              <p class="small mb-5 pb-lg-2"><a class="text-white-50" href="#!">Forgot password?</a></p>

              <%--<button class="btn btn-outline-light btn-lg px-5" type="submit">Login</button>--%>
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-outline-light btn-lg px-5" OnClick="btnIngresar_Click" />

              <div class="d-flex justify-content-center text-center mt-4 pt-1">
                <a href="#!" class="text-white"><i class="fab fa-facebook-f fa-lg"></i></a>
                <a href="#!" class="text-white"><i class="fab fa-twitter fa-lg mx-4 px-2"></i></a>
                <a href="#!" class="text-white"><i class="fab fa-google fa-lg"></i></a>
              </div>

            </div>

            <div>
                <asp:Label ID="lblMensaje" runat="server" Text="Label"></asp:Label>
              <%--<p class="mb-0">Don't have an account? <a href="#!" class="text-white-50 fw-bold">Sign Up</a>--%>
             <%-- </p>--%>
            </div>

          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    <div>
    
    </div>
    </form>
</body>
</html>
