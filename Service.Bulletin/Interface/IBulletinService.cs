﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Bulletin
{
    public interface IBulletinService
    {
        IEnumerable<BulletPoint> getBulletPoints();
        Task<IEnumerable<BulletPoint>> getBulletPointsAsync();
    }
}
