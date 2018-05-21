using kp.EF;
using kp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp.Repositories
{
    public class StudentsRepositories : BaseRepositories,IStudents
    {
        public StudentsRepositories(AnaliticEntities1 context) : base(context) { }

        public void AddStudents(Student students)
        {
            _context.Student.Add(students);
            base.Save();
        }

        public Student Find(int id)
        {
            return _context.Student.Find(id);
        }

        public void UpdateStudents(Student students)
        {
            var item = Find(students.ID);
            _context.Entry(item).CurrentValues.SetValues(students);
            base.Save();
        }
    }
}