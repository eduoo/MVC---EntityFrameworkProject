using Market.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Market.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Order()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Order (Order order)
        {
            ServiceReference1.Order o = new ServiceReference1.Order();
            o.City = order.City;
            o.Name = order.Name;
            o.Id = order.Id;
            o.Phone = order.Phone;
            o.Product = order.Product;
            o.Surname = order.Surname;
            ServiceReference1.MARKETSoapClient ws = new ServiceReference1.MARKETSoapClient();
            int num = ws.AddOrder(o);
            return View(order);
        }
        
    }
}