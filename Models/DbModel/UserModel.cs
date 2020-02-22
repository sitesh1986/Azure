using System;
using System.Collections.Generic;
using System.Text;

namespace Models.DbModel
{
    public class UserModel
    {
        public string displayName { get; set; }
        // public string mailNickName { get; set; }
        public bool accountEnabled { get; set; }
        public string creationType { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
