<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Udemy2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ListaCursos" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem Value="1">ASP.NET</asp:ListItem>
                <asp:ListItem Value="2">Android</asp:ListItem>
                <asp:ListItem Value="3">C#</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="LabelCursos" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple">
            <asp:ListItem Value="1">Dog</asp:ListItem>
            <asp:ListItem Value="4">Cow</asp:ListItem>
        </asp:ListBox>
        <asp:Button ID="Button3" runat="server" Text="Animais selecionados?" OnClick="Button3_Click" />
        <asp:TextBox ID="tbSelecionados" runat="server" AutoPostBack="True" Width="268px"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="familia" runat="server" Height="46px">
        </asp:DropDownList>
    </form>
</body>
</html>
