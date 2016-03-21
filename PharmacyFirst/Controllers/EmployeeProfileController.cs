using PharmacyFirst.Context;
using PharmacyFirst.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace PharmacyFirst.Controllers
{
    public class EmployeeProfileController : Controller
    {
        private EmployeeProfileContext db = new EmployeeProfileContext();

        // GET: EmployeeProfile
        public ActionResult Index()
        {
            return View(db.EmployeeProfile.ToList());
        }

        // GET: EmployeeProfile/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            EmployeeProfile EmployeeProfile = db.EmployeeProfile.Find(id);
            if (EmployeeProfile == null)
                return HttpNotFound();
            return View(EmployeeProfile);
        }

        // GET: EmployeeProfile/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeProfile/Create
        [HttpPost]
        public ActionResult Create(EmployeeProfile EmployeeProfile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.EmployeeProfile.Add(EmployeeProfile);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(EmployeeProfile);
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeProfile/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            EmployeeProfile EmployeeProfile = db.EmployeeProfile.Find(id);
            if (EmployeeProfile == null)
                return HttpNotFound();
            return View(EmployeeProfile);
        }

        // POST: EmployeeProfile/Edit/5
        [HttpPost]
        public ActionResult Edit(EmployeeProfile EmployeeProfile)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(EmployeeProfile).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(EmployeeProfile);
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeProfile/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            EmployeeProfile EmployeeProfile = db.EmployeeProfile.Find(id);
            if (EmployeeProfile == null)
                return HttpNotFound();
            return View(EmployeeProfile);
        }

        // POST: EmployeeProfile/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, EmployeeProfile Employee)
        {
            try
            {
                EmployeeProfile EmployeeProfile = new EmployeeProfile();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    EmployeeProfile = db.EmployeeProfile.Find(id);
                    if (EmployeeProfile == null)
                        return HttpNotFound();

                    db.EmployeeProfile.Remove(db.EmployeeProfile.Find(id));
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(EmployeeProfile);
            }
            catch
            {
                return View();
            }
        }
    }
}
