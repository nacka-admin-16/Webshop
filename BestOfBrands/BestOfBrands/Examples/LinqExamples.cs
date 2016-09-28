using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestOfBrands.Examples
{
    public class LinqExamples
    {
        public List<int> EvenNumbers()
        {
            int[] tal = { 9, 6, 4, 7, 5, 1, 3, 4, 6, 2, 5, 74, 4, 2, 88 };

            var s = tal.Distinct().OrderByDescending(x => x).Where(x => x%2 == 0).ToList();

            return s;
        }

        public double[] ConvertToSek()
        {
            double[] housePricesInDollars = { 3.4, 5.2, 1.2, 0.7, 2.6, 2.7, 3.0 };
                   
            var housePricesInSek = housePricesInDollars.Select(x => x*8).ToArray();
            
            return housePricesInSek;
        }
    }
}