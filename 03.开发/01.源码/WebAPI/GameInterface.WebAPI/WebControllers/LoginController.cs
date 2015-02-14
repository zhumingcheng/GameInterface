using GameInterface.Common.Utils;
using GameInterface.JsonModel;
using GameInterface.WebAPI.Models;
using GameInterface.Core;
using
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameInterface.WebAPI.WebControllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index(string message)
        {
            VOUser user = new VOUser();
            ViewBag.Message = message;
           
            HttpCookie cookie = CookieUtils.GetCookie(System.Web.HttpContext.Current, "LogonID");
            if (cookie != null)
            {
                user.UserName = cookie.Value;
                user.RememberMe = true;
            }
            return View(user);
        }


        public ActionResult Logout()
        {
            CookieUtils.RemoveCookie("LogonID", System.Web.HttpContext.Current);
            GlobalVariables.CurrentUser = new JsonUser();

            return RedirectToAction("Logon", "LogonForm", new { message = "您已成功注销！" });
        }

        [HttpPost]
        public ActionResult SumbitLogon(VOUser user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password))
            {
                return RedirectToAction("Logon", "LogonForm", new { message = "登录名，密码不能为空！" });
            }

            JsonUser jsonUser = UserService.CheckUserPassword(user.UserName, user.Password);

            CookieUtils.AddCookie("LogonID", user.UserName, System.Web.HttpContext.Current);

            if (user.RememberMe)
            {
                HttpCookie cookie = CookieUtils.GetCookie(System.Web.HttpContext.Current, "LogonID");
                cookie.Expires = DateTime.Now.AddDays(7);
            }
            GlobalVariables.CurrentUser = jsonUser;

            if (jsonUser == null)
            {
                return RedirectToAction("Logon", "LogonForm", new { message = "用户名，密码验证失败！" });
            }

            return RedirectToAction("Index", "ParticipateConsultation");
        }
    }
}
