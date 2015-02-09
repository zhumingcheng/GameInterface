using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameInterface.JsonModel
{
    public class JsonUser
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// 用户登录名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// MD5加密
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户类型（普通用户、管理员）
        /// </summary>
        public string Type { get; set; }
    }
}
