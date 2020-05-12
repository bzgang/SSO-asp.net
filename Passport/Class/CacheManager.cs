using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace SSO.Passport.Class
{
    /// <summary>
    /// 缓存管理
    /// 将令牌、用户凭证以及过期时间的关系数据存放于Cache中
    /// 
    /// 吴剑 2009-06-24 创建
    /// 吴剑 2012-11-07 修改
    /// </summary>
    public class CacheManager
    {
        /// <summary>
        /// 初始化缓存数据结构
        /// </summary>
        /// <remarks>
        /// ----------------------------------------------------
        /// | 登陆用户信息 |token(令牌) | cert(用户凭证) | timeout(过期时间) |
        /// |--------------------------------------------------|
        /// </remarks>
        private static void cacheInit()
        {
            if (HttpContext.Current.Cache["PASSPORT.TOKEN"] == null)
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("userAccount", Type.GetType("System.String"));
               

                dt.Columns.Add("token", Type.GetType("System.String"));
                dt.Columns["token"].Unique = true;

                dt.Columns.Add("cert", Type.GetType("System.Object"));
                dt.Columns["cert"].DefaultValue = null;

                dt.Columns.Add("timeout", Type.GetType("System.DateTime"));
                dt.Columns["timeout"].DefaultValue = DateTime.Now.AddMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"]));

                DataColumn[] keys = new DataColumn[1];
                keys[0] = dt.Columns["token"];
                dt.PrimaryKey = keys;

                //Cache的过期时间为 令牌过期时间*2
                HttpContext.Current.Cache.Insert("PASSPORT.TOKEN", dt, null, DateTime.MaxValue, TimeSpan.FromMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"]) * 2));
            }
        }

        /// <summary>
        /// 获取缓存中的DataTable
        /// </summary>
        /// <returns></returns>
        public static DataTable GetCacheTable()
        {
            DataTable dt = null;
            if (HttpContext.Current.Cache["PASSPORT.TOKEN"] != null)
            {
                dt = (DataTable)HttpContext.Current.Cache["PASSPORT.TOKEN"];
            }
            return dt;
        }

        /// <summary>
        /// 判断令牌是否存在
        /// </summary>
        /// <param name="token">令牌</param>
        /// <returns></returns>
        public static bool TokenIsExist(string token)
        {
            cacheInit();

            DataTable dt = (DataTable)HttpContext.Current.Cache["PASSPORT.TOKEN"];
            if (dt.Select("token = '" + token + "'").Length == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 更新令牌过期时间
        /// </summary>
        /// <param name="token">令牌</param>
        /// <param name="time">过期时间</param>
        public static void TokenTimeUpdate(string token, DateTime time)
        {
            cacheInit();

            DataTable dt = (DataTable)HttpContext.Current.Cache["PASSPORT.TOKEN"];
            DataRow[] dr = dt.Select("token = '" + token + "'");
            if (dr.Length > 0)
            {
                dr[0]["timeout"] = time;
            }
        }

        /// <summary>
        /// 添加令牌
        /// </summary>
        /// <param name="userAccount">登陆用户</param>
        /// <param name="token">令牌</param>
        /// <param name="cert">凭证</param>
        /// <param name="timeout">过期时间</param>
        public static void TokenInsert(string userAccount, string token, object cert, DateTime timeout)
        {
            cacheInit();

            //token不存在则添加
            if (!TokenIsExist(token))
            {
                DataTable dt = (DataTable)HttpContext.Current.Cache["PASSPORT.TOKEN"];
                DataRow dr = dt.NewRow();
                dr["userAccount"] = userAccount;
                dr["token"] = token;
                dr["cert"] = cert;
                dr["timeout"] = timeout;
                dt.Rows.Add(dr);
                HttpContext.Current.Cache["PASSPORT.TOKEN"] = dt;
            }
            //token存在则更新过期时间
            else
            {
                TokenTimeUpdate(token, timeout);
            }
        }

    }//end class
}
