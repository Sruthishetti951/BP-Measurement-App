using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BPMeasurmentApp.Models;
using System.Diagnostics.Metrics;

namespace BPMeasurmentApp.Controllers
{
	public class BPMeasurementController : Controller
	{

        //Connects with Database via BPMeasurementDbContext to get and perform operations on BPMeasurement data
        // GET: BPMeasurementController

        BPMeasurementDbContext _bPMeasurementContext;
		public BPMeasurementController(BPMeasurementDbContext bPMeasurementContext )
        {
            _bPMeasurementContext = bPMeasurementContext;
        }


        // Retrives the list of BPMeasurement and positions from the DB, stores positions in ViewBag and returns list to the view
        [HttpGet]
        public ActionResult Index()
		{
			List<BPMeasurementModel> BPMeasurement= _bPMeasurementContext.BPMeasurementSet.ToList();
			List<Position> positions=_bPMeasurementContext.Position.ToList();
			ViewBag.positions = positions;
            return View(BPMeasurement);
		}

        // Retrives the list of positions from the DB, stores positions in ViewBag and returns list to the view

        [HttpGet]
        public ActionResult AddNewMeasurement()
        {
            List<Position> positions = _bPMeasurementContext.Position.ToList();
            ViewBag.positions = positions;
            return View();
        }


        //Adds new BP measurement to DB and shows it on View and also shows success message and navigates to All Measurements page
        // POST: BPMeasurementController/AddNewMeasurement
        [HttpPost]
		public ActionResult AddNewMeasurement(BPMeasurementModel BPMeasurement)
		{
			try
			{
                if(ModelState.IsValid)
                {
                    TempData["SuccessMessage"] = "Item added successfully!";
                    _bPMeasurementContext.Add(BPMeasurement);
                    _bPMeasurementContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                List<Position> positions = _bPMeasurementContext.Position.ToList();
                ViewBag.positions = positions;
                return View();
            }
			catch
			{
                List<Position> positions = _bPMeasurementContext.Position.ToList();
                ViewBag.positions = positions;
                return View();
			}
		}

        //Opens the edit page with prefilled values for selected measurement
        // GET: BPMeasurementController/EditMeasurement/5
        [HttpGet]
        public ActionResult EditMeasurement(int id)
		{
			BPMeasurementModel bPMeasurement = _bPMeasurementContext.BPMeasurementSet.Find(id);
            List<Position> positions = _bPMeasurementContext.Position.ToList();
            ViewBag.positions = positions;
            return View(bPMeasurement);
		}

        //Edits the BP measurement,updates the changes to DB and shows on UI and navigates to All Measurements page
        // POST: BPMeasurementController/EditMeasurement/5
        [HttpPost]
		public ActionResult EditMeasurement(BPMeasurementModel BPMeasurement)
		{
			try
			{
                if (ModelState.IsValid)
                {
                    TempData["SuccessMessage"] = "Item updated successfully!";
                    _bPMeasurementContext.Update(BPMeasurement);
                    _bPMeasurementContext.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                List<Position> positions = _bPMeasurementContext.Position.ToList();
                ViewBag.positions = positions;
                return View();
            }
			catch
			{
                List<Position> positions = _bPMeasurementContext.Position.ToList();
                ViewBag.positions = positions;
                return View();
			}
		}

        //Opens the delete confirmation page
        // GET: BPMeasurementController/DeleteMeasurement/5
        public ActionResult DeleteMeasurement(int id)
		{
			BPMeasurementModel bPMeasurement = _bPMeasurementContext.BPMeasurementSet.Find(id);
			return View(bPMeasurement);
		}


		//After confirmation deletes the record and navigates to All Measurements page
        // POST: BPMeasurementController/DeleteMeasurement/5
        [HttpPost]
		public ActionResult DeleteMeasurement(BPMeasurementModel bPMeasurementModel)
        {
            try
			{
                TempData["SuccessMessage"] = "Item deleted successfully!";
                _bPMeasurementContext.Remove(bPMeasurementModel);
				_bPMeasurementContext.SaveChanges();
                return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}
