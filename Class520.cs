using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    public class Class520
    {
        public bool DetectCapitalUse(string word)
        {
            var upper = word.ToUpper();
            var lower = word.ToLower();
            var mix = word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            if (word == upper || word == lower || word == mix) return true;
            return false;
        }
    }
}
