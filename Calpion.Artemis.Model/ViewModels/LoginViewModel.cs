using System;
using System.Collections.Generic;
using System.Text;

namespace Calpion.Artemis.Models.ViewModels
{
    public class LoginViewModel
    {
        public LoginModel loginview { get; set; }
        public ForgetPasswordModel forgotview { get; set; }
    }

    public class LandingPage
    {
        public string Introduction { get; set; }
    }

}
