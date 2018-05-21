namespace kp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<kp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(kp.Models.ApplicationDbContext db)
        {
            //var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //// ������� ��� ����
            //var role1 = new IdentityRole { Name = "admin" };
            //var role2 = new IdentityRole { Name = "user" };

            //// ��������� ���� � ��
            //roleManager.Create(role1);
            //roleManager.Create(role2);

            //// ������� �������������
            //var admin = new ApplicationUser { Email = "ekaterina.bazhezha@tut.by", UserName = "ekaterina.bazhezha@tut.by" };
            //string password = "23vfvfgfgfvfK!";
            //var result = userManager.Create(admin, password);

            //// ���� �������� ������������ ������ �������
            //if (result.Succeeded)
            //{
            //    // ��������� ��� ������������ ����
            //    userManager.AddToRole(admin.Id, role1.Name);
            //    userManager.AddToRole(admin.Id, role2.Name);
            //}

            //base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //�������������
            //db.Students.Add(new Student { StudentId = 123 , LastName = "temp", FirstName = "temp", Patronymic = "temp" });
            //base.Seed(db);
            //db.Specialtys.Add(new Specialty { ID_Specialty = 1400501, Name_Specialty = "����" });


            ////�������       
            //db.Students.Add(new Student { Id_student = 71400001, LastName = "������", FirstName = "���������", Patronymic = "����������" });
            //db.Students.Add(new Student { Id_student = 71400002, LastName = "�������", FirstName = "���������", Patronymic = "�������������" });
            //db.Students.Add(new Student { Id_student = 71400003, LastName = "��������", FirstName = "�����", Patronymic = "���������" });
            //db.Students.Add(new Student { Id_student = 71400004, LastName = "������", FirstName = "�������", Patronymic = "�������������" });
            //db.Students.Add(new Student { Id_student = 71400005, LastName = "�������", FirstName = "��������", Patronymic = "�������������" });
            //db.Students.Add(new Student { Id_student = 71400006, LastName = "������", FirstName = "������", Patronymic = "���������" });
            //string temp = "12312";
            //int i = int.Parse(temp);
            ////��������//����
            //db.Subjects.Add(new Subject { ID_sub = 11201, Name_sub = "������������� ���������� ������ �������� � �������������� �����", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 12202, Name_sub = "������ �������������� ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 11303, Name_sub = "������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 13304, Name_sub = "������ �������������� � ����������������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 11305, Name_sub = "������ ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 23206, Name_sub = "������������ �������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 24207, Name_sub = "����������� ����", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 21308, Name_sub = "������ ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 23209, Name_sub = "������ �������������� ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 23310, Name_sub = "������ �������������� � ����������������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 31311, Name_sub = "���������� ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 31312, Name_sub = "������ ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 32313, Name_sub = "������������ ����", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 34214, Name_sub = "���������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 33315, Name_sub = "��������-��������������� ���������������� ", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 41216, Name_sub = "������������ ���������� � �������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 43317, Name_sub = "��������-��������������� ����������������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 44118, Name_sub = "���������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 43219, Name_sub = "�������������� ����������������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 46320, Name_sub = "���� ������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 53221, Name_sub = "�����������-�������������� �������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 54122, Name_sub = "������������ ����������������� ��������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 53223, Name_sub = "���������������� ������� ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 54124, Name_sub = "������ ������� � �����", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 56325, Name_sub = "����������������� ��� ������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 61126, Name_sub = "������������� � ����������� ����������� �������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 66227, Name_sub = "������ ����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 66328, Name_sub = "�������������� �������������� �������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 63229, Name_sub = "��������� ����������������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 62130, Name_sub = "����������������� �������������� ������ � ���-��������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 73331, Name_sub = "���������������� � ��������", Quantity = 2 });
            //db.Subjects.Add(new Subject { ID_sub = 73232, Name_sub = "������������ ������������ �����������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 73333, Name_sub = "���������������� ��������� ������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 75134, Name_sub = "���������� ��������������� ��������� ������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 85235, Name_sub = "�������� ���������", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 81336, Name_sub = "���������� �������", Quantity = 1 });

            ////����
            //db.Courses.Add(new Course { Id_course = 1, Cour = 1, Semester = 1, Group = 2, ID_Specialty = 1400501, ID_Student = 71400001 });
            //db.Courses.Add(new Course { Id_course = 2, Cour = 2, Semester = 2, Group = 2, ID_Specialty = 1400501, ID_Student = 71400002 });
            //db.Courses.Add(new Course { Id_course = 3, Cour = 3, Semester = 1, Group = 2, ID_Specialty = 1400501, ID_Student = 71400003 });
            //db.Courses.Add(new Course { Id_course = 4, Cour = 1, Semester = 2, Group = 2, ID_Specialty = 1400501, ID_Student = 71400004 });
            //db.Courses.Add(new Course { Id_course = 5, Cour = 2, Semester = 1, Group = 2, ID_Specialty = 1400501, ID_Student = 71400005 });
            //db.Courses.Add(new Course { Id_course = 6, Cour = 3, Semester = 2, Group = 2, ID_Specialty = 1400501, ID_Student = 71400006 });
            ////db.SaveChanges();
            //base.Seed(db);
        }
    }
}
