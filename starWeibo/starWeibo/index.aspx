<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="starweibo.index" %>

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
        <asp:Repeater runat="server" ID="rptblogInfoList">
            <ItemTemplate>
                <li><%# Eval("blogContent")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptchatInfoList">
            <ItemTemplate>
                <li><%# Eval("msgContent")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptmessageInfoList">
            <ItemTemplate>
                <li><%# Eval("messageId")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptphotoGroupInfoList">
            <ItemTemplate>
                <li><%# Eval("id")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptphotosList">
            <ItemTemplate>
                <li><%# Eval("imgPath")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptpowerInfoList">
            <ItemTemplate>
                <li><%# Eval("fasong")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptrelationGroupInfoList">
            <ItemTemplate>
                <li><%# Eval("sortLevel")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptrelationInfoList">
            <ItemTemplate>
                <li><%# Eval("friendNoteName")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rpttypeDicList">
            <ItemTemplate>
                <li><%# Eval("typeName")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rptuserInfoList">
            <ItemTemplate>
                <li><%# Eval("userMarry")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpatVList">
            <ItemTemplate>
                <li><%# Eval("blogContent")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpchatVList">
            <ItemTemplate>
                <li><%# Eval("userName")%>对<%# Eval("recuserName") %>说：<%# Eval("msgContent")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpCollectionVList">
            <ItemTemplate>
                <li>你收藏了<%# Eval("userName")%>的这条微博：<%# Eval("blogContent") %></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpfocusVList">
            <ItemTemplate>
                <li>你关注了<%# Eval("userName")%>并把他放到了<%# Eval("groupName") %></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpreplyVList">
            <ItemTemplate>
                <li><%# Eval("userName")%>评论了你的这条微博：<%# Eval("blogContent") %></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpreportVList">
            <ItemTemplate>
                <li><%# Eval("userName")%>举报了<%# Eval("bloguserName") %>的这条微博：<%# Eval("blogContent")%></li>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Repeater runat="server" ID="rtpzanVList">
            <ItemTemplate>
                <li><%# Eval("userName")%>赞了你的这条微博：<%# Eval("blogContent") %></li>
            </ItemTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>
