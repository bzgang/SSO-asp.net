using SqlSugar;
using SSO.Passport.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.MobileControls;

namespace SSO.Passport.SqlSugar
{
    public class sqlSugarHelper
    {
        ConnectionConfig config = new ConnectionConfig();
        public SqlSugarClient ssDbClient;
        public sqlSugarHelper()
        {
            config.DbType = DbType.SqlServer;//数据库类型
            config.ConnectionString = ConfigurationManager.AppSettings["sqlConn"];//数据库链接
            config.IsAutoCloseConnection = true;//自动释放数据务，如果存在事务，在事务结束后释放
            config.InitKeyType = InitKeyType.SystemTable; //Attribute：从实体特性中读取主键自增列信息；SystemTable：从数据库获取自增主键信息

            ssDbClient = new SqlSugarClient(config);  //创建数据库链接信息
        } 

    }
}