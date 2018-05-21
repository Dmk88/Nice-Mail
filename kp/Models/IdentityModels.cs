using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using kp.EF;

namespace kp.Models
{
    // Чтобы добавить данные профиля для пользователя, можно добавить дополнительные свойства в класс ApplicationUser. Дополнительные сведения см. по адресу: http://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
            
        }
       
    }


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //public DbSet<Student> Students { get; set; }
        //public DbSet<Subject> Subjects { get; set; }
        //public DbSet<Specialty> Specialtys { get; set; }
        //public DbSet<Course> Courses { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }


        public static ApplicationDbContext Create()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>() /*new DropCreateDatabaseIfModelChanges<ApplicationDbContext>()*/ );
            return new ApplicationDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasRequired(cr => cr.Speciality)
                .WithMany()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Course>()
                .HasRequired(sp => sp.Student)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Assessment>()
                .HasRequired(at => at.Subject)
                .WithMany()
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<Assessment>()
                .HasRequired(at => at.Student)
                .WithMany()
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}