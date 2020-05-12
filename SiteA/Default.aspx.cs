using SSO.SiteA.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SSO.SiteA
{
    public partial class Default : AuthBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 退出登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["token"] != null)
            {
                Session.Abandon();
                string token = Request.QueryString["token"];
                //创建WebService对象
                SSO.SiteA.ServiceReference1.PassportServiceSoapClient passportService = new SSO.SiteA.ServiceReference1.PassportServiceSoapClient();
                passportService.TokenClear(token);
                string url = HttpContext.Current.Request.Url.AbsoluteUri;
                url = Regex.Replace(url, @"(\?|&)Token=.*", "", RegexOptions.IgnoreCase);
                //返回到登陆页面
                string ssoLogin = System.Configuration.ConfigurationManager.AppSettings["SSOLogin"];
                Response.Redirect(ssoLogin + "?backurl=" + System.Web.HttpUtility.UrlEncode(url));
            }
        }
    }
}