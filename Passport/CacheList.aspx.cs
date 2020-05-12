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
    public partial class CacheList : System.Web.UI.Page
    {
        DbTonkenLoginManager dbToken = new DbTonkenLoginManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                #region 获取缓存的登陆信息
                DataTable dt = Passport.Class.CacheManager.GetCacheTable();
                if (dt != null)
                {
                    this.gv.DataSource = dt;
                    this.gv.DataBind();
                }
                #endregion

                #region 获取数据库的登陆信息
                DataTable dtDB = dbToken.GetTokenTable();
                if (dtDB != null)
                {
                    this.gvDB.DataSource = dtDB;
                    this.gvDB.DataBind();
                }
                #endregion
            }
        }
    }
}
