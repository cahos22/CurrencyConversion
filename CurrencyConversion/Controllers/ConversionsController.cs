using CurrencyConversion.Models;
using CurrencyConversion.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConversion.Controllers
{
    public class ConversionsController : Controller
    {

        private readonly IConfiguration _config;
        public ConversionsController(IConfiguration config) 
        {
            _config = config;
        }
        // GET: ConversionController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConversionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult New()
        {
            var currencyTypes = _context.MembershipTypes.ToList();
            var viewModel = new ConversionFormViewModel
            {
                Conversion = new Conversion(),
                Currencies = currencyTypes
            };

            return View("CustomerForm", viewModel);
        }


        // POST: ConversionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Convert(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConversionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConversionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ConversionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConversionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
