using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SixteenClothingTemplate.Data;
using SixteenClothingTemplate.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SixteenClothingTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Product prod = _context.Products.FirstOrDefault();
            return View(prod);
        }
    }
}
