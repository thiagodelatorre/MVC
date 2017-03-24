using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Service.Bulletin
{
    public class BulletinServiceMock : IBulletinService
    {
        public IEnumerable<BulletPoint> getBulletPoints()
        {
            List<BulletPoint> bulletin = new List<BulletPoint>
            {
                new BulletPoint { Point = "Overall: Solution created from Empty template to guaranteed that only used code is maintained." },
                new BulletPoint { Point = "Overall: Front-end kept minimal to meet the requirements." },
                new BulletPoint { Point = "Overall: Applied maintainability concepts to back-end (production-ready code)." },
                new BulletPoint { Point = "CTA: Generates from an action allowing dynamic content based on profile and statistics gathering." },
                new BulletPoint { Point = "CTA: Link for CTA button could be a redirected from an action to record the successful user's interaction." },
                new BulletPoint { Point = "Bullet Point List: Annotation used on model (DisplayName)." },
                new BulletPoint { Point = "Bullet Point List: Generates from Action as a reusable component." },
                new BulletPoint { Point = "Bullet Point List: Uses DisplayTemplates to make it even more reusable." },
                new BulletPoint { Point = "Bullet Point List: Uses OutputCache (refreshing every 3600s) as this component just change." },
                new BulletPoint { Point = "Bullet Point List: Initially developed as a mocked service, then migrate to EntityFramework." }
            };

            return bulletin;
        }
    }
}
