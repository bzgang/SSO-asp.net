using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace SSO.Passport
{
    /// <summary>
    /// 获取令牌并以URL参数方式返回
    /// 
    /// token = tokenValue
    /// </summary>
    public partial class GetToken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["backurl"] != null)
            {
                string backURL = Server.UrlDecode(Request.QueryString["backurl"]);

                //获取Cookie
                HttpCookie tokenCookie = Request.Cookies["Passport.Token"];
                if (tokenCookie != null)
                {
                    backURL = backURL.Replace("$token$", tokenCookie.Values["Value"].ToString());
                }

                Response.Redirect(backURL);
            }
        }

    }//end class
}
