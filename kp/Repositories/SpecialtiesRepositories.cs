using kp.EF;
using kp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kp.Repositories
{
    public class SpecialityRepositories : BaseRepositories, ISpeciality
    {
        public SpecialityRepositories(AnaliticEntities1 context) : base(context) { }

        public void AddSpecialties(Speciality specialties)
        {
            _context.Speciality.Add(specialties);
            base.Save();
        }

        public Speciality Find(int id)
        {
            return _context.Speciality.Find(id);
        }

        public void UpdateSpecialties(Speciality specialties)
        {
            var item = Find(specialties.ID);
            _context.Entry(item).CurrentValues.SetValues(specialties);
            base.Save();
        }
    }
}