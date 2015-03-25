namespace assignment9.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nathan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lovers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Lovers", "FavDog", c => c.String(nullable: false));
            AlterColumn("dbo.Lovers", "Bio", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Lovers", "Bio", c => c.String());
            AlterColumn("dbo.Lovers", "FavDog", c => c.String());
            AlterColumn("dbo.Lovers", "Name", c => c.String());
        }
    }
}
