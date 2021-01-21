using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using AutoParts.Models;
using AutoParts.Models.Entities;
using AutoParts.Models.ViewModels;
using System;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace AutoParts.Controllers
{
    [Authorize]
    public class RequestController : Controller
    {
        private ApplicationContext db;
        public RequestController(ApplicationContext context)
        {
            db = context;

        }
        public IActionResult Request()
        {
            return View();
        }


        public async Task<IActionResult> DoRequest(RequestModel model)
        {
            string userName = HttpContext.User.Identity.Name;
            User user = db.Users.FirstOrDefault(u => u.Login == userName);
            if (user == null) return NotFound();

            if (model.Detail != null && model.Сontacts != null)
            {
                db.Requests.Add(new Request { Detail = model.Detail, Note = model.Note, Сontacts = model.Сontacts, UserId = user.Id });
                await db.SaveChangesAsync();
            }
            return RedirectToAction("ShowAll", "Catalog");
        }        
    }        
}
