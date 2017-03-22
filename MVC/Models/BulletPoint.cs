using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class BulletPoint
    {
        public int Id { get; set; }

        [DisplayName("Best Movies")]
        public string Point { get; set; }
    }
}