using kp.EF;
using kp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kp.Models;

namespace kp.Repositories
{
    public class SubjectsRepositories : BaseRepositories,ISubjects
    {
        public SubjectsRepositories(AnaliticEntities1 context) : base(context) { }

        public void AddSubjects(Subject subjects)
        {
            _context.Subject.Add(subjects);
            base.Save();
        }

        public Subject Find(int id)
        {
            return _context.Subject.Find(id);
        }

        public void UpdateSubjects(Subject subjects)
        {
            var item = Find(subjects.ID);
            _context.Entry(item).CurrentValues.SetValues(subjects);
            base.Save();
        }

        //void ISubjects.AddSubjects(Subjects subjects)
        //{
        //    throw new NotImplementedException();
        //}

        //Subjects ISubjects.Find(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //void ISubjects.UpdateSubjects(Subjects subjects)
        //{
        //    throw new NotImplementedException();
        //}
    }
}