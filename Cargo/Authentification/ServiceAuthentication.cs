using System.IdentityModel;
using System.Security;

namespace ServiceAuthentication
{
    public class CustomUserNameValidator : System.IdentityModel.Selectors.UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName != "TestUser" || password != "123")
            {
                throw new SecurityException("Error login");
            }
        }
    }
}