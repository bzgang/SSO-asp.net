using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace SSO.Passport.Models
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("userLoginToken")]
    public partial class userLoginToken
    {
        public userLoginToken()
        {


        }
        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>           
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ID { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string userAccount { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string token { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public bool? isActive { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? ExtDatetime { get; set; }
        public string ipPath { get; set; }
        public string browser { get; set; }

    }
}
