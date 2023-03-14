namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReturnTrueIfDivisibleBy4()
        {
            LeapYear leapyear = new LeapYear(); 
            var result = leapyear.isDivisibleBy4(4);
            Assert.True(result);
        }
    }
}