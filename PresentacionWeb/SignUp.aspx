<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="PresentacionWeb.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Registrarse</title>

    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/Custom-Cs.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="Default.aspx"><span><img alt="Logo" src="images/Logo Surticasa.png" height="30" /></span> SurtiCasa</a>
                </div>
                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li><a href="Default.aspx">Inicio</a></li>
                        <li><a href="#">Acerca de</a></li>
                        <li><a href="#">Contacto</a></li>
                        <li><a href="SignIn.aspx">Iniciar Sesión</a></li>
                        <li class="active"><a href="SignUp.aspx">Registrarse</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
        <div class="container">
        <div class="form-horizontal"; style="width:300px; margin:auto;">
            <h2>Registrarse</h2>
                <hr />
        <!-- Sign Up -->
            <div class="form-group">
                <label class="col-xs-11">Nombre de Usuario</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbUname" runat="server" CssClass="form-control" placeholder="Nombre de usuario"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">Contraseña</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbPass" runat="server" TextMode="Password" CssClass="form-control" placeholder="Contraseña"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">Confirme contraseña</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbCPass" runat="server" TextMode="Password" class="form-control" placeholder="Confirme contraseña"></asp:TextBox>
                </div>
            </div>
            
            <div class="form-group">
                <label class="col-xs-11">Nombre</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbName" runat="server" class="form-control" placeholder="Nombre"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">Apellido</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbLName" runat="server" class="form-control" placeholder="Apellido"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">Dirección</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbAddress" runat="server" class="form-control" placeholder="Dirección"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">Teléfono</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbPhone" runat="server" class="form-control" placeholder="Teléfono"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">NIT</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbNit" runat="server" class="form-control" placeholder="NIT"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <label class="col-xs-11">Codigo Mayorista</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="tbMayorista" runat="server" class="form-control" placeholder="Codigo Mayorista"></asp:TextBox>
                </div>
            </div>

            <div class="col-xs-11 space-vert">
                <asp:Button ID="btAddUser" runat="server" class="btn btn-success" Text="Agregar" OnClick="btAddUser_Click1" />
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </div>

        </div>
        </div>
    <!-- Footer -->
    </form>
        <hr />
        <footer>
            <div class="container">
                <p class="pull-right"><a href="#">Regresar arriba</a></p>
                <p>&copy; 2016 SurtiCasa &middot; <a href="Default.aspx">Inicio</a>&middot;<a href="#">Acerca de</a></p>
            </div>
        </footer>

        <!--- Footer -->

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
