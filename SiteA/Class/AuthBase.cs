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
    /// ��Ȩҳ����࣬������Ҫ��Ȩ��ҳ��̳и��༴�ɡ�
    /// </summary>
    public class AuthBase : System.Web.UI.Page
    {


        protected override void OnLoad(EventArgs e)
        {
            if (Session["A.Cert"] != null)
            {
                //��վƾ֤����
                Response.Write("��ϲ����վƾ֤���ڣ�������Ȩ���ʸ�ҳ�棡");
            }
            else
            {
                //������֤�������
                if (Request.QueryString["token"] != null)
                {
                    //��������
                    string tokenValue = Request.QueryString["token"];
                    //����WebService��ȡ��վƾ֤
                    //��ֹ����α��
                    //�˴�����ʹ�ù�Կ˽Կ�ķǶԳƼ��ܲ���
                    SSO.SiteA.ServiceReference1.PassportServiceSoapClient passportService = new SSO.SiteA.ServiceReference1.PassportServiceSoapClient();
                    // object cert = passportService.TokenGetCert(tokenValue);
                    object cert = passportService.TokenGetDbTokenActive(tokenValue);
                    if (cert != null && (bool)cert == true)
                    {
                        //������ȷ
                        Session["A.Cert"] = cert;
                        Response.Write("��ϲ�����ƴ��ڣ�������Ȩ���ʸ�ҳ�棡");
                    }
                    else
                    {
                        //���ƴ���ȥPassport��¼
                        Response.Redirect(GetTokenforLogin());
                    }

                }
                //δ����������֤��ȥPassport��֤
                else
                {
                    Response.Redirect(GetTokenforLogin());
                }
            }

            base.OnLoad(e);
        }

        /// <summary>
        /// ��ȥ���ط���ҳ��ĵ�½վ����Ϣ
        /// </summary>
        /// <returns>����ȥ��token��Ϣ�ĵ�ַ</returns>
        public string GetTokenforLogin()
        {
            string url = HttpContext.Current.Request.Url.AbsoluteUri;
            url = Regex.Replace(url, @"(\?|&)Token=.*", "", RegexOptions.IgnoreCase); //ɾ��token��Ϣ
            //���ص���½ҳ��
            string ssoLogin = System.Configuration.ConfigurationManager.AppSettings["SSOLogin"];
            return ssoLogin + "?backurl=" + System.Web.HttpUtility.UrlEncode(url);
        }
    }
}
