using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestME
{
    public static class Globals
    {
        private static DB _db = new DB();
        private static List<string> _tags = new List<string>();
        private static User _user;
        private static bool _Connected = false;
        private static EventWaitHandle _waitHandle = new AutoResetEvent(false);
        private static string _filesPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\TestME\\";

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

        public static bool Connected
        {
            get { return _Connected; }
            set { _Connected = value; }
        }

        public static string FilesPath
        {
            get { return _filesPath; }
            set { _filesPath = value; }
        }

    }
}
