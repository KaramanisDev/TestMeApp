namespace TestME
{
    public class Answer
    {
        private string _text;
        private bool _correct;

        public Answer(string text, bool correct)
        {
            this._text = text;
            this._correct = correct;
        }

        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        public bool correct
        {
            get { return _correct; }
            set { _correct = value; }
        }
    }
}
