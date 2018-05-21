using kp.EF;
using kp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp.Interfaces
{
    public interface ICourse
    {
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        Course Find(int id);
    }
}
