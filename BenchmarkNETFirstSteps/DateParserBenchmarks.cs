using System;
using BenchmarkDotNet.Attributes;

namespace BenchmarkNETFirstSteps
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class DateParserBenchmarks
    {
        private const string DateTime = "2022-04-13T00:40:06Z";
        private static readonly DateParser _parser = new();

        [Benchmark]
        public void GetYearFromDateTime()
        {
            _parser.GetYearFromDateTime(DateTime);
        }

        
        [Benchmark]
        public void GetYearFromSplit()
        {
            _parser.GetYearFromSplit(DateTime);
        }

        [Benchmark]
        public void GetYearFromSubstring()
        {
            _parser.GetYearFromSubstring(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpan()
        {
            _parser.GetYearFromSpan(DateTime);
        }

        [Benchmark]
        public void GetYearFromSpanWithManualConversion()
        {
            _parser.GetYearFromSpanWithManualConversion(DateTime);
        }
    }
}