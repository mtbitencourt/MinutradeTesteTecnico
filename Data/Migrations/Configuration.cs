namespace Data.Migrations
{
    using Core.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.MinutradeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Data.MinutradeContext context)
        {
            //context.Cliente.AddOrUpdate(
            //    new Cliente { Endere�o = "Rua A", Nome = "Joaquim", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua B", Nome = "Carlos ", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua C", Nome = "Almeida", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua D", Nome = "Ana", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua E", Nome = "MAria", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua F", Nome = "Josanete", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua G", Nome = "Ariel", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua A", Nome = "Carlos Joaquim", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua C", Nome = "VItor", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua E", Nome = "Ingrid", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua EF", Nome = "Renata", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua QR", Nome = "Marcela", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua AFONSO PENA", Nome = "Camal", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua BAHIA", Nome = "Tulio", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua A", Nome = "Bianca", TelefoneResidencial = "322232321" },
            //    new Cliente { Endere�o = "Rua Afonso Pena", Nome = "Teste", TelefoneResidencial = "322232321" }
                
                
            //    );
            
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
        }
    }
}
