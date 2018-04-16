namespace IntroToEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovies1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "YearReleased", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "YearReleased", c => c.DateTime(nullable: false));
        }
    }
}
