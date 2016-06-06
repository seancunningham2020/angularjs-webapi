using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace angularjs_webapi.api.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}