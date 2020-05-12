using SqlSugar;
using SSO.Passport.Models;
using SSO.Passport.SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SSO.Passport.Class
{
    public class DbTonkenLoginManager : sqlSugarHelper
    {
        public SimpleClient<userLoginToken> userLogin { get { return new SimpleClient<userLoginToken>(ssDbClient); } }
        /// <summary>
        /// 获取所有实体信息
        /// </summary>
        /// <returns></returns>
        public List<userLoginToken> getUserToeknList()
        {
            return userLogin.GetList();
        }

        /// <summary>
        /// 获取缓存中的DataTable
        /// </summary>
        /// <returns></returns>
        public DataTable GetTokenTable()
        {
            DataTable dt = null;
            dt = userLogin.AsQueryable().Where(u => 1 == 1).ToDataTable();
            return dt;
        }

        /// <summary>
        /// 判断令牌是否存在
        /// </summary>
        /// <param name="token">令牌</param>
        /// <returns></returns>
        public bool TokenIsExist(string token)
        {
            //根据过期时间，当前登陆IP和token信息判断是否登陆
            return userLogin.AsQueryable().Where(u => u.token == token && u.ExtDatetime >= DateTime.Now && u.ipPath == HttpContext.Current.Request.UserHostAddress).Any();
        }
        /// <summary>
        /// 添加令牌
        /// </summary>
        /// <param name="userAccount">登陆用户</param>
        /// <param name="token">令牌</param>
        /// <param name="cert">凭证</param>
        /// <param name="timeout">过期时间</param>
        public bool addUserToken(userLoginToken ulk)
        {
            if (!userLogin.AsQueryable().Where(u => u.token == ulk.token).Any())
            {
                return userLogin.Insert(ulk);
            }
            else
            {
                return updateUserToken(ulk.token, (DateTime)ulk.ExtDatetime);
            }
        }

        /// <summary>
        /// 根据查询条件删除
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public bool delUserToken(string token)
        {
            bool retFlag = false;
            int i = userLogin.AsDeleteable().Where(u => u.token == token).ExecuteCommand();
            if (i >= 1)
            {
                retFlag = true;
            }
            return retFlag;
        }
        /// <summary>
        /// 更新令牌过期时间
        /// </summary>
        /// <param name="token">令牌</param>
        /// <param name="time">过期时间</param>
        public bool updateUserToken(string token, DateTime time)
        {
            return userLogin.Update(it => new userLoginToken() { ExtDatetime = time }, it => it.token == token);// 只更新时间列 
        }
    }
}