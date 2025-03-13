using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KurMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (KurlarService.KurServiceClient client = new KurlarService.KurServiceClient())
            {
                if (TempData["Kurlar"] != null)
                {
                    ViewBag.Kurlar =(List<double>) TempData["Kurlar"];

                }
                else
                {
                    ViewBag.Kurlar = new List<double>();
                }
                    var paraBirimleri = client.ParaBirimileriGetir().ToList();
                return View(paraBirimleri);

            }
           
        }
        public ActionResult KurlariGetir(string paraBirimi)
        {
            using(KurlarService.KurServiceClient client = new KurlarService.KurServiceClient())
            {
                var kurlar = client.KurlariGetir(paraBirimi).ToList();
                TempData["Kurlar"] = kurlar;
                return RedirectToAction("Index");
            }
        }
    }
}