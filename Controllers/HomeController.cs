using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using moment2.Models;

namespace MyApp.Namespace
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            //hämtar data fron json fil
            string jsonStr = System.IO.File.ReadAllText("dogs.json");

            //desrialize
            var dogs = JsonSerializer.Deserialize<List<DogModel>>(jsonStr);
            //vy med parameter passning
            return View(dogs);
        }
        //ny sökväg
        [Route("/adoption")]
        public ActionResult Adoption()
        {
            //hämar data från json fil
            string jsonStr = System.IO.File.ReadAllText("dogs.json");

            //desrialize
            var dogs = JsonSerializer.Deserialize<List<DogModel>>(jsonStr);
            return View(dogs);
        }
        //Ny sökväg
        [Route("/hundar")]
        public ActionResult Dogs()
        {

            return View();
        }

        //Post förfrågan
        [Route("/hundar")]
        [HttpPost]
        public ActionResult Dogs(DogModel model)
        {
            //validera input
            if (ModelState.IsValid)
            {
                //korrekt ifyllt
                string jsonStr = System.IO.File.ReadAllText("dogs.json");

                //desrialize
                var dogs = JsonSerializer.Deserialize<List<DogModel>>(jsonStr);

                //lägg til ny hund
                if (dogs != null)
                {
                    dogs.Add(model);
                    //Serialize JSON
                    jsonStr = JsonSerializer.Serialize(dogs);
                    //spara ändring till json fil
                    System.IO.File.WriteAllText("dogs.json", jsonStr);
                    ViewBag.Message = "Hund tillagd till adoptions lista";
                }
                //tömmer förmulär
                ModelState.Clear();
            }
            //returnerar vy
            return View();
        }
    }

}
