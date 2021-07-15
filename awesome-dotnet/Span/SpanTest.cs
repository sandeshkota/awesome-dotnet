using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awesome_dotnet.Span
{
    [MemoryDiagnoser]
    public class SpanTest
    {
        private static readonly string dateText = "15 07 2021";

        [Benchmark]
        public (int day, int month, int year) GetDateWithString_Substring()
        {
            var dayText = dateText.Substring(0, 2);
            var monthText = dateText.Substring(3, 2);
            var yearText = dateText.Substring(6);
            var day = int.Parse(dayText);
            var month = int.Parse(monthText);
            var year = int.Parse(yearText);
            return (day, month, year);
        }

        [Benchmark]
        public (int day, int month, int year) GetDateWithString_Span()
        {
            ReadOnlySpan<char> dateAsSpan = dateText;
            var dayText = dateAsSpan.Slice(0, 2);
            var monthText = dateAsSpan.Slice(3, 2);
            var yearText = dateAsSpan.Slice(6);
            var day = int.Parse(dayText);
            var month = int.Parse(monthText);
            var year = int.Parse(yearText);
            return (day, month, year);
        }

        public static void RunTest()
        {
            // set to "Release" mode and run (ctrl + F5)
            BenchmarkRunner.Run<SpanTest>();
        }

        public static void ConsolePrinter()
        {
            var spanTest = new SpanTest();

            var dateFromSubstring = spanTest.GetDateWithString_Substring();
            Console.WriteLine("----- Substring Way -----");
            Console.WriteLine(dateFromSubstring);

            Console.WriteLine();

            var dateFromSpan = spanTest.GetDateWithString_Span();
            Console.WriteLine("----- Span Way -----");
            Console.WriteLine(dateFromSpan);
        }
    }
}
