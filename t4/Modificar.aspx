<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="t4.Modificar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form class="container" id="form1" runat="server">
        <br />
        <h1>Modificar</h1>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Codigo:"></asp:Label><br />
        <asp:TextBox ID="TXTCOD" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label><br />
        <asp:TextBox ID="TXTnombre" runat="server" MinLength="1" MaxLength="50" required></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cantidad:"></asp:Label><br />
        <asp:TextBox  Type="number" ID="TXTCantidad" runat="server" MinLength="1" MaxLength="50" required></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Bodega:"></asp:Label><br />
        <asp:TextBox ID="TXTbodega" runat="server" MinLength="1" MaxLength="50" required></asp:TextBox>
        <br />
        <br />
        <asp:Button class="btn btn-primary" ID="Btnmodificar" runat="server" OnClick="Btnmodificar_Click" Text="Modificar" />
        <asp:Button class="btn btn-danger" ID="Btnvolver" runat="server" Text="Volver" OnClick="Btnvolver_Click" />
        <br />
    </form>
</body>
</html>
