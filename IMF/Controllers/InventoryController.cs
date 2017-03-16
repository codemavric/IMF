using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IMF.Models;

namespace IMF.Controllers
{
    public class InventoryController : Controller
    {
        // GET: Inventory

        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Input(IMFInventory item)
        {
            if (ModelState.IsValid)
            {
                ViewBag.ItemDetails =

                    $"Cost Price: {item.costPrice.ToString("C")}" + "<br/> <br/>" +
                    $"Markup: {item.markup}" + "%" + "<br/> <br/>" +
                    $"Selling Price: {item.calcSellingPrice().ToString("C")}";

                return View("Output");

            }
            else
            {
                return View();
            }
        }
    }
}