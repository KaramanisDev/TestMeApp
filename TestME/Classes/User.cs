namespace TestME
{
    public class User
    {
        int _id;
        string _user;
        string _pass;
        string _email;
        string _scode;

        public User(int i,string u,string p,string e,string scode)
        {
            this._id = i;
            this._user = u;
            this._pass = p;
            this._email = e;
            this._scode = scode;
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
        public string scode
        {
            get { return _scode; }
            set { _scode = value; }
        }
    }
}
