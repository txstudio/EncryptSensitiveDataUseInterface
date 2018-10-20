using System;
using System.Collections.Generic;
using System.Text;

namespace AddEncryptPropertyApp
{
    public interface ISensitiveUserProperty
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        string Email { get; set; }
    }

    public sealed class User : ISensitiveUserProperty
    {
        public int No { get; set; }
        public string Email { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EnglishFirstName { get; set; }
        public string EnglishLastName { get; set; }
    }
}
