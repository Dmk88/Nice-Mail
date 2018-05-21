namespace kp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Number = c.Int(nullable: false),
                        Course_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Mark = c.Int(),
                        Semester_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Semesters", t => t.Semester_Id)
                .Index(t => t.Semester_Id);
            
            AddColumn("dbo.AspNetUsers", "Name", c => c.String());
            AddColumn("dbo.AspNetUsers", "Surname", c => c.String());
            AddColumn("dbo.AspNetUsers", "CurrentCourse_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "PrevCourse_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.AspNetUsers", "CurrentCourse_Id");
            CreateIndex("dbo.AspNetUsers", "PrevCourse_Id");
            AddForeignKey("dbo.AspNetUsers", "CurrentCourse_Id", "dbo.Courses", "Id");
            AddForeignKey("dbo.AspNetUsers", "PrevCourse_Id", "dbo.Courses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "PrevCourse_Id", "dbo.Courses");
            DropForeignKey("dbo.AspNetUsers", "CurrentCourse_Id", "dbo.Courses");
            DropForeignKey("dbo.Semesters", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.Subjects", "Semester_Id", "dbo.Semesters");
            DropIndex("dbo.Subjects", new[] { "Semester_Id" });
            DropIndex("dbo.Semesters", new[] { "Course_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "PrevCourse_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "CurrentCourse_Id" });
            DropColumn("dbo.AspNetUsers", "PrevCourse_Id");
            DropColumn("dbo.AspNetUsers", "CurrentCourse_Id");
            DropColumn("dbo.AspNetUsers", "Surname");
            DropColumn("dbo.AspNetUsers", "Name");
            DropTable("dbo.Subjects");
            DropTable("dbo.Semesters");
            DropTable("dbo.Courses");
        }
    }
}
