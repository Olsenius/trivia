using System.Collections.Generic;

namespace Trivia.AcceptanceTest
{
    public class Helper
    {
        private readonly Stack<int> _dices = new Stack<int>();
        private readonly Stack<bool> _answers = new Stack<bool>();

        private const string _randomDices = "3,3,1,4,5,2,3,4,4,5,2,4,3,1,3,2,3,5,4,3,1,4,4,5,5,2,2,3,2,1,2,3,4,1,1,1,2,5,1,3,3,1,3,4,2,2,5,5,5,2,5,4,2,5,5,5,5,1,5,4,1,5,2,4,3,5,1,2,1,3,1,3,4,2,5,1,2,1,3,3,3,2,4,5,2,4,1,4,2,1,2,1,1,3,2,4,4,5,1,3,2,3,4,3,2,2,5,1,1,5,4,4,3,3,2,5,2,3,3,5,5,2,1,5,2,1,3,2,1,2,2,3,1,1,1,5,3,1,4,5,4,1,4,3,3,3,3,4,2,2,2,2,3,1,4,5,2,5,1,2,5,4,5,4,3,2,4,3,2,2,2,1,4,3,2,4,4,4,3,4,3,5,1,4,5,5,5,5,3,1,4,4,5,3,5,1,1,5,5,2,5,1,2,1,5,2,4,5,5,5,2,4,3,3,4,1,4,2,4,3,2,5,5,1,3,4,1,2,3,2,4,4,4,1,5,3,3,5,4,4,2,1,5,4,5,5,2,3,4,5,2,5,1,2,1,1,1,2,3,2,2,2,2,4,1,3,5,2,4,1,3,4,3,1,1,1,5,1,2,4,3,3,3,4,5,4,3,2,1,5,2,2,3,3,3,5,5,2,3,2,1,5,5,3,2,4,3,1,1,5,1,5,5,5,4,4,5,3,4,3,1,3,2,5,5,2,1,5,4,2,2,4,4,1,3,3,4,5,2,2,2,3,1,1,4,2,2,4,4,5,1,2,3,1,2,3,3,1,4,1,3,3,2,5,4,2,2,5,2,2,5,5,2,3,1,3,2,2,1,3,5,3,2,5,1,5,2,3,5,5,5,4,2,1,4,5,1,2,2,3,1,3,2,3,5,2,5,5,1,4,2,2,5,2,1,1,1,3,5,4,1,4,1,2,2,1,4,1,5,1,2,1,5,4,2,3,1,4,5,4,5,3,3,1,4,4,4,5,1,4,4,4,2,3,2,2,2,1,2,4,4,5,5,5,2,1,2,2,5,4,5,2,3,1,4,4,2,5,4,4,3,4,1,2,2,4,5,2,2,1,1,1,3,1,1,1,3,3,5,3,2,3,1,2,4,2,1,1,5,4,1,3,2,4,2,1,4,4,3,3,2,1,1,5,3,5,5,2,1,4,1,4,1,1,2,1,3,4,3,5,3,4,3,4,1,4,4,5,5,1,2,4,1,2,1,2,3,2,4,5,3,4,1,2,3,2,2,2,2,2,3,5,1,3,1,4,3,3,4,5,1,5,3,5,2,2,4,4,1,1,3,2,1,4,3,4,3,2,1,4,2,3,4,4,3,2,4,3,2,3,4,1,3,5,4,4,2,1,5,1,3,4,2,1,4,1,5,3,1,2,1,1,2,5,3,4,2,5,3,5,4,2,3,3,3,3,5,1,5,4,3,3,2,5,2,4,2,3,5,3,3,1,2,5,2,3,4,3,3,1,2,3,4,1,2,2,1,4,4,1,2,5,3,2,5,4,4,2,4,4,3,4,5,1,3,4,5,4,2,5,5,3,3,5,2,5,4,2,3,5,4,3,5,4,1,3,3,5,5,4,4,2,4,5,3,4,3,4,3,4,2,3,2,4,2,5,2,4,5,5,5,3,5,4,1,5,5,1,5,5,1,1,4,4,2,3,4,4,2,4,3,1,5,4,4,2,2,1,3,2,1,5,5,5,4,2,3,5,4,4,4,2,4,3,4,2,4,4,2,4,1,4,3,2,3,5,3,1,1,5,4,4,4,3,5,2,1,4,5,1,1,5,5,3,1,1,2,2,1,2,3,3,5,5,2,3,2,4,2,5,4,3,4,5,1,1,4,2,4,3,2,5,4,2,4,2,4,5,1,3,3,2,5,5,2,1,5,5,2,2,5,2,2,1,2,4,1,1,3,1,3,1,3,4,1,3,4,3,2,1,5,2,3,5,2,3,3,5,4,5,1,5,1,3,3,5,3,4,1,5,1,4,3,1,1,3,4,2,4,4,2,3,4,2,2,3,4,3,4,5,1,1,2,3,5,4,1,1,2,1,5,1,2,2,5,2,5,3,5,5,4,2,2,5,3,4,1,4,1,5,2,1,5,2,5,1,2,1,2,2,3,4,5,3,4,2,1,3,2,1,4,2,3,5,1,4,5,3,5,2,3,2,5,2,5,5,1,1,2,5,5,5,2,3,3,1,2,4,1,2";
        private const string _randomAnswers = "1,0,0,0,0,0,0,0,1,1,1,1,0,1,1,1,1,1,1,1,0,0,1,0,0,0,0,1,0,1,1,0,0,0,1,0,1,1,0,1,1,1,1,1,1,1,0,1,0,0,0,1,0,1,1,0,0,0,1,1,0,1,1,0,0,1,0,0,1,1,1,1,1,0,1,1,0,0,0,1,1,1,0,0,0,0,1,1,0,0,1,1,1,0,0,0,1,1,1,0,0,0,1,0,0,1,1,0,1,0,0,0,1,0,1,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,0,0,1,1,0,1,0,1,1,0,0,1,0,0,1,1,1,0,1,0,0,1,1,0,0,1,0,1,0,1,0,1,0,0,1,1,1,0,0,1,0,1,0,0,1,1,0,0,0,0,0,0,1,1,1,1,1,1,0,1,0,1,1,0,0,0,1,0,1,1,1,0,1,0,0,0,1,0,1,0,1,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,1,0,1,0,0,1,0,1,1,1,1,0,1,1,1,0,0,0,1,0,0,0,0,1,1,0,0,1,1,0,0,1,0,0,0,1,0,1,1,1,1,1,1,1,0,1,0,0,0,1,0,1,0,1,0,1,1,0,1,1,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,1,0,1,0,0,1,0,1,1,0,0,0,0,1,1,1,1,0,1,0,1,1,1,0,1,0,1,1,1,1,0,0,0,0,1,0,0,1,1,0,0,0,1,0,1,0,1,1,1,1,0,1,1,1,1,1,1,0,1,1,0,0,0,0,1,0,0,1,0,1,0,0,1,1,1,0,0,1,0,0,0,1,0,0,0,0,1,0,0,1,1,1,1,1,1,0,0,0,0,1,0,0,0,1,0,0,0,1,0,1,1,1,1,0,0,0,0,0,0,1,0,1,0,1,0,0,0,1,1,1,0,1,1,1,0,0,0,0,1,1,1,0,0,1,1,1,0,1,1,0,0,1,0,0,1,0,1,1,1,1,0,0,1,1,0,0,1,0,0,1,0,1,0,1,1,0,1,1,0,0,0,1,0,1,0,0,1,1,1,1,1,1,0,1,1,1,0,1,0,1,1,1,0,1,0,0,0,0,1,1,1,0,1,1,1,1,1,0,0,0,1,0,1,0,0,0,1,1,0,0,1,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,1,0,0,0,0,1,1,0,0,1,0,1,0,0,1,1,1,0,0,1,1,0,0,1,0,0,0,0,0,1,0,0,1,0,0,1,1,0,0,1,1,1,0,0,1,0,1,1,1,0,0,1,0,0,0,0,1,1,0,1,0,1,0,1,1,0,0,0,0,1,0,1,1,1,1,1,0,1,1,1,1,1,1,1,0,0,1,0,1,1,1,0,1,1,0,0,0,1,1,1,0,0,0,1,1,1,0,0,0,1,0,0,1,0,1,0,1,0,0,0,0,1,1,0,0,0,1,1,0,1,0,1,1,0,1,1,0,0,0,1,0,0,1,0,1,1,1,1,0,0,1,0,0,1,0,0,0,0,0,1,1,0,0,1,0,0,0,0,1,0,1,0,0,0,1,0,1,1,1,1,1,0,1,0,1,0,0,0,0,0,0,0,1,0,0,1,0,0,1,0,0,0,1,1,0,0,1,1,1,0,0,1,0,1,0,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,1,1,0,1,0,0,0,1,1,1,0,0,0,0,1,0,0,0,1,1,0,0,0,1,0,1,1,0,1,1,1,1,1,1,0,0,1,1,0,1,1,1,0,1,1,1,0,0,1,1,0,0,0,1,1,1,1,0,0,1,1,0,0,0,1,1,1,0,1,1,1,0,1,1,1,0,0,0,1,1,0,0,1,0,0,1,0,1,0,1,0,0,0,0,0,1,1,1,1,1,1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,1,0,1,0,0,1,0,0,0,1,1,0,1,1,1,0,1,0,1,0,0,1,0,0,0,0,1,1,0,0,1,1,0,0,0,0,1,1,1,0,1,0,1,0,0,0,1,0,1,0,1,0,0,1,0,1,0,1,0,0,1,1,0,0,1,0,0,1,1,0,0,1,0,1,1,1,1,1,0,0,0,1,1,1,0,0,0,0,1,0,0,0,1,0,0,0,1,1,1";

        public Helper()
        {
            LoadDices();
            LoadAnswers();
        }

        private void LoadDices()
        {
            var split = _randomDices.Split(',');
            foreach (var s in split)
            {
                _dices.Push(int.Parse(s));
            }
        }
        private void LoadAnswers()
        {
            var split = _randomAnswers.Split(',');
            foreach (var s in split)
            {
                _answers.Push(int.Parse(s) == 1);
            }
        }

        public int Throw()
        {
            if (_dices.Count == 0)
                LoadDices();
            return _dices.Pop();
        }

        public bool Answer()
        {
            if (_answers.Count == 0)
                LoadAnswers();
            return _answers.Pop();
        }
    }
}