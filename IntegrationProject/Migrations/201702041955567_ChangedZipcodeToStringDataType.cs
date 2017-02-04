namespace IntegrationProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedZipcodeToStringDataType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
        }
    }
}
