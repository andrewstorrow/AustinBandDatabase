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

        // GET: Band
        public ActionResult Index()
        {
            var bands = _bandRepository.GetBands();

            return View(bands);
        }


        // GET: Band/Detail/Id
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var band = _bandRepository.GetBand(id.Value);

            return View(band);
        }
    }
}