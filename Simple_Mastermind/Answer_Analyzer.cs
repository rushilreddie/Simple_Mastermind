using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Mastermind
{
    public class Answer_Analyzer
    {
        private readonly string _code;

        public Answer_Analyzer(string code)
        {
            _code = code;
        }

        public string Analyze(string guess)
        {
            var builder = new StringBuilder(guess.Length);

            // To visually view the response in the output window, 2 spaces are being added.
            builder.Append("  ");

            for (var index = 0; index < guess.Length; index++)
            {
                var digit = guess[index];
                var response = ' ';

                if (_code.Contains(digit))
                    response = _code[index] == digit
                        ? '+'
                        : '-';

                builder.Append(response);
            }
            return builder.ToString();
        }
    }
}
