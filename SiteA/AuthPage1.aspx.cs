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
    /// �̳�AuthBase���ʾ��ҳ����Ȩ���ʲ�ʹ��SSO
    /// </summary>
    public partial class AuthPage1 : Class.AuthBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("quit.aspx");
        }
    }
}
