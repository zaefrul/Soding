namespace Soding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sodingv2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 11));
        }
    }
}
