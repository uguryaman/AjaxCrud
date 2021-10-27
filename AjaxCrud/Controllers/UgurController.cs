using AjaxCrud.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Controllers
{
    public class UgurController : Controller
    {

        Context _context;

        public UgurController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var c = _context.Admins.ToList();
            return View(c);
        }
        [HttpGet]
        public IActionResult AddorEdit(int id)
        {
            var value = _context.Admins.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AddorEdit(Admin admin)
        {
            if (admin.AdminId == 0)
            {
                _context.Add(admin);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                _context.Update(admin);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
