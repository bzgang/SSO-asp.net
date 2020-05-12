using SSO.Passport.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.Services;

namespace SSO.Passport
{
    /// <summary>
    /// 主站，提供令牌相关服务
    /// DEMO仅进行演示，正式布署请对接口添加安全验证
    /// </summary>
    [WebService(Namespace = "http://www.passport.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class PassportService : System.Web.Services.WebService
    {
        DbTonkenLoginManager dbToken = new DbTonkenLoginManager();
        /// <summary>
        /// 根据令牌获取用户凭证(获取缓存中的用户登陆状态)
        /// </summary>
        /// <param name="token">令牌</param>
        /// <returns></returns>
        [WebMethod]
        public object TokenGetCert(string token)
        {
            object cert = null;

            DataTable dt = Passport.Class.CacheManager.GetCacheTable();
            if (dt != null)
            {
                DataRow[] dr = dt.Select("token = '" + token + "'");
                if (dr.Length > 0)
                {
                    cert = dr[0]["cert"];
                }
            }

            return cert;
        }

        /// <summary>
        /// 获取数据库中的用户登陆状态
        /// </summary>
        /// <param name="token">令牌</param>
        /// <returns></returns>
        [WebMethod]
        public bool TokenGetDbTokenActive(string token)
        {
            bool active = dbToken.TokenIsExist(token);
            return active;
        }
        /// <summary>
        /// 清除令牌
        /// </summary>
        /// <param name="token">令牌</param>
        [WebMethod]
        public void TokenClear(string token)
        {
            #region 清理缓存中的登陆信息
            DataTable dt = Passport.Class.CacheManager.GetCacheTable();
            if (dt != null)
            {
                DataRow[] dr = dt.Select("token = '" + token + "'");
                if (dr.Length > 0)
                {
                    dt.Rows.Remove(dr[0]);
                }
            }
            #endregion

            #region 清理数据库中的登陆信息
            dbToken.delUserToken(token);
            #endregion
        }

    }
}
