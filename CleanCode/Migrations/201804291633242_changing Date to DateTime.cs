namespace CleanCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingDatetoDateTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "DateTime");
        }
    }
}
