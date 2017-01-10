using Newtonsoft.Json;
using SuperShoes.Exceptions;
using SuperShoes.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace SuperShoes.ActionFilters
{
    public class ErrorAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            HttpStatusCode status = GetStatusCode(actionExecutedContext.Exception);
            actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage(status);
            actionExecutedContext.Response.Content = new StringContent(
                new JavaScriptSerializer().Serialize(new ErrorResult((int)status, actionExecutedContext.Exception.Message)),
                Encoding.UTF8,
                "application/json"
            );
            base.OnException(actionExecutedContext);
        }

        private HttpStatusCode GetStatusCode(Exception exception)
        {
            if (exception is RecordNotFoundException) return HttpStatusCode.NotFound;
            return HttpStatusCode.BadRequest;
        }
    }
}