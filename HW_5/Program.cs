using BenchmarkDotNet.Running;
using HW_5.Test;
using System.Text.RegularExpressions;

namespace HW_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var analyze = new Analyz.StringAnalyz();
            string input = "Привіт привіт, це курс курс по дотнету дотнету.";
            string output = string.Empty;

            output = analyze.AnalyzeForDuplicates(input);

            Console.WriteLine($"String before: {input}");
            Console.WriteLine();
            Console.WriteLine($"String after: {output}");
            Console.WriteLine();
            Console.WriteLine("Duplicate Words were:\n");
            analyze.ShowDuplicates(input);

            //BenchmarkRunner.Run<TestsBenchmark>();
        }
    }
}