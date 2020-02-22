using GraphApi;
using Models.DbModel;
using Models.GraphModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Repository.Manager
{
    public class GraphUserManager
    {
        private B2CGraphClient _b2CGraphClient;
        public GraphUserManager(B2CGraphClient b2CGraphClient)
        {
            _b2CGraphClient = b2CGraphClient;
        }

        public async Task<bool> CreateB2CUser(UserModel userModel)
        {
            try
            {
                var uc = new GraphUserModel
                {
                    accountEnabled = true
                };
                List<SignInNames> names = new List<SignInNames>();
                SignInNames name = new SignInNames
                {
                    type = "emailAddress",
                    value = userModel.email
                };
                names.Add(name);
                uc.signInNames = names;
                uc.creationType = "LocalAccount";
                uc.displayName = userModel.displayName;
                uc.passwordProfile = new PasswordProfile
                {
                    password = userModel.password,
                    forceChangePasswordNextLogin = false
                };
                uc.passwordPolicies = "DisablePasswordExpiration";

                var userString = Newtonsoft.Json.JsonConvert.SerializeObject(uc);
                await this._b2CGraphClient.CreateUser(userString);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
          
        }
    }
}
