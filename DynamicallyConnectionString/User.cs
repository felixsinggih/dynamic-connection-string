using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicallyConnectionString
{
    class User
    {
        private String _username;
        private String _password;

        public User()
        {
            _username = "";
            _password = "";
        }

        public String USERNAME
        {
            get { return _username; }
            set { _username = value; }
        }
        public String PASSWORD
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
