namespace SuperShoes.Migrations
{
    using Database;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperShoes.Database.SuperShoesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SuperShoes.Database.SuperShoesContext";
        }

        protected override void Seed(SuperShoes.Database.SuperShoesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var ssCentro = new Store() { Id = 1, Name = "SuperShoes Centro", Address = "Calle 4 #7-65, Bogotá" };
            var ssChapinero = new Store() { Id = 2, Name = "SuperShoes Chapinero", Address = "Calle 84 #14-83, Bogotá" };
            var ssTeusaquillo = new Store() { Id = 3, Name = "SuperShoes Teusaquillo", Address = "Cra 7 #45-31, Bogotá" };
            context.Stores.AddOrUpdate(
                ssCentro, ssChapinero, ssTeusaquillo
            );

            context.Articles.AddOrUpdate(
                new Article() { Id = 1, Name = "Sandalias", Description = "Simples y Ligeras", Price = 20000, Store = ssCentro, TotalInShelf = 5, TotalInVault = 100 },
                new Article() { Id = 2, Name = "Tenis", Description = "Deportivos y Duraderos", Price = 40000, Store = ssCentro, TotalInShelf = 8, TotalInVault = 50 },
                new Article() { Id = 3, Name = "Mocasines", Description = "Casuales y Divertidos", Price = 50000, Store = ssTeusaquillo, TotalInShelf = 10, TotalInVault = 150 },
                new Article() { Id = 4, Name = "Zapatos de Cuero", Description = "Elegantes y Brillantes", Price = 80000, Store = ssChapinero, TotalInShelf = 4, TotalInVault = 24 }
            );
        }
    }
}
