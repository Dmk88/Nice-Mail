namespace kp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id_course = c.Int(nullable: false, identity: true),
                        Cour = c.Int(nullable: false),
                        Semester = c.Int(nullable: false),
                        Group = c.Int(nullable: false),
                        ID_Specialty = c.Int(nullable: false),
                        ID_Student = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_course)
                .ForeignKey("dbo.Specialties", t => t.ID_Specialty)
                .ForeignKey("dbo.Students", t => t.ID_Student)
                .Index(t => t.ID_Specialty)
                .Index(t => t.ID_Student);
            
            CreateTable(
                "dbo.Specialties",
                c => new
                    {
                        ID_Specialty = c.Int(nullable: false, identity: true),
                        Name_Specialty = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_Specialty);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id_student = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        Patronymic = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id_student);
            
            CreateTable(
                "dbo.Assesments",
                c => new
                    {
                        ID_assesment = c.Int(nullable: false, identity: true),
                        ID_sub = c.Int(nullable: false),
                        Аssessments = c.Int(nullable: false),
                        Attempt = c.Int(nullable: false),
                        ID_student = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_assesment)
                .ForeignKey("dbo.Students", t => t.ID_student)
                .ForeignKey("dbo.Subjects", t => t.ID_sub)
                .Index(t => t.ID_sub)
                .Index(t => t.ID_student);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ID_sub = c.Int(nullable: false, identity: true),
                        Name_sub = c.String(maxLength: 300),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_sub);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Assesments", "ID_sub", "dbo.Subjects");
            DropForeignKey("dbo.Assesments", "ID_student", "dbo.Students");
            DropForeignKey("dbo.Courses", "ID_Student", "dbo.Students");
            DropForeignKey("dbo.Courses", "ID_Specialty", "dbo.Specialties");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.Assesments", new[] { "ID_student" });
            DropIndex("dbo.Assesments", new[] { "ID_sub" });
            DropIndex("dbo.Courses", new[] { "ID_Student" });
            DropIndex("dbo.Courses", new[] { "ID_Specialty" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.Subjects");
            DropTable("dbo.Assesments");
            DropTable("dbo.Students");
            DropTable("dbo.Specialties");
            DropTable("dbo.Courses");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
        }
    }
}
