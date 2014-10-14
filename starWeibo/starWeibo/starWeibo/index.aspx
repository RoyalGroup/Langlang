<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="starWeibo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Repeater runat="server" ID="rtpadminList">
            <ItemTemplate>
                <li><%# Eval("adminName")%></li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
