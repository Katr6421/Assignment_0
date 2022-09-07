namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void IsLeapYearCorrect(){

       var year = 1600;

       var output = Program.IsLeapYear(year);
        
    
       Assert.Equal(false, output);

    }

    [Theory]
    [InlineData(1600, true)]
    [InlineData(1603, false)]
    [InlineData(1604, true)]
    [InlineData(2000, true)]
    [InlineData(1800, false)]
    [InlineData(1900, false)]
    public void IsLeapYearCorrect2(int year, bool exp){
        var actual = Program.IsLeapYear(year);

         Assert.Equal(actual, exp);
    }


    




}