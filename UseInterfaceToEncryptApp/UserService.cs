using System;
using System.Collections.Generic;
using System.Text;

namespace UseInterfaceToEncryptApp
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

            this.SetSensitiveData(_user);

            return new User[] { _user };
        }

        private void SetSensitiveData(ISensitiveUserProperty item)
        {
            if(string.IsNullOrWhiteSpace(item.FirstName) == false)
            {
                item.FirstName = this.ToBase64(item.FirstName);
            }

            if(string.IsNullOrWhiteSpace(item.LastName) == false)
            {
                item.LastName = this.ToBase64(item.LastName);
            }
        }

        private string ToBase64(string value)
        {
            Encoding _encoding;
            byte[] _bytes;

            if (string.IsNullOrWhiteSpace(value) == true)
                return string.Empty;

            _encoding = Encoding.GetEncoding("utf-8");
            _bytes = _encoding.GetBytes(value);

            return Convert.ToBase64String(_bytes);
        }
    }
}
