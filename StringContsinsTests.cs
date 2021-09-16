using NUnit.Framework;
using System.Diagnostics;

namespace Lab2._5.Tests
{
    public class Tests
    {

        [OneTimeSetUp]
        public void StartTest()
        {
            Trace.Listeners.Add(new ConsoleTraceListener());
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            Trace.Flush();
        }

        [TestCase("00aa")]
        [TestCase("00AA")]
        [TestCase("a0a0")]
        [TestCase("aaaa")]
        public void String_Contains_00(string input)
        {
            Assert.That(input.Contains("00"),"no");
            Trace.WriteLine("yes");
        }

        [TestCase("00aa")]
        [TestCase("00AA")]
        [TestCase("a0a0")]
        [TestCase("aaaa")]
        public void String_Contains_aa(string input)
        {
            Assert.IsTrue(input.Contains("aa"),"no");
            Trace.WriteLine("yes");
        }
    }
}