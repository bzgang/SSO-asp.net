using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;

namespace SSO.SiteA.Class
{
    /// <summary>
    /// 授权页面基类，所有需要授权的页面继承该类即可。
    /// </summary>
    public class AuthBase : System.Web.UI.Page
    {


        protected override void OnLoad(EventArgs e)
        {
            if (Session["A.Cert"] != null)
            {
                //分站凭证存在
                Response.Write("恭喜，分站凭证存在，您被授权访问该页面！");
            }
            else
            {
                //令牌验证结果返回
                if (Request.QueryString["token"] != null)
                {
                    //持有令牌
                    string tokenValue = Request.QueryString["token"];
                    //调用WebService获取主站凭证
                    //防止令牌伪造
                    //此处还可使用公钥私钥的非对称加密策略
                    SSO.SiteA.ServiceReference1.PassportServiceSoapClient passportService = new SSO.SiteA.ServiceReference1.PassportServiceSoapClient();
                    // object cert = passportService.TokenGetCert(tokenValue);
                    object cert = passportService.TokenGetDbTokenActive(tokenValue);
                    if (cert != null && (bool)cert == true)
                    {
                        //令牌正确
                        Session["A.Cert"] = cert;
                        Response.Write("恭喜，令牌存在，您被授权访问该页面！");
                    }
                    else
                    {
                        //令牌错误，去Passport登录
                        Response.Redirect(GetTokenforLogin());
                    }

                }
                //未进行令牌验证，去Passport验证
                else
                {
                    Response.Redirect(GetTokenforLogin());
                }
            }

            base.OnLoad(e);
        }

        /// <summary>
        /// 回去带回返回页面的登陆站点信息
        /// </summary>
        /// <returns>返回去掉token信息的地址</returns>
        public string GetTokenforLogin()
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            url = Regex.Replace(url, @"(\?|&)Token=.*", "", RegexOptions.IgnoreCase); //删除token信息
            //返回到登陆页面
            string ssoLogin = System.Configuration.ConfigurationManager.AppSettings["SSOLogin"];
            return ssoLogin + "?backurl=" + System.Web.HttpUtility.UrlEncode(url);
        }
    }
}
