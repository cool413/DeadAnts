using FluentAssertions;
using NUnit.Framework;

namespace UnitTest
{
    public class DeadAntsTests
    {
        private DeadAnts.DeadAnts _deadAnts;
        
        [SetUp]
        public void Setup()
        {
            _deadAnts = new DeadAnts.DeadAnts();
        }

        [Test]
        [TestCase(null, 0)]
        [TestCase("", 0)]
        [TestCase("ant ant ant ant", 0)]
        [TestCase("ant anantt aantnt", 2)]
        [TestCase("ant ant .... a nt", 1)]
        public void Can_count_dead_ants(string input, int expect)
        {
            var result = _deadAnts.DeadAntCount(input);
            result.Should().Be(expect);
        }
    }
}