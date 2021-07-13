using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebFront.Models;

namespace WebFront.Controllers
{
    public class FacturasController : Controller
    {
        // GET: FacturasController
        public ActionResult Index()
        {
            var wc = new System.Net.WebClient();
            var url = "https://localhost:44351/api/Facturas";

            //invocamos al web service rest
            var res = wc.DownloadString(url);

            //deserializar el json
            Facturas[] data = Newtonsoft.Json.JsonConvert.DeserializeObject<Facturas[]>(res);
            return View(data);
        }

        // GET: FacturasController/Details/5
        public ActionResult Details(int id)
        {
            var wc = new System.Net.WebClient();
            var url = "https://localhost:44351/api/Facturas/" + id.ToString();

            //invocamos al web service rest
            var res = wc.DownloadString(url);

            //deserializar el json
            Facturas data = Newtonsoft.Json.JsonConvert.DeserializeObject<Facturas>(res);

            return View(data);
        }
    }
}
