namespace NetCourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMaterialsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        ModifiedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Materials");
        }
    }
}
