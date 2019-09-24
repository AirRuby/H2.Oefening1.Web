using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class ReponseTypesController : Controller
    {
        public IActionResult Fail()
        {
            return NotFound();
        }

        public IActionResult File()
        {
            string path = "~/PPT/Oefeningen-Controllers.pptx";
            string content = "application/vnd.ms-powerpoint";
            return File(path, content);
        }

        public IActionResult Forward()
        {
            return Redirect("File");
        }
    }
}