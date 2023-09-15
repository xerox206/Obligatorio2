<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Obligatorio2.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Carga.aspx">Cargar</asp:HyperLink>
            <br/>
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Lectura.aspx">Consultar</asp:HyperLink>
        </div>
    </form>
</body>
</html>
