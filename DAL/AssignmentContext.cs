using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssignmentContext : DbContext
    {
        public DbSet<BulletPoint> BulletPoints { get; set; }
    }
}
