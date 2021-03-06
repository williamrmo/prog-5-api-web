<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="t4.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <br>
    <form class="container" id="form1" runat="server">
        <h1>Login</h1>
    <br>
        <asp:Label ID="Label1" runat="server" Text="Nick:"></asp:Label><br />
        <asp:TextBox ID="TXTNick" runat="server" MinLength="1" MaxLength="50" required ></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label><br />
        <asp:TextBox type="password" ID="TXTPass" runat="server" MinLength="1" MaxLength="15" required></asp:TextBox>
        <br /><br />
        <asp:Button class="btn btn-primary" ID="BTNLOGIN" runat="server" OnClick="BTNLOGIN_Click" Text="LOGIN" />
        <br /><br />
        <asp:Label class="alert alert-danger"  ID="lbError" runat="server" Text="Usuario y/o contraseña incorrectos."></asp:Label>
    </form>
    <div class="container">
        <br />
        <button class="btn btn-primary">
            <a style="color:white; text-decoration:none;" href="Registrarse.aspx">Crear Usuario</a>
        </button>
    </div>
    
</body>
</html>
