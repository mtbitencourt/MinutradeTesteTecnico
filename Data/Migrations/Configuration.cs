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
            //    new Cliente { Endereço = "Rua A", Nome = "Joaquim", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua B", Nome = "Carlos ", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua C", Nome = "Almeida", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua D", Nome = "Ana", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua E", Nome = "MAria", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua F", Nome = "Josanete", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua G", Nome = "Ariel", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua A", Nome = "Carlos Joaquim", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua C", Nome = "VItor", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua E", Nome = "Ingrid", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua EF", Nome = "Renata", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua QR", Nome = "Marcela", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua AFONSO PENA", Nome = "Camal", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua BAHIA", Nome = "Tulio", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua A", Nome = "Bianca", TelefoneResidencial = "322232321" },
            //    new Cliente { Endereço = "Rua Afonso Pena", Nome = "Teste", TelefoneResidencial = "322232321" }
                
                
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
