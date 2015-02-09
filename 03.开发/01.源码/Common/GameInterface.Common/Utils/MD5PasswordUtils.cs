using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace GameInterface.Common.Utils
{
    public class MD5PasswordUtils
    { 

        /// <summary>
        /// 检查密码
        /// </summary>
        /// <param name="userInfo">获取用户信息</param>
        /// <param name="password">用户提交的密码</param>
        /// <param name="logonTime">登录时间</param>
        /// <returns>返回验证结果</returns>
        public static string CheckPassword(string userName, string password)
        {
            return MD5(MD5(password + userName));
        }

        /// <summary>
        /// 创建新密码（新建用户或用户修改密码）
        /// </summary>
        /// <param name="user">获取用户信息</param>
        /// <param name="newPassword">新密码</param>
        /// <returns></returns>
        public static string CreatePassword(string userName, string newPassword)
        {
            return MD5(MD5(newPassword + userName));
        }

        /// <summary>
        /// MD5函数
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns>MD5结果</returns>
        private static string MD5(string str)
        {
            byte[] b = Encoding.Default.GetBytes(str);
            b = new MD5CryptoServiceProvider().ComputeHash(b);
            string ret = "";
            for (int i = 0; i < b.Length; i++)
                ret += b[i].ToString("x").PadLeft(2, '0');

            return ret;
        }
    }
}
