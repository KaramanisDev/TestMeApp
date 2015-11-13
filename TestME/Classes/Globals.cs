using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestME
{
    public static class Globals
    {
        private static string _connectionstr;
        private static List<string> _tags = new List<string>();
        private static User _user;
        private static bool _Connected = false;
        private static EventWaitHandle _waitHandle = new AutoResetEvent(false);
        private static string _filesPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static frmStart formStart = new frmStart();
        public static frmMain formMain = new frmMain();


        public static string ConnectionStr()
        {
            return _connectionstr;
        }

        public static void ConnectionStr(string host, string user, string pass, string dbname)
        {
            _connectionstr = String.Format("Server={0};Database={3};Uid={1};Pwd={2};Charset=utf8;", host, user, pass, dbname).ToString();
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

        public static EventWaitHandle waitHandle
        {
            get { return _waitHandle; }
        }
    }
}
