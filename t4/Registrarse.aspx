<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="t4.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body style="height: 322px">
    <form class="container" id="form1" runat="server">
        <div>
                <h1>INGRSAR NUEVO USUARIO AL SISTEMA</h1>

            <asp:Label ID="Label1" runat="server" Text="Nombre:"></asp:Label><br />
            <asp:TextBox ID="TXTNOMBRE" runat="server"  MinLength="1" MaxLength="50" required></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Apellidos:"></asp:Label><br />
            <asp:TextBox ID="TXTAPELLIDOS" runat="server"  MinLength="1" MaxLength="50" required></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nick:"></asp:Label><br />
            <asp:TextBox ID="TXTNick" runat="server"  MinLength="1" MaxLength="50" required></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Contraseña:"></asp:Label><br />
            <asp:TextBox type="password" ID="TXTPass" runat="server"  MinLength="1" MaxLength="15" required value=" "></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-success" ID="BTNAutogenerar" runat="server" OnClick="BTNAutogenerar_Click" Text="Autogenerar Contraseña" />
            <br /><br />
            <asp:Button CssClass="btn btn-primary" ID="BTNRegistrarse" runat="server" OnClick="BTNRegistrarse_Click" Text="Registrarse" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="LBLResult" runat="server"></asp:Label>
            <%--<asp:Button CssClass="btn btn-primary" ID="BTNVolver" runat="server" OnClick="BTNVolver_Click" Text="Volver a la pagina principal" />--%>
            <br />
        </div>
    </form>
    <div class="container">
        <br />
        <button class="btn btn-primary">
            <a style="color:white; text-decoration:none;" href="Login.aspx">Iniciar sesion</a>
        </button>
    </div>
</body>
</html>
