using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5.Test
{
    public class TestsBenchmark
    {
        private const string Input = "Привіт привіт, це курс курс по дотнету дотнету.";

        [Benchmark]
        public void GeneratedMatch()
        {
            RegexBenchmark.GeneratedMatch(Input);
        }

        [Benchmark]
        public void CompiledMatch()
        {
            RegexBenchmark.CompiledMatch(Input);
        }

        [Benchmark]
        public void SimpleMatch()
        {
            RegexBenchmark.SimpleMatch(Input);
        }
    }
}
