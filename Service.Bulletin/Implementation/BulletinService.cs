using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace Service.Bulletin
{
    public class BulletinService : IBulletinService
    {
        private readonly AssignmentContext _assignmentContext;

        public BulletinService()
        {
            _assignmentContext = new AssignmentContext();
        }

        // May be used for UnitTests or to fast-track development (while the final DB is not ready or accessible)
        public BulletinService(AssignmentContext assignmentContext)
        {
            _assignmentContext = assignmentContext;
        }

        public IEnumerable<BulletPoint> getBulletPoints()
        {
            List<BulletPoint> bulletin = _assignmentContext.BulletPoints.ToList();

            return bulletin;
        }
    }
}
