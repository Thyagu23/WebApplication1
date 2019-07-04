using System;
using System.Collections.Generic;
using System.Text;

namespace Calpion.Artemis.Models
{
    public class LoginModel
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public bool Remember { get; set; }
    }
}
