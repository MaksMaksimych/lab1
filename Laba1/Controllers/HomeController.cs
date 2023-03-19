using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laba1.Models;

namespace Laba1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse x)
        {
            switch(x.Operation)
            {
                case "+":
                    x.Result = (decimal)(x.Operand1 + x.Operand2);
                    break;
                case "-":
                    x.Result = (decimal)(x.Operand1 - x.Operand2);
                    break;
                case "*":
                    x.Result = (decimal)(x.Operand1 * x.Operand2);
                    break;
                case "/":
                    x.Result = (decimal)(x.Operand1 / x.Operand2);
                    break;
            }

            ViewBag.ResultSecond = 10;
            
            return View("Thanks", x);
        }

        

    }
}
