using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GXXD.Domain.Concrete;
using GXXD.Domain.Entities;

namespace GXBMXD.Controllers
{     
    public class AdminsController : Controller
    {
        private EFDContext db = new EFDContext();

        // GET: Admins
        public ActionResult Index()
        {
            return View(db.Grands.ToList());
        }

        // GET: Admins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grand grand = db.Grands.Find(id);
            if (grand == null)
            {
                return HttpNotFound();
            }
            return View(grand);
        }

        // GET: Admins/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admins/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,科目一,科目二,科目三")] Grand grand)
        {
            if (ModelState.IsValid)
            {
                db.Grands.Add(grand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grand);
        }

        // GET: Admins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grand grand = db.Grands.Find(id);
            if (grand == null)
            {
                return HttpNotFound();
            }
            return View(grand);
        }

        // POST: Admins/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,科目一,科目二,科目三")] Grand grand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grand);
        }

        // GET: Admins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grand grand = db.Grands.Find(id);
            if (grand == null)
            {
                return HttpNotFound();
            }
            return View(grand);
        }

        // POST: Admins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grand grand = db.Grands.Find(id);
            db.Grands.Remove(grand);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
