using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PremiumCalc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Create and object of model, just to assign list of occupation
            var viewCustModel = new CustomerModel();

            //addding dummy data. this will come from WebAPI in real development
            //The same i could achieve using viewbag as well but just trying to simulate close to real
            viewCustModel.Occupations = GetOccupationList();

            return View(viewCustModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Populate Occupation list with Hard coded values
        private IEnumerable<Occupation> GetOccupationList()
        {

            return new List<Occupation>
            {
            new Occupation
            {
            OccupationName = "Cleaner", OccupationRating = "Light Manual"
            }

            , new Occupation
            {
            OccupationName = "Doctor",OccupationRating = "Professional"
            }

            , new Occupation
            {
            OccupationName = "Author", OccupationRating ="White Collar"
            }

              , new Occupation
            {
            OccupationName  = "Farmer", OccupationRating="Heavy Manual"
            }

                , new Occupation
            {
             OccupationName= "Mechanic", OccupationRating ="Heavy Manual"
            }
                  , new Occupation
            {
             OccupationName= "Florist", OccupationRating="Light Manual"
            }
                    , new Occupation
            {
            OccupationName = "Cleaner", OccupationRating ="Light Manual"
            }
                      , new Occupation
            {
            OccupationName = "Doctor", OccupationRating ="Professional"
            }
            }

            ;
        }

    }
}
