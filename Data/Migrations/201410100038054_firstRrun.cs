namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstRrun : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        TelefoneResidencial = c.String(),
                        Endereço = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        TelefoneCelular = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clientes");
        }
    }
}
