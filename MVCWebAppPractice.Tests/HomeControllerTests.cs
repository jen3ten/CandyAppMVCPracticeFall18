using Microsoft.AspNetCore.Mvc;
using MVCWebAppPractice.Controllers;
using MVCWebAppPractice.Models;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace MVCWebAppPractice.Tests
{
    public class HomeControllerTests
    {
        //This is common to all tests that need candyRepo and sut
        //Two fields have been defined and they are set in the HomeControllerTests class constructor
        private ICandyRepository candyRepo;
        private HomeController sut;

        public HomeControllerTests()
        {
            candyRepo = Substitute.For<ICandyRepository>(); //This is the mock
            sut = new HomeController(candyRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = sut.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_AllCandies() 
        //HomeController instance was created, 
        //Did the repo receive the GetAll() call?
        {
            sut.Index();

            candyRepo.Received().GetAll();
        }

        [Fact]
        public void Index_Sets_Model_To_AllCandies()
        {
            var expectedModel = new List<Candy>();
            var result = sut.Index();
            candyRepo.GetAll().Returns(expectedModel);
        }

        [Fact]
        public void Details_Gets_One_Candy()
        {
            sut.Details("Snickers");

            candyRepo.Received().FindByName("Snickers");
        }
    }
}
