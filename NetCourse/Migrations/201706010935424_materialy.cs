namespace NetCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class materialy : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materials", "Description", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Materials", "Description", c => c.String());
        }
    }
}
