<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carga.aspx.cs" Inherits="Obligatorio2.Carga" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 163px">
            <asp:Button ID="Button2" runat="server" Text="Atras" OnClick="Atras_Click" />
            <br/>
            Nombre
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <br/>
            Apellido
            <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
            <br/>
            Telefono
            <asp:TextBox ID="TextBox3" runat="server"  pattern="[0-9,+]{0,20}"></asp:TextBox>
            <br/>
            Descripcion
            <asp:TextBox ID="TextBox4" runat="server"  TextMode="MultiLine" ></asp:TextBox>
            <br/>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br/>
            <asp:Button ID="Button1" runat="server" Text="Cargar" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
