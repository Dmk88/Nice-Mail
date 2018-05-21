namespace kp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbn : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Courses", "ID_Specialty", "dbo.Specialties");
            DropForeignKey("dbo.Courses", "ID_Student", "dbo.Students");
            DropForeignKey("dbo.Assesments", "ID_student", "dbo.Students");
            DropForeignKey("dbo.Assesments", "ID_sub", "dbo.Subjects");
            DropPrimaryKey("dbo.Courses");
            DropPrimaryKey("dbo.Specialties");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Subjects");
            AddColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false));
            AddColumn("dbo.Specialties", "SpecialtyId", c => c.Int(nullable: false));
            AlterColumn("dbo.Students", "Id_student", c => c.Int(nullable: false));
            AlterColumn("dbo.Subjects", "ID_sub", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Courses", "CourseId");
            AddPrimaryKey("dbo.Specialties", "SpecialtyId");
            AddPrimaryKey("dbo.Students", "Id_student");
            AddPrimaryKey("dbo.Subjects", "ID_sub");
            AddForeignKey("dbo.Courses", "ID_Specialty", "dbo.Specialties", "SpecialtyId");
            AddForeignKey("dbo.Courses", "ID_Student", "dbo.Students", "Id_student");
            AddForeignKey("dbo.Assesments", "ID_student", "dbo.Students", "Id_student");
            AddForeignKey("dbo.Assesments", "ID_sub", "dbo.Subjects", "ID_sub");
            DropColumn("dbo.Courses", "Id_course");
            DropColumn("dbo.Specialties", "ID_Specialty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Specialties", "ID_Specialty", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Courses", "Id_course", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Assesments", "ID_sub", "dbo.Subjects");
            DropForeignKey("dbo.Assesments", "ID_student", "dbo.Students");
            DropForeignKey("dbo.Courses", "ID_Student", "dbo.Students");
            DropForeignKey("dbo.Courses", "ID_Specialty", "dbo.Specialties");
            DropPrimaryKey("dbo.Subjects");
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Specialties");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Subjects", "ID_sub", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Students", "Id_student", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Specialties", "SpecialtyId");
            DropColumn("dbo.Courses", "CourseId");
            AddPrimaryKey("dbo.Subjects", "ID_sub");
            AddPrimaryKey("dbo.Students", "Id_student");
            AddPrimaryKey("dbo.Specialties", "ID_Specialty");
            AddPrimaryKey("dbo.Courses", "Id_course");
            AddForeignKey("dbo.Assesments", "ID_sub", "dbo.Subjects", "ID_sub");
            AddForeignKey("dbo.Assesments", "ID_student", "dbo.Students", "Id_student");
            AddForeignKey("dbo.Courses", "ID_Student", "dbo.Students", "Id_student");
            AddForeignKey("dbo.Courses", "ID_Specialty", "dbo.Specialties", "ID_Specialty");
        }
    }
}
