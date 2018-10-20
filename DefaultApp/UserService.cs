using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultApp
{
    public sealed class UserService
    {
        public IEnumerable<User> GetUsers()
        {
            User _user = new User();

            _user.No = 1;
            _user.FirstName = "命名";
            _user.LastName = "未";
            _user.EnglishFirstName = "No-Name";
            _user.EnglishLastName = "Tsai";
            _user.Email = "tsai-no-name@txstudio.com";

            return new User[] { _user };
        }

    }
}
