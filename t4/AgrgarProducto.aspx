<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgrgarProducto.aspx.cs" Inherits="t4.AgrgarProducto" %>

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
            <asp:Label ID="Label1" runat="server" Text="Agregar nuevo producto"></asp:Label>
        </h1>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Codigo del producto:" ></asp:Label>
        <br />
        <asp:TextBox ID="TXTCod" runat="server" MinLength="1" MaxLength="15" required></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="Nombre del Producto:"></asp:Label>
        <br />
        <asp:TextBox ID="TXTNombre" runat="server" MinLength="1" MaxLength="50" required></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Cantidad de objetos:"></asp:Label>
        <br />
        <asp:TextBox Type="number" ID="TXTCantidad" runat="server" MinLength="1" MaxLength="50" required></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Bodega en la cual se almacena:"></asp:Label>
        <br />
        <asp:TextBox ID="TXTBodega" runat="server" MinLength="1" MaxLength="100" required></asp:TextBox>
        <br />
        <br />
        <asp:Button CssClass="btn btn-success" ID="BTNAgregar" runat="server" OnClick="BTNAgregar_Click" Text="Agregar Producto" />
        <br /><br />
        <asp:Label class="alert alert-danger"  ID="lbError" runat="server" Text="El producto no se pudo registrar"></asp:Label>
        <asp:Label class="alert alert-success"  ID="lbSuccess" runat="server" Text="Producto registrado con exito"></asp:Label>
    </form>

    <div class="container">
        
        <br />
        <button class="btn btn-primary">
            <a style="color:white; text-decoration:none;" href="Menu.aspx">Volver</a>
        </button>
    </div>
</body>
</html>
