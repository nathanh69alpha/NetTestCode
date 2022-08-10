namespace EF6Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAndSeedDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        StudentName = c.String(),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Students", "Department_Id", "dbo.Departments");
            DropIndex("dbo.Teachers", new[] { "Department_Id" });
            DropIndex("dbo.Students", new[] { "Department_Id" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
