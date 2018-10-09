using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebAppPractice.Controllers
{
    public class HomeController : Controller
    {
        private ICandyRepository candyRepo;  //private works for us here, a field of type ICandyRepository

        //Home Controller should have a constructor dependency
        //We need to have a candyRepo in order to create an instance of Home Controller
        public HomeController(ICandyRepository candyRepo)
        {
            this.candyRepo = candyRepo;
        }

        public ViewResult Index() //Could pass the candyRepo here, but use the constructor instead
        {
            this.candyRepo.GetAll();
            return View();
        }
    }
}
