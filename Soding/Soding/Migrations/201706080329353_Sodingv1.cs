namespace Soding.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sodingv1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "DateJoin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "DateJoin", c => c.DateTime(nullable: false));
        }
    }
}
