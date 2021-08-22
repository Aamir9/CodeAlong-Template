using CodeAlong_Template.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlong_Template.Controllers
{
    public class DemoController : Controller
    {
      
        

        // GET: DemoController/Create
        public ActionResult Create()
        {
            ViewData["Fever"] = "";
            ViewData["shypothermia"] = "";
            return View();
        }

        // POST: DemoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fever model)
        {

            if (model.Unit == "Fahrenheit")
            {
                if(model.CheckFever >= 97)
                {
                    ViewData["Message"] = "you have fever and ";
                    if (model.Ishypothermia)
                    {
                        ViewData["shypothermia"] = "also low shypothermia";
                    }
                    else
                    {
                        ViewData["shypothermia"] = "";

                    }
                   
                }
            }
            else
            {
                if(model.CheckFever >= 37)
                {
                    ViewData["Message"] = "you have fever and ";
                    if (model.Ishypothermia)
                    {
                        ViewData["shypothermia"] = "also low shypothermia";
                    }
                    else
                    {
                        ViewData["shypothermia"] = "";
                    }
                }

            }
                return View();
            
        }

       
     
     
    }
}
