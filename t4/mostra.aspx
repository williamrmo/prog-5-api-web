<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mostra.aspx.cs" Inherits="t4.mostra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Mostrar productos</h1>
            <br />
            <asp:GridView class="table" ID="GridView1" runat="server" 
                AutoGenerateDeleteButton="true" OnRowDeleting="GridView1_RowDeleting" 
                AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >

            </asp:GridView>
            <br />
            <br />
            <asp:Button class="btn btn-primary" ID="Button1" runat="server" OnClick="Button1_Click" Text="Volver" />
        </div>
    </form>
    </body>
</html>
