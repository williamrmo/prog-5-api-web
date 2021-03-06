<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="t4.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="css/bootstrap.min.css" rel="stylesheet" />

	</style>
</head>
<body>
    <form class="container" id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="MODULO DE ADMINISTRACION DE MERCADERIA"></asp:Label></h1>
        </div>
        <br /><br />
        <asp:Button CssClass="btn btn-primary" ID="BTNAgregar" runat="server" OnClick="BTNAgregar_Click" Text="Agregar nuevos productos" />
        <br /><br />
        <asp:Button CssClass="btn btn-primary" ID="BTNMostrar" runat="server" OnClick="BTNMostrar_Click" Text="Mostrar todos lo productos" />
        <br /><br />
        <asp:Button CssClass="btn btn-primary" ID="BtnEliminar" runat="server" OnClick="BtnEliminar_Click" Text="Eliminar productos" />
        <br /><br />
        <asp:Button CssClass="btn btn-danger" ID="BTNCerrar" runat="server" OnClick="BTNCerrar_Click" Text="Cerrar Sesion" />
    </form>
</body>
</html>
