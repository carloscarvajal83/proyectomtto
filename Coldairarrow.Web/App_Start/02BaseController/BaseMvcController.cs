using Coldairarrow.Util;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Coldairarrow.Web
{
    /// <summary>
    /// Mvc基控制器
    /// </summary>
    [CheckLogin]
    public class BaseMvcController : BaseController
    {
        /// <summary>
        /// 在调用操作方法前调用
        /// </summary>
        /// <param name="filterContext">请求上下文</param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var sessionCookie = HttpContext.Request.Cookies[SessionHelper.SessionCookieName];
            if (sessionCookie.IsNullOrEmpty())
            {
                string sessionId = Guid.NewGuid().ToString();
                //HttpContext.Response.Cookies.Append(SessionHelper.SessionCookieName, sessionId, new CookieOptions { Expires = DateTime.MaxValue });
                HttpContext.Response.Cookies.Append(SessionHelper.SessionCookieName, sessionId, new CookieOptions { Expires = new DateTimeOffset(new DateTime(9999, 12, 30)) });

                filterContext.Result = new RedirectResult(HttpContext.Request.Path);
            }
        }
    }
}