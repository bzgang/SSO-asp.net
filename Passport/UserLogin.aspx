<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="SSO.Passport.UserLogin" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Home</title>
    <!-- Custom Theme files -->
    <link href="css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!-- Custom Theme files -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="login">
                <h2>用户登陆</h2>
                <div class="login-top">

                    <h1>登陆页面</h1>

                    <div>
                        用户名：
                        <asp:TextBox ID="txtAccount" runat="server" Text="admin" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'User Id';}"></asp:TextBox><br />
                    </div>
                    <div>
                        密 &nbsp; 码：
                    <asp:TextBox ID="txtPassport" runat="server" type="password" Text="admin" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'password';}"></asp:TextBox><br />
                    </div>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>

                    <div class="forgot">
                        <a href="CacheList.aspx?backurl=<%= Request.QueryString["backurl"] != null ? Request.QueryString["backurl"].ToString() : "" %>">查看缓存</a>
                        <a href="#">忘记密码</a>
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="登 陆" />
                    </div>
                </div>
                <div class="login-bottom">
                    <h3>新用户 &nbsp;<a href="#">注册</a>&nbsp</h3>
                </div>
            </div>
            <div class="copyright">
                <p>&copy; 版权所有<a target="_blank" href="#">友情链接</a></p>
            </div>
        </div>
    </form>
</body>
</html>