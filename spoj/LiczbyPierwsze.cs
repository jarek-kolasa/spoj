using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoj
{
    public class LiczbyPierwsze
    {
        public string _answer;
        public int _value;

        public LiczbyPierwsze(int value, string answer)
        {
            _answer = answer;
            _value = value;
        }

        public string GetAnswer()
        {
            return _answer;
        }
    }
}
