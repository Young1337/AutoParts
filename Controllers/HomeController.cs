﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AutoParts.Models;
using Microsoft.AspNetCore.Authorization;
using SelectPdf;
using AutoParts.Models.Entities;
using AutoParts.Models.ViewModels;

namespace AutoParts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }        
        [Authorize(Roles = "admin")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Operations()
        {
            IQueryable<Operation> prod = _context.Operations;

            return View(prod.ToList());
        }
        public IActionResult Report()
        {
            IQueryable<Request> prod = _context.Requests;
            
            return View(prod.ToList());
        }

        public IActionResult Task3()
        {
            IQueryable<Product> prod = _context.Products;

            return View(prod.ToList());
        }

        public IActionResult Task4()
        {
            IQueryable<Task4Model> prod = (from u in _context.Users
                                           join o in _context.Operations
                                           on u.Id equals o.UserId
                                           join p in _context.Products
                                           on o.ProductId equals p.Id
                                           select new Task4Model {
                                               ProductName = p.Name,
                                               UserName = u.Name,
                                               OperationId = o.Id
                                           });
            return View(prod.ToList());
        }
        public IActionResult GeneratePdf(string html)
        {
            html = html.Replace("StrTag","<").Replace("EndTag",">");

            HtmlToPdf oHtmlToPdfd = new HtmlToPdf();
            PdfDocument oPdfDocument = oHtmlToPdfd.ConvertHtmlString(html);
            byte[] pdf = oPdfDocument.Save();
            oPdfDocument.Close();

            return File(
                pdf,
                "application/pdf",
                "Reportlist.pdf"
                );
        }
    }
}
