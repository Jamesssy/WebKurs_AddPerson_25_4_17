using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebKurs_AddPerson_25_4_17.Model;

namespace WebKurs_AddPerson_25_4_17.Controllers
{
    public class AddPersonController : Controller
    {
        // GET: AddPerson
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(SimplePerson sp)
        {

            //var a = ModelState.Values.ToList();

            //bool isValid = ModelState.IsValid;
            //if (a[0].Errors.Count > 0 & a[1].Errors.Count > 0)
            //    return BadRequest($"Name and Age is invalid");
            //if (a[1].Errors.Count > 0)
            //return BadRequest($"Name is invalid");
            //if (a[0].Errors.Count > 0)
            //    return BadRequest($"Age is invalid");


            //else
            //    return Ok($"{sp.Name} med åldern {sp.Age} lades till i databasen");

            var a = ModelState.Values.ToList();

            bool isValid = ModelState.IsValid;

            if(!isValid)
            {
                return View("Index");
            }

            return View("PersonAdded", sp);

            //if (a[0].Errors.Count > 0 & a[1].Errors.Count > 0)
            //    return View("BadPerson");
            //if (a[1].Errors.Count > 0)
            //    return View("BadPerson");
            //if (a[0].Errors.Count > 0)
            //    return View("BadPerson");


            //else
            //    return View("PersonAdded", sp);


        }


       

        
    }
}