using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Whatsmyname()
        {
            return Content($"Niels Vanden Broecke {DateTime.Now}");
        }

        public IActionResult Index()
        {

            string links = "<ul>" +
                                "<li><a href='http://www.google.be'> Google </a></li> " +
                                "<li><a href='http://www.hln.be'> HLN </a></li> " +
                                "<li><a href='http://www.facebook.be'> facebook </a></li> " +
                                "<li><a href='https://localhost:44319/Home/Whatsmyname'> Whatsmyname </a></li> " +
                                "<li><a href='https://localhost:44319/ReponseTypes/File'> File </a></li> " +
                                "<li><a href='https://localhost:44319/ReponseTypes/Forward'> Forward </a></li> " +
                            "</ul>";
            return Content(links, "text/html");
        }
    }
}