using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Mastermind
{
    public  class Mastermind_Game
    {
        private static Random _randomizer = new Random();
        private Answer_Analyzer _analyzer;
        private List<Answer> _answers = new List<Answer>();

        public Mastermind_Game() : this(GenerateCode()) { }

        public Mastermind_Game(string code)
        {
            Code = code;
            _analyzer = new Answer_Analyzer(Code);
        }

        private static string GenerateCode(int length = 4)
        {
            var builder = new StringBuilder(length);
            for (var index = 0; index < length; index++)
                builder.Append(_randomizer.Next(1, 6));
            return builder.ToString();
        }

        public string Code { get; set; }
        public bool IsFinished { get; private set; }

        public string Guess(string guess)
        {
            var answer = new Answer
            {
                Number = _answers.Count + 1,
                Guess = guess,
                Response = _analyzer.Analyze(guess)
            };
            _answers.Add(answer);

            if (answer.Response.Trim() == "++++")
            {
                IsFinished = true;
                return $"Congratulations, you guessed correct number!)";
            }

            if (answer.Number > 9)
            {
                IsFinished = true;
                return $"Sorry,you finished all chances and you lose.\n(the number is \"{Code}\")";
            }

            return answer.Response;
        }
    }
}
