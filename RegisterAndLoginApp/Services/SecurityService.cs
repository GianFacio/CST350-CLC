using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public class SecurityService
    {
        SecurityDAO securityDAO = new SecurityDAO();

        public bool isValid(Register user)
        {
            return securityDAO.FindUserByNameAndPassword(user);
        }

        public void RegisterUser (Register user)
        {
            securityDAO.RegisterUser(user);
        }
    }
}
