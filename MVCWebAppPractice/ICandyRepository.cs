using MVCWebAppPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebAppPractice
{
    public interface ICandyRepository
    {
        List<Candy> GetAll();
        Candy FindByName(string name);
    }
}
