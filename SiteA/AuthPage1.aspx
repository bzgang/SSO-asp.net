﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuthPage1.aspx.cs" Inherits="SSO.SiteA.AuthPage1" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>welcome to www.a.com !</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width:900px;">
        <div style="float:left;width:880px;font-size:18px;font-weight:bold;padding:10px;background-color:#eb7018;color:white;text-align:center;">
            欢迎来到 www.a.com | 
            <a href="http://www.b.com">www.b.com</a> | 
            <a href="http://www.c.com">www.c.com</a>
        </div>

        <div style="float:left;width:100%;height:30px;margin-top:20px;margin-bottom:20px;">
            <div style="float:left;width:100%;margin-bottom:20px;">该页面为授权访问页</div>
            <div style="float:left;width:100%;">
                <asp:Button ID="btnLogout" runat="server" Height="30px" OnClick="btnLogout_Click" Text="注销登录" Width="100px" OnClientClick="return confirm('您确认清空主站令牌以及各分站凭证吗？');" />
            </div>
        </div>
    </div>

    </form>
</body>
</html>
