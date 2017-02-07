namespace IntegrationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedInterestsUserNameJustIDNow : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Interests", name: "User_Id", newName: "UserId");
            RenameIndex(table: "dbo.Interests", name: "IX_User_Id", newName: "IX_UserId");
            DropColumn("dbo.Interests", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interests", "UserName", c => c.String());
            RenameIndex(table: "dbo.Interests", name: "IX_UserId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Interests", name: "UserId", newName: "User_Id");
        }
    }
}
