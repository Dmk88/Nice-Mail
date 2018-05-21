using kp.EF;
using kp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp.Repositories
{
    public class CoursesRepositories : BaseRepositories,ICourse
    {
        public CoursesRepositories(AnaliticEntities1 context) : base(context) { }

        public void AddCourse(Course courses)
        {
            _context.Course.Add(courses);
            base.Save();
        }

        public Course Find(int id)
        {
            return _context.Course.Find(id);
        }

        public void UpdateCourse(Course courses)
        {
            var item = Find(courses.ID);
            _context.Entry(item).CurrentValues.SetValues(courses);
            base.Save();
        }

        //public IQueryable<Guid?> GetAssesmentsIdListByUserId(Guid id)
        //{
        //    return _context.User_sPersonalData.Where(s => s.Id == id).Select(x => x.AducationId);
        //}
    }
}