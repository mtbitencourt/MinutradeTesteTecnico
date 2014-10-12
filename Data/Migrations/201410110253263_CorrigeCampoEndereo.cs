namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrigeCampoEndereo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Endereco", c => c.String());
            DropColumn("dbo.Clientes", "Endereço");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "Endereço", c => c.String());
            DropColumn("dbo.Clientes", "Endereco");
        }
    }
}
