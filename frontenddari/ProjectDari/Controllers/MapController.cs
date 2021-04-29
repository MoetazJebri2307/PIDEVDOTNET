using ProjectDari.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectDari.Controllers
{
    public class MapController : Controller
    {


        // List<map> mydata= new List<map>();

        map rec = new map
        {
            lat = 36.809328,
            lon = 10.086327,
           

        };
        map rec2 = new map
        {
            lat = 37.809328,
            lon = 10.086327,
            

        };

        map rec3 = new map
        {
            lat = 37.809328,
            lon = 10.086327,
           

        };
        // GET: Map
        public ActionResult Map()
        {

            

            
            return View();
        }
    }
}