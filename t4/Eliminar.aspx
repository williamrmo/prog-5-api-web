<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="t4.Eliminar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form class="container" id="form1" runat="server">
           <h1>
               <asp:Label ID="Label1" runat="server" Text="Modulo de eliminar mercaderia"></asp:Label>
           </h1>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Codigo del producto que desea eliminar:"></asp:Label>
        <br />
        <asp:TextBox ID="Txtcod" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button CssClass="btn btn-danger" ID="BtnEliminar" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar Producto:" />
        <br /><br />
        <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
        <br />
    </form>
</body>
</html>
