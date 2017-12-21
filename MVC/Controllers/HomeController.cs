using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using BlackLight.Recruitment.MVC.Models;

namespace BlackLight.Recruitment.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new ContactUsViewModel());
        }

        public ActionResult Thanks(ContactUsViewModel contactUsViewModel)
        {

            if (string.IsNullOrEmpty(contactUsViewModel.Name))
                ModelState.AddModelError("Name", "Name is required");

            if (string.IsNullOrEmpty(contactUsViewModel.Email))
            {
                ModelState.AddModelError("Email", "Email is reuqired");
            }
            else
            {
                string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex re = new Regex(emailRegex);
                if (!re.IsMatch(contactUsViewModel.Email))
                {
                    ModelState.AddModelError("Email", "Email is not valid");
                }
            }

            if (!ModelState.IsValid)
                return View("Contact", contactUsViewModel);


            var model = new ThanksViewModel
            {
                Name = contactUsViewModel.Name
            };
            return View(model);
        }
	}
}