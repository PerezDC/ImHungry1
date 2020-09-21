using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImHungry.Models
{
    public class Restaurant
    {
        public string RestName { get; set; }

        public int RestPhone { get; set; }

        public int PriceRank { get; set; }

        public int HoursOperation { get; set; }

        public string RestAddress { get; set; }
    }
}