<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PresentacionWeb.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>SurtiCasa</title>

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
                        <li class="active"><a href="Default.aspx">Inicio</a></li>
                        <li><a href="#">Acerca de</a></li>
                        <li><a href="#">Contacto</a></li>
                        <li><a href="SignIn.aspx">Iniciar Sesión</a></li>
                        <li><a href="SignUp.aspx">Registrarse</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>

<!--- Carousel -->

  <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
  <!-- Indicators -->
  <ol class="carousel-indicators">
      <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
      <li data-target="#carousel-example-generic" data-slide-to="1"></li>
      <li data-target="#carousel-example-generic" data-slide-to="2"></li>
      <li data-target="#carousel-example-generic" data-slide-to="3"></li>
      <li data-target="#carousel-example-generic" data-slide-to="4"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
      <img class="img-responsive center-block" src="images/1.jpeg" alt="..."/>
      <div class="carousel-caption">
       <h3>Surticasa</h3>
    <p>De todo para tu casa</p>
          <p><a class="btn btn-lg btn-primary" href="SignIn.aspx" role="button">Inicia sesión</a></p>
      </div>
    </div>
    <div class="item">
      <img class="img-responsive center-block" src="images/2.jpg" alt="..."/>
      <div class="carousel-caption">
        <h3>Surticasa</h3>
    <p>De todo para tu casa</p>
          <p><a class="btn btn-lg btn-primary" href="SignIn.aspx" role="button">Inicia sesión</a></p>
      </div>
    </div>
    <div class="item">
      <img class="img-responsive center-block" src="images/3.jpg" alt="..."/>
      <div class="carousel-caption">
        <h3>Surticasa</h3>
    <p>De todo para tu casa</p>
          <p><a class="btn btn-lg btn-primary" href="SignIn.aspx" role="button">Inicia sesión</a></p>
      </div>
    </div>
      <div class="item">
          <img class="img-responsive center-block" src="images/4.jpg" alt="..."/>
          <div class="carousel-caption">
            <h3>Surticasa</h3>
        <p>De todo para tu casa</p>
              <p><a class="btn btn-lg btn-primary" href="SignIn.aspx" role="button">Inicia sesión</a></p>
          </div>
      </div>
      <div class="item">
          <img class="img-responsive center-block" src="images/5.jpg" alt="..."/>
          <div class="carousel-caption">
            <h3>Surticasa</h3>
        <p>De todo para tu casa</p>
              <p><a class="btn btn-lg btn-primary" href="SignIn.aspx" role="button">Inicia sesión</a></p>
          </div>
      </div>
  </div>

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
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