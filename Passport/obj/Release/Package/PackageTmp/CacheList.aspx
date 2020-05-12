<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheList.aspx.cs" Inherits="SSO.Passport.CacheList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>www.passport.com</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 900px;">
            <div style="float: left; width: 880px; font-size: 18px; font-weight: bold; padding: 10px; background-color: #006ebe; color: white; text-align: center;">
                欢迎来到www.passport.com服务器
            </div>

            <div style="float: left; width: 100%; height: 30px; margin-top: 20px; margin-bottom: 20px;">
                <div style="float: left; width: 100px;"><a href="UserLogin.aspx?backurl=<%= Request.QueryString["backurl"] != null ? Request.QueryString["backurl"].ToString() : "" %>">用户登录</a></div>
                <div style="float: left; width: 100px; font-weight: bold;">查看缓存</div>
            </div>

            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="用户信息">
                        <ItemTemplate>
                            <%# Eval("userAccount").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="令牌">
                        <ItemTemplate>
                            <%# Eval("token").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="凭证">
                        <ItemTemplate>
                            <%# Eval("cert").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="过期时间">
                        <ItemTemplate>
                            <%# Eval("timeout").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <br />
            <h1>数据库登陆信息</h1>
            <asp:GridView ID="gvDB" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="用户信息">
                        <ItemTemplate>
                            <%# Eval("userAccount").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="令牌">
                        <ItemTemplate>
                            <%# Eval("token").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="凭证">
                        <ItemTemplate>
                            <%# Eval("isActive").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="过期时间">
                        <ItemTemplate>
                            <%# Eval("ExtDatetime").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="登陆IP">
                        <ItemTemplate>
                            <%# Eval("ipPath").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="登陆浏览器">
                        <ItemTemplate>
                            <%# Eval("browser").ToString() %>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>



    </form>
</body>
</html>
