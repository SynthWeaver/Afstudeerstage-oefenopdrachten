﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index(string message)
        {
            ViewBag.Message = message;
            return View();
        }
    }
}