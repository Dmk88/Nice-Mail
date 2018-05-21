using kp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp.Interfaces
{
    public interface ISpeciality
    {
        void AddSpecialties(Speciality specialties);
        void UpdateSpecialties(Speciality specialties);
        Speciality Find(int id);
    }
}
