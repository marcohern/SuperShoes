using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Database
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int TotalInShelf { get; set; }
        public int TotalInVault { get; set; }

        [JsonIgnore]
        public virtual Store Store { get; set; }
    }
}