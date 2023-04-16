using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebLection2.Models;

namespace WebLection2.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Entry() 
        {
            return View("EntryView"); 
        }
       

        [HttpGet]
        public ViewResult Input()
        {
            return View("InputView");
        }

        [HttpPost]
        public ViewResult Input(PersonReview guestResponse)
        {
            if (ModelState.IsValid)
            {
                guestResponse.CreatedAt = DateTime.Now.ToString("dd-MMM-yy", new System.Globalization.CultureInfo("en-US"));
                Repository.AddResponse(guestResponse);
                return View("ThanksView", guestResponse);
            }
            else
            {
                return View("InputView");
            }
        }

        public ViewResult List()
        {
            return View("ListView", Repository.Responses);
                
        }
    }

}