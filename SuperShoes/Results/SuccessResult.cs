using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace SuperShoes.Results
{
    public class SuccessResult : GeneralResult
    { 
        public int TotalElements { get; set; }
        public SuccessResult() : base(true, (int)HttpStatusCode.OK)
        {
            TotalElements = 0;
        }
    }
}