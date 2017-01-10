using SuperShoes.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Results
{
    public class StoreResult : SuccessResult
    {
        public Store Store { get; set; }

        public StoreResult(Store store)
        {
            Store = store;
            TotalElements = 1;
        }
    }
}