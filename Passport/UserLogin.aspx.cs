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
    /// 用户登录
    /// 接收Get参数：BackURL
    /// </summary>
    public partial class UserLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                if (Request.QueryString["backurl"] == null)
                {
                    //   Response.Write("请求参数有误，请从分站进行登录，勿直接访问该页面！");
                    lblMsg.Text = "请求参数有误，请从分站进行登录，勿直接访问该页面！";
                    //  Response.End();
                }
            }
        }

        DbTonkenLoginManager dbToken = new DbTonkenLoginManager();
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string ipPath = HttpContext.Current.Request.UserHostAddress;
            string browser = HttpContext.Current.Request.Browser.Type;

            //摸拟用户登录验证(帐号、密码于web.config中)
            //真实环境此处应通过数据库进行验证
            if ((this.txtAccount.Text.Trim() == System.Configuration.ConfigurationManager.AppSettings["Account"] &&
                this.txtPassport.Text.Trim() == System.Configuration.ConfigurationManager.AppSettings["Password"]) || System.Configuration.ConfigurationManager.AppSettings["isVerification"].ToLower() == "false")
            {
                string tokenValue = Guid.NewGuid().ToString().ToUpper();

                //产生主站凭证--保存到缓存中-可根据实际需要，修改凭证信息到数据库中
                object cert = true;
                DateTime outTime = DateTime.Now.AddMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"]));
                #region 缓存中增加用户登陆信息
                CacheManager.TokenInsert(this.txtAccount.Text.Trim(),
                           tokenValue,
                           cert,
                           DateTime.Now.AddMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"])));
                #endregion

                #region 数据库方式记录登陆信息
                Models.userLoginToken userToken = new Models.userLoginToken();
                userToken.userAccount = this.txtAccount.Text.Trim();
                userToken.token = tokenValue;
                userToken.isActive = true;
                userToken.ExtDatetime = outTime;
                userToken.ipPath = ipPath;
                userToken.browser = browser;
                dbToken.addUserToken(userToken);
                #endregion

                //产生令牌
                //HttpCookie tokenCookie = new HttpCookie("Passport.Token");
                //// tokenCookie.Domain = "passport.com";
                ////可使用自定义算法避免Cookie非法复制
                ////tokenCookie.Values.Add("Key", "加密算法");
                //tokenCookie.Values.Add("Value", tokenValue);
                //Response.AppendCookie(tokenCookie);

                //跳转回分站
                if (Request.QueryString["backurl"] != null)
                    Response.Redirect(Server.UrlDecode(Request.QueryString["backurl"] + "?token=" + tokenValue));
            }
            else
            {
                Response.Write("抱歉，帐号或密码有误！请在Web.config中配置帐号密码！");
            }
        }

    }
}
