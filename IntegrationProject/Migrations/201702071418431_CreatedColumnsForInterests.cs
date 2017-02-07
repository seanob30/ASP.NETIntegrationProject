namespace IntegrationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedColumnsForInterests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interests", "Comedy", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Concerts", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Conferences", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Education", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Family", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Festivals", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Film", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Food", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Fundraisers", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Galleries", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Health", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Holidays", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Literary", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Musuems", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Neighboorhood", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "NightLife", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "OnCampus", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Organizations", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Outdoors", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Pets", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "PerformingArts", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Politics", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Sales", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Science", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Spiritualality", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Sports", c => c.Boolean(nullable: false));
            AddColumn("dbo.Interests", "Technology", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Interests", "Technology");
            DropColumn("dbo.Interests", "Sports");
            DropColumn("dbo.Interests", "Spiritualality");
            DropColumn("dbo.Interests", "Science");
            DropColumn("dbo.Interests", "Sales");
            DropColumn("dbo.Interests", "Politics");
            DropColumn("dbo.Interests", "PerformingArts");
            DropColumn("dbo.Interests", "Pets");
            DropColumn("dbo.Interests", "Outdoors");
            DropColumn("dbo.Interests", "Organizations");
            DropColumn("dbo.Interests", "OnCampus");
            DropColumn("dbo.Interests", "NightLife");
            DropColumn("dbo.Interests", "Neighboorhood");
            DropColumn("dbo.Interests", "Musuems");
            DropColumn("dbo.Interests", "Literary");
            DropColumn("dbo.Interests", "Holidays");
            DropColumn("dbo.Interests", "Health");
            DropColumn("dbo.Interests", "Galleries");
            DropColumn("dbo.Interests", "Fundraisers");
            DropColumn("dbo.Interests", "Food");
            DropColumn("dbo.Interests", "Film");
            DropColumn("dbo.Interests", "Festivals");
            DropColumn("dbo.Interests", "Family");
            DropColumn("dbo.Interests", "Education");
            DropColumn("dbo.Interests", "Conferences");
            DropColumn("dbo.Interests", "Concerts");
            DropColumn("dbo.Interests", "Comedy");
        }
    }
}
