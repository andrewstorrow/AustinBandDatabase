using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AustinBandDatabase.Data;
using AustinBandDatabase.Models;

namespace AustinBandDatabase.Controllers
{
    public class BandController : Controller
    {
        private BandRepository _bandRepository = null;

        public BandController()
        {
            _bandRepository = new BandRepository();
        }

        public ActionResult Index()
        {
            var bands = _bandRepository.GetBands();

            return View(bands);
        }

        public ActionResult Details(int id)
        {
            return View ();
        }
    }
}