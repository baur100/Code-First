namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDb : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Day", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Day");
        }
    }
}
