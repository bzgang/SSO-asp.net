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

namespace SSO.SiteA
{
    /// <summary>
    /// �˳�
    /// </summary>
    public partial class Quit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //�����վ����
            if (Request.QueryString["token"] == null)
            {
                //��ȡ����
                Response.Redirect("http://localhost:800/gettoken.aspx?backurl=" + Server.UrlEncode(Request.Url.AbsoluteUri + "?token=$token$"));
            }
            else
            {
                if (Request.QueryString["token"] != "$token$")
                {
                    string token = Request.QueryString["token"];
                    //����WebService����
                    SSO.SiteA.ServiceReference1.PassportServiceSoapClient passportService = new SSO.SiteA.ServiceReference1.PassportServiceSoapClient();
                    passportService.TokenClear(token);
                }
            }
        }

    }//end class
}
