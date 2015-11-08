using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestME
{
    class User
    {
        int _id;
        string _user;
        string _pass;
        string _email;

        User(int i,string u,string p,string e)
        {
            this._id = i;
            this._user = u;
            this._pass = p;
            this._email = e;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string user
        {
            get { return _user; }
            set { _user = value; }
        }

        public string pass
        {
            get { return _pass; }
            set { _pass = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
