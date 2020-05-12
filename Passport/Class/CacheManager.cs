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
    /// �������
    /// �����ơ��û�ƾ֤�Լ�����ʱ��Ĺ�ϵ���ݴ����Cache��
    /// 
    /// �⽣ 2009-06-24 ����
    /// �⽣ 2012-11-07 �޸�
    /// </summary>
    public class CacheManager
    {
        /// <summary>
        /// ��ʼ���������ݽṹ
        /// </summary>
        /// <remarks>
        /// ----------------------------------------------------
        /// | ��½�û���Ϣ |token(����) | cert(�û�ƾ֤) | timeout(����ʱ��) |
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

                //Cache�Ĺ���ʱ��Ϊ ���ƹ���ʱ��*2
                HttpContext.Current.Cache.Insert("PASSPORT.TOKEN", dt, null, DateTime.MaxValue, TimeSpan.FromMinutes(double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timeout"]) * 2));
            }
        }

        /// <summary>
        /// ��ȡ�����е�DataTable
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
        /// �ж������Ƿ����
        /// </summary>
        /// <param name="token">����</param>
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
        /// �������ƹ���ʱ��
        /// </summary>
        /// <param name="token">����</param>
        /// <param name="time">����ʱ��</param>
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
        /// �������
        /// </summary>
        /// <param name="userAccount">��½�û�</param>
        /// <param name="token">����</param>
        /// <param name="cert">ƾ֤</param>
        /// <param name="timeout">����ʱ��</param>
        public static void TokenInsert(string userAccount, string token, object cert, DateTime timeout)
        {
            cacheInit();

            //token�����������
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
            //token��������¹���ʱ��
            else
            {
                TokenTimeUpdate(token, timeout);
            }
        }

    }//end class
}
