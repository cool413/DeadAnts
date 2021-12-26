using FluentAssertions;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        private DeadAnts.DeadAnts _deadAnts;
        
        [SetUp]
        public void Setup()
        {
            _deadAnts = new DeadAnts.DeadAnts();
        }

        [Test]
        [TestCase("", 0)]
        [TestCase(null, 0)]
        [TestCase("ant ant ant ant", 0)]
        [TestCase("ant anantt aantnt", 2)]
        [TestCase("ant ant ant ant", 0)]
        public void Can_Count_Dead_Ants(string input, int expect)
        {
            var result = _deadAnts.DeadAntCount(input);
            result.Should().Be(expect);
        }
    }
}