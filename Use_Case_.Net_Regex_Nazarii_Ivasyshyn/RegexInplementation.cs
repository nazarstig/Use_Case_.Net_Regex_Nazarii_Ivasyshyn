using System.Text.RegularExpressions;

namespace Use_Case_.Net_Regex_Nazarii_Ivasyshyn
{
  public static class RegexInplementation
  {
    private static readonly string _whiteSpacePattern = @"(^((?![\s\n\t]).)*$)";
    private static readonly string _symbolsPattern = @"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!#$%&'()*+,-./:;<=>?@[\]^_`{|}~]).+";

    private static readonly Regex _whiteSpaceRegex = new Regex(_whiteSpacePattern, RegexOptions.Compiled);
    private static readonly Regex _symbolsRegex = new Regex(_symbolsPattern, RegexOptions.Compiled);

    public static bool Matches(string input, int maxLength)
    {
      if (input == null || input.Length == 0 || input.Length > maxLength)
      {
        return false;
      }

      if (_whiteSpaceRegex.IsMatch(input) && _symbolsRegex.IsMatch(input))
      {
        return true;
      }

      return false;
    } 
  }
}