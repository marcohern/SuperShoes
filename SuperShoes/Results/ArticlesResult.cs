using SuperShoes.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperShoes.Results
{
    public class ArticlesResult : SuccessResult
    {
        public List<Article> Articles { get; set; }

        public ArticlesResult(List<Article> articles)
        {
            Articles = articles;
            TotalElements = articles.Count;
        }
    }
}