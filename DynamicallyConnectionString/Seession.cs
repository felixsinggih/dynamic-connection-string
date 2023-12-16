using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicallyConnectionString
{
    class Seession
    {
        public static string sees_user;
        public static string sees_database;

        public Seession()
        {
            sees_user = "";
            sees_database = "";
        }

        public String USER
        {
            get { return sees_user; }
            set { sees_user = value; }
        }

        public String DATABASE
        {
            get { return sees_database; }
            set { sees_database = value; }
        }
    }
}
