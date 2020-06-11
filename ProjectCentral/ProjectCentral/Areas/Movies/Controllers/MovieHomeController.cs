﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectCentral.Areas.Movies.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectCentral.Areas.Movies.Controllers
{
    [Area("Movies")]
    public class MovieHomeController : Controller
    {
        private MovieContextModel context;

        public MovieHomeController(MovieContextModel ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}