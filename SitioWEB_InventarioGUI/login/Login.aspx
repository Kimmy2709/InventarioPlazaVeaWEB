<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SitioWEB_InventarioGUI.login.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inventario Plaza Vea</title>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="" />
    <link href="https://fonts.googleapis.com/css2?family=Cutive+Mono&family=PT+Serif:ital,wght@0,400;0,700;1,400;1,700&display=swap" rel="stylesheet"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css"/>
    <link href="/CSS/DemoCSS.css" rel="stylesheet" type="text/css" />
    <link href="~/lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin="" />
<link href="https://fonts.googleapis.com/css2?family=Lora:wght@700&display=swap" rel="stylesheet"/>
    <style>
        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
        body {
            background-image: url(../Images/fondo.jpg);
            background-size: cover;
            position: relative;
            overflow: hidden; /* Para evitar barras de desplazamiento */
        }
        h3{
            text-align:center;
            font-family: 'Lora', serif;
        }
        .overlay-personalized {
            position: absolute;
            top: 0;
            left: 0;
            height: 100%;
            width: 100%;
            background-color: rgba(0, 0, 0, 0.5);
            display: flex;
            flex-direction: column;
            justify-content: center;
        }
        .formulario-container{
            display: flex;
            justify-content: center;
        }
        .formulario{
            background-color: #ffffff;
            padding: 50px 70px;
            border-radius: 30px;
            position: relative;
        }
        .form-control {
            display: block;
            width: 280px;
            padding: 0.375rem 0.75rem;
            font-size: 1rem;
            font-weight: 400;
            line-height: 1.5;
            color: var(--bs-body-color);
            background-color: var(--bs-body-bg);
            background-clip: padding-box;
            border: var(--bs-border-width) solid var(--bs-border-color);
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            border-radius: var(--bs-border-radius);
            transition: border-color 0.15s ease-in-out, box-shadow 0.15s ease-in-out;
        }
        .btn-login{
            margin-top: 15px;
            border-radius: 0!important;
            width: 100%!important;
            margin-bottom: 30px;
        }
        .img-user{
            position: absolute;
            top: -50px;
        }
        .img-container{
            display: flex;
            justify-content: center;
            margin-bottom: 15px;
        }
    </style>
</head>
<body>
    <div class="overlay-personalized">
       <div class="formulario-container">
           <div class="formulario">
                <div class="img-container">
                    <img height="80px" class="img-user" src="../Images/user.png"></img>
                </div>
                <h3>Bienvenido de nuevo</h3><br />
                <form id="login" runat="server">
                    <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Usuario</label>
                        <asp:TextBox ID="txtUsuario" runat="server" class="form-control"></asp:TextBox>
                         <asp:Label ID="lblErrorUs" runat="server" class="form-text"></asp:Label>
                       
                    </div>
                    <div class="mb-3">
                        <label for="exampleInputPassword1" class="form-label">Contraseña</label>
                        <asp:TextBox ID="txtPassword" runat="server" type="password" class="form-control"></asp:TextBox>
                         <asp:Label ID="lblErrorPass" runat="server" class="form-text"></asp:Label>
                    </div>
                    <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="btn btn-primary btn-login" OnClick="btnIngresar_Click" />
                </form>
            </div>
        </div>
    </div>
</body>
</html>