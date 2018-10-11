using System.Collections.Generic;
using MVCWebAppPractice.Models;

namespace MVCWebAppPractice.Tests
{
    public class CandyRepository : ICandyRepository
    {
        public CandyRepository()
        {
        }

        List<Candy> AllCandies = new List<Candy>()
        {
            new Candy()
            {
                Name = "Snickers",
                Calories = 300,
                HasChocolate = true,
                ImageURL = "https://www.snickers.com",
                Ingredients = new List<string>()
                {
                    "chocolate",
                    "peanuts",
                    "caramel",
                    "NuGet"
                }
            }
        };

        public List<Candy> GetAll()
        {
            return AllCandies;
        }

        public Candy FindByName(string name)
        {
            foreach (Candy item in AllCandies)
            {
                if (item.Name.Equals(name))
                {
                    return item;
                }
            }

            return AllCandies[0];
        }
    }
}