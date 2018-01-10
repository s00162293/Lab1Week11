namespace Lab1Week11.Migrations.ClubContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClubEvent", "StartDateTime", c => c.DateTime());
            AlterColumn("dbo.ClubEvent", "EndDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClubEvent", "EndDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClubEvent", "StartDateTime", c => c.DateTime(nullable: false));
        }
    }
}
