using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace GameInterface.Common.Utils
{
    public class CookieUtils
    {
        public static void AddCookie(string name, string value, HttpContext h)
        {
            HttpCookie cookieName = new HttpCookie(name, System.Web.HttpUtility.UrlEncode(value, System.Text.Encoding.GetEncoding(65001)));
            cookieName.Value = value;

            h.Response.Cookies.Add(cookieName);
        }

        public static string GetCookieString(HttpContext h, string name)
        {
            if (h.Request.Cookies[name] != null)
            {
                if (h.Response.Cookies.Count > 0 && h.Response.Cookies[name] != null)
                {
                    return System.Web.HttpUtility.UrlDecode(h.Response.Cookies[name].Value, System.Text.Encoding.GetEncoding(65001));
                }
                return System.Web.HttpUtility.UrlDecode(h.Request.Cookies[name].Value, System.Text.Encoding.GetEncoding(65001));
            }
            else
            { return string.Empty; }
        }

        public static HttpCookie GetCookie(HttpContext h, string name)
        {
            if (h.Request.Cookies.Count > 0)
            {
                return h.Request.Cookies[name];
            }
            return null;
        }

        public static void RemoveCookie(string name, HttpContext h)
        {
            h.Response.Cookies[name].Value = null;
            h.Response.Cookies[name].Expires = DateTime.Now.AddDays(-1);
        }

        public static void ClearCookie(HttpContext h)
        {
            try
            {
                foreach (HttpCookie hc in h.Response.Cookies)
                {
                    hc.Value = null;
                    hc.Expires = DateTime.Now.AddDays(-1);
                }
            }
            catch
            {
            }

        }
    }
}
