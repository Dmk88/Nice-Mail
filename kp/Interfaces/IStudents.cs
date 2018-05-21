using kp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kp.Models;

namespace kp.Interfaces
{
    public interface IStudents
    {
        void AddStudents(Student students);
        void UpdateStudents(Student students);
        Student Find(int id);
    }
}
