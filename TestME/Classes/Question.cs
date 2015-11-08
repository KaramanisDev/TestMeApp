using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestME.Classes
{
    class Question
    {
        private string _question;
        private List<Answer> _anwsers;
        private bool _prive;


        public Question(string q, List<Answer> a, bool p)
        {
            this._question = q;
            this._anwsers = a;
            this._prive = p;
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

        public bool prive
        {
            get { return _prive; }
            set { _prive = value; }
        }

    }
}
