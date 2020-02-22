using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Repository.ViewModel
{
    public class UserViewModel
    {
        public string displayName { get; set; }
        public bool accountEnabled { get; set; }
        public string creationType { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
