using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImHungry.Models
{
    public class Users
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}