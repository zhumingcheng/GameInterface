using GameInterface.Common.Utils;
using GameInterface.Domain.Repositories.Repositories;
using GameInterface.JsonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface.Core
{
    public class UserService
    {
        public static JsonUser CheckUserPassword(string userName, string password)
        {
            using (GameInterfaceDbContext context = new GameInterfaceDbContext())
            {
                var user = (from u in context.Users where u.UserName == userName select u).First();

                if (user == null)
                    return null;

                if (MD5PasswordUtils.CheckPassword(user.UserName, password) != user.Password)
                    return null;

                JsonUser ju = new JsonUser();
                ObjectHelper.CopyToObject<JsonUser>(user, ref ju);
                return ju;
            }

           
        }
    }
}
