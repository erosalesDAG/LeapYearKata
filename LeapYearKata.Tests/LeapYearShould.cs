namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        private LeapYear leapYear;

        [SetUp]
        public void Setup()
        {
            leapYear = new LeapYear();
        }

        [TestCase(4)]
        [TestCase(64)]
        [TestCase(512)]
        public void CheckYearIsDivisibleBy4(int year)
        {
            var result = leapYear.IsDivisibleBy4(year);
            Assert.True(result);
        }

        [TestCase(5)]
        [TestCase(21)]
        [TestCase(57)]
        public void CheckYearIsNotDivisibleBy4(int year)
        {
            var result = leapYear.IsDivisibleBy4(year);
            Assert.False(result);
        }

        [TestCase(500)]
        [TestCase(100)]
        [TestCase(1500)]
        public void CheckYearIsDivisibleBy100(int year)
        {
            var result = leapYear.IsDivisibleBy100(year);
            Assert.True(result);
        }

        [TestCase(501)]
        [TestCase(750)]
        [TestCase(1492)]
        public void CheckYearIsNotDivisibleBy100(int year)
        {
            var result = leapYear.IsDivisibleBy100(year);
            Assert.False(result);
        }

        [TestCase(400)]
        [TestCase(1600)]
        [TestCase(800)]
        public void CheckYearIsDivisibleBy400(int year)
        {
            var result = leapYear.IsDivisibleBy400(year);
            Assert.True(result);
        }

        [TestCase(2000, true)]
        [TestCase(2020, true)]
        [TestCase(1900, false)]
        public void CheckIsLeapYearIfDivisibleBy4AndNotBy100(int year, bool expectedResult)
        {
            var result = leapYear.IsLeapYear(year);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(5, false)]
        [TestCase(4, true)]
        [TestCase(19, false)]
        public void CheckItIsNotLeapYearIfNotDivisibleBy4(int year, bool expectedResult)
        {
            var result = leapYear.IsLeapYear(year);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(800, true)]
        [TestCase(1210, false)]
        [TestCase(1600, true)]
        public void CheckIsLeapYearIfDivisibleBy400(int year, bool expectedResult)
        {
            var result = leapYear.IsLeapYear(year);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}