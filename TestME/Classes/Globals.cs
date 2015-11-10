using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestME
{
    public static class Globals
    {
        private static DB _db;
        private static List<string> _tags;
        private static User _user;

        public static DB db
        {
            get { return _db; }
            set { _db = value; }
        }

        public static List<string> colTags
        {
            get { return _tags; }
            set { _tags = value; }
        }

        public static User logUser
        {
            get { return _user; }
            set { _user = value; }
        }


    }
}
