using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebAppPractice.Models
{
    public class Candy
    {
        public string Name { get; set; }
        public string ImageURL { get; set; }
        public List<string> Ingredients { get; set; }
        public bool HasChocolate { get; set; }
        public int Calories { get; set; }


    }
}
