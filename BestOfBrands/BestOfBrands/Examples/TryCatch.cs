using System;
using System.IO;
using BestOfBrands.Configuration;

namespace BestOfBrands.Examples
{
    public class TryCatch
    {
        public int ConvertStringToInt(string myString)
        {
            try
            {
                return Convert(myString);
            }
            catch (Exception exception)
            {
                using (StreamWriter streamWriter = new StreamWriter(SiteConstants.PathToExceptionLog(), true))
                {
                    streamWriter.WriteLine(DateTime.Now + " " + exception.Message);
                }

                return -1;                
            }
        }

        public int Convert(string myString)
        {
            try
            {
                var convertedString = int.Parse(myString);

                return convertedString;
            }
            finally
            {
                using (StreamWriter streamWriter = new StreamWriter(SiteConstants.PathToExceptionLog(), true))
                {
                    streamWriter.WriteLine(DateTime.Now + " knas");
                }                
            }
        }
    }
}













//try
//{
//    var convertedString = int.Parse(myString);

//    return convertedString;
//}
//catch (Exception exception)
//{
//    using (StreamWriter streamWriter = new StreamWriter(SiteConstants.PathToExceptionLog()))
//    {
//        streamWriter.WriteLine(DateTime.Now + " " + exception.Message);
//    }

//    return -1;
//}