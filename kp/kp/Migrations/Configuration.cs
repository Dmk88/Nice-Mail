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

            //// создаем две роли
            //var role1 = new IdentityRole { Name = "admin" };
            //var role2 = new IdentityRole { Name = "user" };

            //// добавляем роли в бд
            //roleManager.Create(role1);
            //roleManager.Create(role2);

            //// создаем пользователей
            //var admin = new ApplicationUser { Email = "ekaterina.bazhezha@tut.by", UserName = "ekaterina.bazhezha@tut.by" };
            //string password = "23vfvfgfgfvfK!";
            //var result = userManager.Create(admin, password);

            //// если создание пользователя прошло успешно
            //if (result.Succeeded)
            //{
            //    // добавляем для пользователя роль
            //    userManager.AddToRole(admin.Id, role1.Name);
            //    userManager.AddToRole(admin.Id, role2.Name);
            //}

            //base.Seed(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //Специальность
            //db.Students.Add(new Student { StudentId = 123 , LastName = "temp", FirstName = "temp", Patronymic = "temp" });
            //base.Seed(db);
            //db.Specialtys.Add(new Specialty { ID_Specialty = 1400501, Name_Specialty = "ИСиТ" });


            ////Студент       
            //db.Students.Add(new Student { Id_student = 71400001, LastName = "Бажежа", FirstName = "Екатерина", Patronymic = "Дмитриевна" });
            //db.Students.Add(new Student { Id_student = 71400002, LastName = "Гладкая", FirstName = "Елизавета", Patronymic = "Александровна" });
            //db.Students.Add(new Student { Id_student = 71400003, LastName = "Кохнович", FirstName = "Алина", Patronymic = "Сергеевна" });
            //db.Students.Add(new Student { Id_student = 71400004, LastName = "Шихова", FirstName = "Татьяна", Patronymic = "Александровна" });
            //db.Students.Add(new Student { Id_student = 71400005, LastName = "Бельмач", FirstName = "Владимир", Patronymic = "Александрович" });
            //db.Students.Add(new Student { Id_student = 71400006, LastName = "Бакиев", FirstName = "Андрей", Patronymic = "Ринатович" });
            //string temp = "12312";
            //int i = int.Parse(temp);
            ////Предметы//ИСиТ
            //db.Subjects.Add(new Subject { ID_sub = 11201, Name_sub = "Арифметическо логические основы цифровых и вычислительных машин", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 12202, Name_sub = "Основы информационных технологий", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 11303, Name_sub = "Физика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 13304, Name_sub = "Основы алгоритмизации и программирования", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 11305, Name_sub = "Высшая математика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 23206, Name_sub = "Операционные системы", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 24207, Name_sub = "Иностранный язык", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 21308, Name_sub = "Высшая математика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 23209, Name_sub = "Основы информационных технологий", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 23310, Name_sub = "Основы алгоритмизации и программирования", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 31311, Name_sub = "Дискретная математика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 31312, Name_sub = "Высшая математика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 32313, Name_sub = "Компьютерные сети", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 34214, Name_sub = "Философия", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 33315, Name_sub = "Объектно-ориентированное программирование ", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 41216, Name_sub = "Компьютерные технологии и графика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 43317, Name_sub = "Объектно-ориентированное программирование", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 44118, Name_sub = "Экономика", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 43219, Name_sub = "Математическое программирование", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 46320, Name_sub = "Базы данных", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 53221, Name_sub = "Кампьютерно-мультимедийные системы", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 54122, Name_sub = "Безопасность жизнедеятельности человека", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 53223, Name_sub = "Программирование сетевых приложений", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 54124, Name_sub = "Основы бизнеса и права", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 56325, Name_sub = "Администрирование баз данных", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 61126, Name_sub = "Моделирование и оптимизация программных средств", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 66227, Name_sub = "Защита информации", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 66328, Name_sub = "Распределенные информационные системы", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 63229, Name_sub = "Системное программирование", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 62130, Name_sub = "Администрирование информационных систем и веб-порталов", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 73331, Name_sub = "Программирование в Интернет", Quantity = 2 });
            //db.Subjects.Add(new Subject { ID_sub = 73232, Name_sub = "Тестирование программного обеспечения", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 73333, Name_sub = "Программирование мобильных систем", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 75134, Name_sub = "Технологии интелектуальной обработки данных", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 85235, Name_sub = "Облочное хранилище", Quantity = 1 });
            //db.Subjects.Add(new Subject { ID_sub = 81336, Name_sub = "Встроенные системы", Quantity = 1 });

            ////Курс
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
