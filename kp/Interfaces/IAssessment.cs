using kp.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp.Interfaces
{
    public interface IAssessment
    {
        void AddAssesments(Assessment assesments);
        void UpdateAssesments(Assessment assesments);
        Assessment Find(int id);
    }
}
