using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SuperShoes.Database
{
    public class SuperShoesContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Store> Stores { get; set; }

        public SuperShoesContext() : base()
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public static void CreateDatabase()
        {
            using (var db = new SuperShoesContext())
            {
                db.Articles.Add(new Article() { Id = 1, Name="The Article", Description="This is the article", Price=1000, TotalInShelf=0, TotalInVault=0 });

                db.SaveChanges();
            }
        }
    }
}