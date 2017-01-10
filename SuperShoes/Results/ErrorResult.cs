using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace SuperShoes.Results
{
    public class ErrorResult : GeneralResult
    {
        public string ErrorMsg { get; set; }
        public ErrorResult():base(false, (int)HttpStatusCode.BadRequest)
        {
            ErrorMsg = "Bad Request";
        }

        public ErrorResult(int statusCode, string errorMsg): base(false, statusCode)
        {
            ErrorMsg = errorMsg;
        }
    }
}