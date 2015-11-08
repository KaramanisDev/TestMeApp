using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestME
{
    public static class Globals
    {
        private static List<string> _tags;
        private static User _user;

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
