using SuperShoes.Database;
using SuperShoes.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SuperShoes.Controllers
{
    public class ArticlesController : ApiController
    {
        // GET: api/Articles
        public ArticlesResult Get()
        {
            using(var db = new SuperShoesContext())
            {
                return new ArticlesResult(db.Articles.ToList());
            }
        }
        /*
        // GET: api/Articles/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Articles
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Articles/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Articles/5
        public void Delete(int id)
        {
        }*/
    }
}
