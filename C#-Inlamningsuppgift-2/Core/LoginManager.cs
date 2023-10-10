using System;

namespace Core
{
    public class LoginManager
    {
        public bool NewUserRegistered(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }
    }
}
