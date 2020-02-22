using System;
using System.Collections.Generic;
using System.Text;

namespace Models.GraphModel
{
    public class GraphUserModel
    {
        public string displayName { get; set; }
        // public string mailNickName { get; set; }
        public bool accountEnabled { get; set; }
        public string creationType { get; set; }
        public List<SignInNames> signInNames { get; set; }
        public PasswordProfile passwordProfile { get; set; }
        public string passwordPolicies { get; set; }
    }
}
