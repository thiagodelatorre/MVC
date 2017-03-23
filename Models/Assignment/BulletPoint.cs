using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Models
{
    public class BulletPoint
    {
        public int Id { get; set; }

        [DisplayName("Solution Highlights")]
        public string Point { get; set; }
    }
}