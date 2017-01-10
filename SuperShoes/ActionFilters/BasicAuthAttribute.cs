using Newtonsoft.Json;
using SuperShoes.Database;
using SuperShoes.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Script.Serialization;

namespace SuperShoes.ActionFilters
{
    public class BasicAuthAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            var req = actionContext.Request;
            var auth = req.Headers.Authorization;
            if (auth != null)
            {
                var cred = System.Text.ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(auth.ToString().Substring(6))).Split(':');
                var user = new { Name = cred[0], Pass = cred[1] };
                if (user.Name == "my_user" && user.Pass == "my_password")
                {
                    base.OnActionExecuting(actionContext);
                    return;
                }
            }
            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            var json = new JavaScriptSerializer().Serialize(new ErrorResult() {
                Success =false,
                StatusCode =(int)HttpStatusCode.Unauthorized,
                ErrorMsg ="Unauthorized Access Denied"
            });

            actionContext.Response.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
        }
    }
}