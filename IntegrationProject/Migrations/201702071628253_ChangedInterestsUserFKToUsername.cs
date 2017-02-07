namespace IntegrationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedInterestsUserFKToUsername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interests", "UserName", c => c.String());
            DropColumn("dbo.Interests", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interests", "UserId", c => c.Int(nullable: false));
            DropColumn("dbo.Interests", "UserName");
        }
    }
}
