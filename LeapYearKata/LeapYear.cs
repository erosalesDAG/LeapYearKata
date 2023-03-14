namespace LeapYearKata;

public class LeapYear
{
    public bool IsDivisibleBy4(int year)
    {
        return year % 4 == 0;
    }

    public bool IsDivisibleBy100(int year)
    {
        return year % 100 == 0;
    }

    public bool IsDivisibleBy400(int year)
    {
        return  year % 400 == 0;
    }

    public bool IsLeapYear(int year)
    {
        return true;
    }
}