namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4)]
        [TestCase(64)]
        [TestCase(512)]
        public void ReturnTrueIfDivisibleBy4(int year)
        {
            LeapYear leapyear = new LeapYear();
            var result = leapyear.IsDivisibleBy4(year);
            Assert.True(result);
        }

        [TestCase(5)]
        [TestCase(21)]
        [TestCase(57)]
        public void ReturnFalseIfNotDivisibleBy4(int year)
        {
            LeapYear leapyear = new LeapYear();
            var result = leapyear.IsDivisibleBy4(year);
            Assert.False(result);
        }

        [TestCase(500)]
        [TestCase(100)]
        [TestCase(1500)]
        public void ReturnTrueIfDivisibleBy100(int year)
        {
            LeapYear leapYear = new LeapYear();
            var result = leapYear.IsDivisibleBy100(year); 
            Assert.True(result);
        }
        [TestCase(501)]
        [TestCase(750)]
        [TestCase(1492)]
        public void ReturnFalseIfNotDivisibleBy100(int year)
        {
            LeapYear leapYear = new LeapYear();
            var result = leapYear.IsDivisibleBy100(year);
            Assert.False(result);
        }
    }
}