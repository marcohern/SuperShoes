using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace SuperShoes.Results
{
    public class GeneralResult
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }

        public GeneralResult()
        {
            Success = true;
            StatusCode = (int)HttpStatusCode.OK;
        }

        public GeneralResult(bool success, int statusCode)
        {
            Success = success;
            StatusCode = statusCode;
        }
    }
}