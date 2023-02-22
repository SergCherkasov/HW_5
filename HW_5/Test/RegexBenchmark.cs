using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_5.Test
{
    public partial class RegexBenchmark
    {
        [StringSyntax(StringSyntaxAttribute.Regex)]
        private const string Pattern = @"\b(\w+)(?:\W+\1\b)";

        [GeneratedRegex(Pattern, RegexOptions.None)]
        private static partial Regex DuplicatesRegex();

        private static Regex CompiledRegex = new Regex(Pattern, RegexOptions.Compiled);

        private static Regex Regex = new Regex(Pattern);

        public static Match GeneratedMatch(string input)
        {
            return DuplicatesRegex().Match(input);
        }
        public static Match CompiledMatch(string input)
        {
            return CompiledRegex.Match(input);
        }
        public static Match SimpleMatch(string input)
        {
            return Regex.Match(input);
        }


    }
}
