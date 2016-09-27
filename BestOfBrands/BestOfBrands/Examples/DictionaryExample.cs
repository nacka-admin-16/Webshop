using System;
using System.Collections.Generic;

namespace BestOfBrands.Examples
{
    public class DictionaryExample
    {
        public void GetCities()
        {
            var dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            dictionary.Add("Stockholm", "8678680,y6876780");
            dictionary.Add("Paris", "48.858093,2.294694");
            dictionary.Add("London", "51.508530,-0.076132");

            //sök efter key
            if (dictionary.ContainsKey("Stockholm"))
            {                
            }

            //sök efter value
            if (dictionary.ContainsValue("8678680"))
            {                
            }

            //tömma dictionary
            dictionary.Clear();

            //ta bort element från dictionary
            dictionary.Remove("Stockholm");

            //loopa över en dictionary
            foreach (var keyvalue in dictionary)
            {
                var key = keyvalue.Key;
                var value = keyvalue.Value;
            }            
        }
    }
}