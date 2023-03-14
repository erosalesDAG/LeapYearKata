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
        public void CheckYearIsNoDivisibleBy4(int year)
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
        public void CheckYearIsNoDivisibleBy100(int year)
        {
            var result = leapYear.IsDivisibleBy100(year);
            Assert.False(result);
        }


    }
}