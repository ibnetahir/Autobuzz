using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using AutoBuzz.Models;

namespace AutoBuzz.Controllers
{
   
    public class ShopController : Controller
    {
        // GET: Shop
        
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult products_grid()
        {
            return View();
        }
        public ActionResult products_list()
        {
            return View();
        }
        public ActionResult cart()
        {
            return View();
        }
        public ActionResult single_product()
        {
            return View();
        }
    }
}