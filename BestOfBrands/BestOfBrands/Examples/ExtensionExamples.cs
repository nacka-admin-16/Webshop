using System.Globalization;

namespace BestOfBrands.Examples
{
    public static class ExtensionExamples
    {
        public static int CountWords(this string myString)
        {
            var words = myString.Trim().Split(' ');
            
            return words.Length;
        }
        
        public static bool ContainsChar(this string myString, string myChar)
        {
            var status = myString.Contains(myChar);
            
            return status;           
        }
        
        public static string FirstLetterToUpper(this string myString)
        {
            return char.ToUpper(myString[0]) + myString.Substring(1);            
        }

        public static string FirstLetterInEveryWordToUpper(this string myString)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myString.ToLower());
        }
    }
}