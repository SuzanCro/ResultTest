using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResultTest.UI.Controllers
{
    public class HomeController : Controller
    {
        List<StudentDetails> details;
        List<StudentMarks> studentMarks;
       
        public HomeController()
        {
           details = new List<StudentDetails>()
            {
                new StudentDetails{Id=1,FirstName="Raghuvir",LastName="Singh",SymbolNo="1"},
                new StudentDetails{Id=2,FirstName="Mahesh",LastName="Magar",SymbolNo="2"},
                new StudentDetails{Id=3,FirstName="Devendra",LastName="Suvedi",SymbolNo="3"},
                new StudentDetails{Id=4,FirstName="Mohan",LastName="Lal",SymbolNo="4"}

            };

            studentMarks = new List<StudentMarks>()
            {
                new StudentMarks{Id=1,Nepali=40,English=55,Math=22,Science=40},
                new StudentMarks{Id=2,Nepali=70,English=70,Math=60,Science=50},
                new StudentMarks{Id=3,Nepali=80,English=75,Math=79,Science=90},
                new StudentMarks{Id=4,Nepali=40,English=55,Math=22,Science=40}

            };
          

            
        }
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ResultService result)
        {
            ResultService data = new ResultService();
            data.details = details.Where(x => x.SymbolNo.ToString() == result.details.SymbolNo.ToString()).SingleOrDefault();
            data.marks = studentMarks.Where(x => x.Id.ToString() == data.details.Id.ToString()).SingleOrDefault();
            


         





            return View("Result",data);
        }
        public ActionResult Result()
        {
            
            var data = new ResultService();
            
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}