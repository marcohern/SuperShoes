using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Database
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Article> Articles { get; set; }

        public Store()
        {
            Articles = new List<Article>();
        }
    }
}