using kp.EF;
using kp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp.Interfaces
{
   public interface ISubjects
    {
        void AddSubjects(Subject subjects);
        void UpdateSubjects(Subject subjects);
        Subject Find(int id);
    }
}
