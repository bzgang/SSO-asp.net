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
using SSO.Passport.Class;

namespace SSO.Passport
{
    /// <summary>
    /// �û���¼
    /// ����Get������BackURL
    /// </summary>
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["backurl"] == null)
                {
                    //   Response.Write("�������������ӷ�վ���е�¼����ֱ�ӷ��ʸ�ҳ�棡");
                    lblMsg.Text = "�������������ӷ�վ���е�¼����ֱ�ӷ��ʸ�ҳ�棡";
                    //  Response.End();
                }
            }
        }

        DbTonkenLoginManager dbToken = new DbTonkenLoginManager();
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string ipPath = HttpContext.Current.Request.UserHostAddress;
            string browser = HttpContext.Current.Request.Browser.Type;

            //�����û���¼��֤(�ʺš�������web.config��)
            //��ʵ�����˴�Ӧͨ�����ݿ������֤
            if ((this.txtAccount.Text.Trim() == System.Configuration.ConfigurationManager.AppSettings["Account"] &&
                this.txtPassport.Text.Trim() == System.Configuration.ConfigurationManager.AppSettings["Password"]) || System.Configuration.ConfigurationManager.AppSettings["isVerification"].ToLower() == "false")
            {
                string tokenValue = Guid.NewGuid().ToString().ToUpper();

                //������վƾ֤--���浽������-�ɸ���ʵ����Ҫ���޸�ƾ֤��Ϣ�����ݿ���
                object cert = true;
                DateTime outTime = DateTime.Now.AddMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"]));
                #region �����������û���½��Ϣ
                CacheManager.TokenInsert(this.txtAccount.Text.Trim(),
                           tokenValue,
                           cert,
                           DateTime.Now.AddMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"])));
                #endregion

                #region ���ݿⷽʽ��¼��½��Ϣ
                Models.userLoginToken userToken = new Models.userLoginToken();
                userToken.userAccount = this.txtAccount.Text.Trim();
                userToken.token = tokenValue;
                userToken.isActive = true;
                userToken.ExtDatetime = outTime;
                userToken.ipPath = ipPath;
                userToken.browser = browser;
                dbToken.addUserToken(userToken);
                #endregion

                //��������
                //HttpCookie tokenCookie = new HttpCookie("Passport.Token");
                //// tokenCookie.Domain = "passport.com";
                ////��ʹ���Զ����㷨����Cookie�Ƿ�����
                ////tokenCookie.Values.Add("Key", "�����㷨");
                //tokenCookie.Values.Add("Value", tokenValue);
                //Response.AppendCookie(tokenCookie);

                //��ת�ط�վ
                if (Request.QueryString["backurl"] != null)
                    Response.Redirect(Server.UrlDecode(Request.QueryString["backurl"] + "?token=" + tokenValue));
            }
            else
            {
                Response.Write("��Ǹ���ʺŻ�������������Web.config�������ʺ����룡");
            }
        }

    }
}
