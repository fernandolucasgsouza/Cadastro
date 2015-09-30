namespace Cadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contatoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.String(),
                        Sexo = c.String(),
                        Email = c.String(),
                        Cep = c.String(),
                        Logradoouro = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        Municipio = c.String(),
                        Uf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contatoes");
        }
    }
}
