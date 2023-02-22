using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;

namespace HW_5.Analyz
{
    internal class StringAnalyz
    {
        [StringSyntax(StringSyntaxAttribute.Regex)]
        string Pattern { get; }
        string Result { get; set; }

        public StringAnalyz()
        {
            Pattern = @"\b #границя слова
                        (\w+) #перша группа захвату співпадіння, будь-яка літера або ціфра в кількості від 1 і більше
                        (?: #группа без захвату
                        \W+ #знак крім літери або ціфри в кількості від 1 і більше
                        \1  #співпадає з текстом, який був захвачений в першу групу
                        \b #границя слова
                         )";
            Result = string.Empty;
        }

        public string AnalyzeForDuplicates(string input)
        {
            Regex regex = new Regex(Pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

            foreach (Match match in regex.Matches(input))
            {
                Result = regex.Replace(input, "$1");
            }
            return Result;
        }
        public void ShowDuplicates(string input)
        {
            Regex regex = new Regex(Pattern, RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

            foreach (Match match in regex.Matches(input))
            {
                Console.WriteLine(match.Groups[1].Value);
            }            
        }
    }
}
