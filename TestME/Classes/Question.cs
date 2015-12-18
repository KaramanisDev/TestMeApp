using System.Collections.Generic;

namespace TestME
{
    public class Question
    {
        private int _id;
        private string _question;
        private List<Answer> _anwsers;
        private int _dlevel; 
        private bool _prive;

        public Question() { }

        public Question(int id,string question, List<Answer> answers, int dlevel,bool prive)
        {
            this._id = id;
            this._question = question;
            this._anwsers = answers;
            this._dlevel = dlevel;
            this._prive = prive;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string question
        {
            get { return _question; }
            set { _question = value; }
        }
        
        public List<Answer> anwsers
        {
            get { return _anwsers; }
            set { _anwsers = value; }
        }

        public int dlevel
        {
            get { return _dlevel; }
            set { _dlevel = value; }
        }

        public bool prive
        {
            get { return _prive; }
            set { _prive = value; }
        }

    }
}
