namespace Use_Case_.Net_Regex_Nazarii_Ivasyshyn.Tests
{
  public class RegexImplementationTests
  {
    private readonly int _length = 12;
    
    [Theory]
    [InlineData("")]
    [InlineData("Jasdf@df!342feeee")]
    [InlineData("jasdf@df!34")]
    [InlineData("JASDF@DF!34")]
    [InlineData("JASDF@DF!aa")]
    [InlineData("JASDFFDFF3")]
    [InlineData("JASa$F DFF3")]
    [InlineData(" JASa$DFF3")]
    [InlineData("JASa$DFF3 ")]
    [InlineData("JASD\na$FF3")]
    [InlineData("JASD a$FF3")]
    public void ShouldNotPass(string input)
    {
      // Act
      var result = RegexInplementation.Matches(input, _length);

      // Assert
      Assert.False(result);
    }

    [Theory]
    [InlineData("AAaaaaa%aa3a")]
    [InlineData("Aa%3")]
    public void ShouldPass(string input)
    {
      // Act
      var result = RegexInplementation.Matches(input, _length);

      // Assert
      Assert.True(result);
    }
  }
}