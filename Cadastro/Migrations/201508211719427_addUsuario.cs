namespace Cadastro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Nome", c => c.String());
            AddColumn("dbo.Usuarios", "Login", c => c.String());
            AddColumn("dbo.Usuarios", "Senha", c => c.String());
            AddColumn("dbo.Usuarios", "Perfil", c => c.Int(nullable: false));
            AddColumn("dbo.Usuarios", "Ativo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Ativo");
            DropColumn("dbo.Usuarios", "Perfil");
            DropColumn("dbo.Usuarios", "Senha");
            DropColumn("dbo.Usuarios", "Login");
            DropColumn("dbo.Usuarios", "Nome");
        }
    }
}
