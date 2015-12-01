using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DSAndAlgorithms.RegularExpressions
{
    public static class RegularExpression
    {
        public static bool IsMatch(string pattern, string subject)
        {
            var regex = new Regex(pattern);
            var match = regex.Match(subject);
            return match.Success;
        }
    }
}
