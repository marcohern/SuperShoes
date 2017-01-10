using SuperShoes.ActionFilters;
using SuperShoes.Database;
using SuperShoes.Exceptions;
using SuperShoes.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SuperShoes.Controllers
{
    public class StoresController : ApiController
    {
        // GET: api/Stores
        public StoresResult Get()
        {
            using(var db = new SuperShoesContext())
            {
                return new StoresResult(db.Stores.ToList());
            }
        }

        // GET: api/Stores/5
        public StoreResult Get(string id)
        {
            int iid;
            try
            {
                iid = Convert.ToInt32(id);
            }
            catch (Exception ex) { throw new NanException("Bad Request", ex); }
            
            using (var db = new SuperShoesContext())
            {
                var store = db.Stores.Include("Articles").Where(s => s.Id == iid).FirstOrDefault();
                if (store == null) throw new RecordNotFoundException("Record not found");
                return new StoreResult(store);
            }
        }
        /*
        // POST: api/Stores
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Stores/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stores/5
        public void Delete(int id)
        {
        }*/
    }
}
