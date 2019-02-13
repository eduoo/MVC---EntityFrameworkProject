using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Market.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Product { get; set; }
    }
}