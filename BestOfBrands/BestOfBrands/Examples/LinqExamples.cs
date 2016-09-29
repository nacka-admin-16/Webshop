using System.Collections.Generic;
using System.Linq;
using BestOfBrands.tenta;


namespace BestOfBrands.Examples
{
    public class LinqExamples
    {
        public double Average()
        {
            int[] array = { 1, 3, 5, 7 };

            return array.Average();
        }

        public IEnumerable<User> GetUsers()
        {
            var users = new List<User>
            {
                new User { Name = "Carl", Email = "carl@nacka.se" },
                new User { Name = "Johanna", Email = "åsa@nacka.se" },
                new User { Name = "Kim", Email = "kim@nacka.se" }
            };

            return users;
        }
        
        public List<int> EvenNumbers()
        {
            var tal = new List<int> { 9, 6, 4, 7, 5, 1, 3, 4, 6, 2, 5, 74, 4, 2, 88 };

            var evenNumbers = tal.OrderByDescending(x => x).Distinct().Where(x => x % 2 == 0).ToList();
            //var evenNumbers = tal.FindAll(x => (x % 2) == 0).Distinct().OrderByDescending(x => x).ToList();

            return evenNumbers;
        }

        public IEnumerable<string> GetUserNames()
        {
            var users = new List<User>
            {
                new User { Name = "Carl", Email = "carl@nacka.se" },
                new User { Name = "Johanna", Email = "åsa@nacka.se" },
                new User { Name = "Kim", Email = "kim@nacka.se" }
            };

            return users.Select(x => x.Name);
        }

        public double[] ConvertToSek()
        {
            double[] housePricesInDollars = { 3.4, 5.2, 1.2, 0.7, 2.6, 2.7, 3.0 };

            var housePricesInSek = housePricesInDollars.Select(x => x * 8).ToArray();

            return housePricesInSek;
        }        
    }
}