using SuperShoes.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Results
{
    public class StoresResult : SuccessResult
    {
        public List<Store> Stores { get; private set; }

        public StoresResult(List<Store> stores) : base()
        {
            Stores = stores;
            TotalElements = stores.Count();
        }
    }
}