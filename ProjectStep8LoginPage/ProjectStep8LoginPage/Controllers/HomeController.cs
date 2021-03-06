﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectStep8LoginPage.Models;

namespace ProjectStep8LoginPage.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public IActionResult Index()
      {
         return View();
      }

      [HttpGet]
      public IActionResult Login()
      {
         return View();
      }

      [HttpPost]
      public IActionResult Login(Login login)
      {
         return View(); //this will lead to a different page as the project further develops.
      }

      [HttpGet]
      public IActionResult Inventory()
      {
         return View();
      }

      [HttpPost]
      public IActionResult Inventory(Inventory Inventory)
      {
         InventoryRepository.AddResponse(Inventory);
         return View("InventoryDetails", Inventory);
      }

      public IActionResult InventoryDetails()
      {
         return View();
      }

      public IActionResult Privacy()
      {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
