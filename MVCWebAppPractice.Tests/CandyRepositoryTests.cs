using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MVCWebAppPractice.Tests
{
    public class CandyRepositoryTests
    {
        [Fact]
        public void Index_Fills_Model_With_All_Candies()
        {
            var candyRepo = new CandyRepository();

            var result = candyRepo.GetAll();

            Assert.NotEmpty(result);
        }

    }
}
