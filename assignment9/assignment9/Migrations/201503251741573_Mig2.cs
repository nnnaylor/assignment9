namespace assignment9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lovers", "Name", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Lovers", "FavDog", c => c.String(nullable: false, maxLength: 60));
            AlterColumn("dbo.Lovers", "LastDog", c => c.String(maxLength: 60));
            AlterColumn("dbo.Lovers", "Bio", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Lovers", "PastDog", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lovers", "PastDog", c => c.String());
            AlterColumn("dbo.Lovers", "Bio", c => c.String(nullable: false));
            AlterColumn("dbo.Lovers", "LastDog", c => c.String());
            AlterColumn("dbo.Lovers", "FavDog", c => c.String(nullable: false));
            AlterColumn("dbo.Lovers", "Name", c => c.String(nullable: false));
        }
    }
}
