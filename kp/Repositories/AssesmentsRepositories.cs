using kp.EF;
using kp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp.Repositories
{
    public class AssesmentsRepositories:BaseRepositories,IAssessment
    {
        public AssesmentsRepositories(AnaliticEntities1 context) : base(context) { }

        public void AddAssesments(Assessment assesments)
        {
            _context.Assessment.Add(assesments);
            base.Save();
        }

        public Assessment Find(int id)
        {
            return _context.Assessment.Find(id);
        }

        public void UpdateAssesments(Assessment assesments)
        {
            var item = Find(assesments.ID);
            _context.Entry(item).CurrentValues.SetValues(assesments);
            base.Save();
        }

        //public IQueryable<Guid?> GetAssesmentsIdListByUserId(Guid id)
        //{
        //    return _context.User_sPersonalData.Where(s => s.Id == id).Select(x => x.AducationId);
        //}
    }
}